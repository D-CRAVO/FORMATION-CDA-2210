drop table if exists auteur_livre;
drop table if exists auteur;
drop table if exists emprunt;
drop table if exists client;
drop table if exists livre;
drop table if exists adresse;

create table auteur
(
	auteur_id int identity(1,1) 
	,auteur_nom varchar(50)
	,auteur_prenom varchar(50)
	,auteur_pseudonyme varchar(50)
	,primary key (auteur_id)
)
;

create table livre
(
	livre_numero int not null
	,livre_titre varchar(100) not null
	,livre_editeur varchar(100) not null
	,livre_date_achat date not null
	,livre_etat varchar(50) not null
	,primary key (livre_numero)
)
;

create table auteur_livre
(
	livre_numero int not null
	,auteur_id int not null
	,primary key (livre_numero, auteur_id)
	,foreign key (livre_numero) references livre(livre_numero)
	,foreign key (auteur_id) references auteur(auteur_id)
)
;

create table adresse
(
	adresse_id int identity(1,1)
	,adresse_numero_voie varchar(25)
	,adresse_voie varchar(50)
	,adresse_complement_adresse varchar(100)
	,adresse_code_postal char(5) not null
	,adresse_ville varchar(50) not null
	,primary key (adresse_id)
)
;

create table client
(
	client_id int identity(1,1)
	,client_nom varchar(50) not null
	,client_prenom varchar(50) not null
	,client_caution int not null
	,adresse_id int
	,primary key (client_id)
)
;

create table emprunt
(
	emprunt_id int identity(1,1)
	,emprunt_date_heure_emprunt date not null
	,emprunt_date_heure_retour date
	,livre_numero int not null
	,client_id int not null
	,primary key (emprunt_id)
)
;

alter table client
	add foreign key (adresse_id) references adresse(adresse_id)

alter table emprunt
	add foreign key (livre_numero) references livre(livre_numero)

alter table emprunt
	add foreign key (client_id) references client(client_id)


