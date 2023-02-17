drop table if exists plage_terrain;
drop table if exists terrain;
drop table if exists plage;
drop table if exists ville;
drop table if exists departement;
drop table if exists responsable;

create table responsable
(
	responsable_id serial
	,responsable_nom varchar(100)
	,responsable_prenom varchar(50)
)
;

alter table responsable
	add primary key (responsable_id)
;

create table departement
(
	departement_numero char(3)
	,departement_nom varchar(40)
	,responsable_id int
)
;

alter table departement
	add primary key (departement_numero)
	,add foreign key (responsable_id) references responsable(responsable_id)
;

create table ville
(
	ville_code_insee char(5)
	,ville_code_postal char(5)
	,ville_nom varchar(50)
	,ville_nb_touristes_annuel int
	,departement_numero char(3)
)
;

alter table ville
	add primary key (ville_code_insee)
	,add foreign key (departement_numero) references departement(departement_numero)
;

create table plage
(
	plage_id serial
	,plage_longueur decimal(5,2)
	,plage_nom varchar(50)
	,ville_code_insee char(5)
)
;

alter table plage
	add primary key (plage_id)
	,add foreign key (ville_code_insee) references ville(ville_code_insee)
;

create table terrain
(
	nature_terrain_id serial
	,nature_terrain_nom varchar(255)
)
;

alter table terrain
	add primary key (nature_terrain_id)
;

create table plage_terrain
(
	plage_id int
	,nature_terrain_id int
)
;

alter table plage_terrain
	add primary key (plage_id, nature_terrain_id)
;