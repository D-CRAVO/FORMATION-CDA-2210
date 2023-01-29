drop table if exists Acteur_Titre;
drop table if exists Publics_Tite;
drop table if exists Genre_Titre;
drop table if exists Emprunt;
drop table if exists Client;
drop table if exists Adresse;
drop table if exists Cassette;
drop table if exists Etat;
drop table if exists Magasin;
drop table if exists Titre;
drop table if exists Acteur;
drop table if exists Realisateur;
drop table if exists Publics;
drop table if exists Genre;

create table Genre
(
	genre_id int identity(1,1)
	,genre_libelle varchar(50) not null
	,primary key (genre_id)
)
;

create table Publics
(
	publics_id int identity(1,1)
	,publics_libelle varchar(50)
	,primary key (publics_id)
)
;