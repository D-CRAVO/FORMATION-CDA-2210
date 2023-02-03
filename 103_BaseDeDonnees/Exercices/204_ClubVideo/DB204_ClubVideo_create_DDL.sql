drop table if exists acteurs_titres;
drop table if exists genres_titres;
drop table if exists emprunts;
drop table if exists cassettes;
drop table if exists clients;
drop table if exists adresses;
drop table if exists etats;
drop table if exists titres;
drop table if exists realisateurs;
drop table if exists magasins;
drop table if exists acteurs;
drop table if exists nominatifs;
drop table if exists genres;
drop table if exists publics;

create table publics
(
	public_id int identity(1,1)
	,public_libelle varchar(50) not null
	,primary key (public_id)
);
create table genres
(
	genre_id int identity(1,1)
	,genre_libelle varchar(50) not null
	,primary key (genre_id)
);
create table nominatifs
(
	nominatif_id int identity(1,1)
	,nominatif_nom varchar(150) not null
	,nominatif_prenom varchar(50)
	,primary key (nominatif_id)
);
create table acteurs
(
	acteur_id int identity(1,1)
	,nominatif_id int not null
	,primary key (acteur_id)
);
create table magasins
(
	magasin_id int identity(1,1)
	,magasin_raison_sociale varchar(100) not null
	,primary key (magasin_id)
);
create table realisateurs
(
	realisateur_id int identity(1,1)
	,nominatif_id int not null
	,primary key (realisateur_id)
);
create table titres
(
	titre_id int identity(1,1)
	,titre_libelle varchar(255) not null
	,titre_duree smallint not null
	,realisateur_id int not null
	,public_id int not null
	,primary key (titre_id)
);
create table etats
(
	etat_id int identity(1,1)
	,etat_libelle varchar(50) not null
	,primary key (etat_id)
);
create table adresses
(
	adresse_id int identity(1,1)
	,adresse_numero varchar(5)
	,adresse_voie varchar(33)
	,adresse_complement_remise varchar(38)
	,adresse_complement_distribution varchar(38)
	,adresse_code_postal char(5) not null
	,adresse_ville varchar(33) not null
	,primary key (adresse_id)
);
create table clients
(
	client_id int identity(1,1)
	,client_caution int not null
	,nominatif_id int not null
	,adresse_id int not null
	,primary key (client_id)
);
create table cassettes
(
	cassette_numero char(13) not null unique
	,cassette_date_mise_en_service date not null
	,magasin_id int not null
	,etat_id int not null
	,titre_id int not null
	,primary key (cassette_numero)
);
create table emprunts
(
	emprunt_id int identity(1,1)
	,emprunt_date_heure_emprunt datetime not null
	,emprunt_date_heure_retour datetime
	,cassette_numero char(13) not null
	,client_id int not null
	,primary key (emprunt_id)
);
create table genres_titres
(
	genre_id int not null
	,titre_id int not null
	primary key (genre_id, titre_id)
);
create table acteurs_titres
(
	acteur_id int not null
	,titre_id int not null
	primary key (acteur_id, titre_id)
);

alter table acteurs_titres
	add foreign key (acteur_id) references acteurs(acteur_id)
		,foreign key (titre_id) references titres(titre_id)

alter table genres_titres
	add foreign key (genre_id) references genres(genre_id)
		,foreign key (titre_id) references titres(titre_id)

alter table emprunts
	add foreign key (cassette_numero) references cassettes(cassette_numero)
		,foreign key (client_id) references clients(client_id)

alter table cassettes 
	add foreign key (magasin_id) references magasins(magasin_id)
		,foreign key (etat_id) references etats(etat_id)
		,foreign key (titre_id) references titres(titre_id)

alter table clients
	add foreign key (nominatif_id) references nominatifs(nominatif_id)
		,foreign key (adresse_id) references adresses(adresse_id)

alter table acteurs
	add foreign key (nominatif_id) references nominatifs(nominatif_id)

alter table realisateurs
	add foreign key (nominatif_id) references nominatifs(nominatif_id)

alter table titres
	add foreign key (realisateur_id) references realisateurs(realisateur_id)
	,foreign key (public_id) references publics(public_id)
