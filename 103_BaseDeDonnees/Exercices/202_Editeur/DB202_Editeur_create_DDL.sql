
drop table if exists Auteur_Commande;
drop table if exists Auteur_Livre;
drop table if exists Auteur;
drop table if exists Commande;
drop table if exists Distinction;
drop table if exists Edition;
drop table if exists Livre;
drop table if exists Librairie;
drop table if exists Adresse;

create table Adresse
(
	adresse_id int identity(1,1)
	,adresse_numero varchar(5)
	,adresse_libelle_voie varchar(33)
	,adresse_complement_remise varchar(38)
	,adresse_complement_distribution varchar(38)
	,adresse_code_postal char(5) not null
	,adresse_localite varchar(33) not null
	,adresse_pays varchar(38)
	,primary key (adresse_id)
)
;

create table Librairie
(
	librairie_id int identity(1,1)
	,librairie_nom varchar(50) not null
	,adresse_id int
	,primary key (librairie_id)
)
;

create table Livre
(
	livre_id int identity(1,1)
	,livre_titre varchar(100) not null
	,primary key (livre_id)
)
;

create table Edition
(
	edition_ISBN char(17)
	,edition_date date not null
	,edition_ordre varchar(50) not null
	,livre_id int
	,primary key (edition_ISBN)
)
;

create table Distinction
(
	distinction_id int identity(1,1)
	,distinction_libelle varchar(50) not null
	,distinction_annee int not null
	,livre_id int
	,primary key (distinction_id)
)
;

create table Commande
(
	commande_id int identity(1,1)
	,commande_prix_vente_HT decimal(6,2) not null
	,commande_taxe decimal(5,2) not null
	,commande_quantite int not null
	,librairie_id int
	,primary key (commande_id)
)
;

create table Auteur
(
	auteur_id int identity(1,1)
	,auteur_nom varchar(50)
	,auteur_prenom varchar(50)
	,auteur_pseudonyme varchar(100)
	,primary key (auteur_id)
)
;

-- Faut-il indiquer not null pour les foreign key ?

create table Auteur_Livre
(
	auteur_id int 
	,livre_id int
	,primary key (auteur_id, livre_id)
)
;

create table Auteur_Commande
(
	auteur_id int
	,commande_id int
	,droits_auteur decimal(5,2) not null
	,primary key (auteur_id, commande_id)
)
;

alter table Librairie
	add foreign key (adresse_id) references Adresse(adresse_id)
;

alter table Edition
	add foreign key (livre_id) references Livre(livre_id)
;

alter table Distinction
	add foreign key (livre_id) references Livre(livre_id)
;

alter table Commande
	add foreign key (librairie_id) references Librairie(librairie_id)
;

-- Comment faire pour intégrer plusieurs foreign key dans un même alter table ?

alter table Auteur_Livre
	add foreign key (auteur_id) references Auteur(auteur_id)
;

alter table Auteur_Livre
	add foreign key (livre_id) references Livre(livre_id)
;

alter table Auteur_Commande
	add foreign key (auteur_id) references Auteur(auteur_id)
;

alter table Auteur_Commande
	add foreign key (commande_id) references Commande(commande_id)
;
