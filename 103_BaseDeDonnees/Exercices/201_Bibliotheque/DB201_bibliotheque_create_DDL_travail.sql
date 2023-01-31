/* commentaire multi lignes */
-- commentaire sur 1 ligne

-- Sélection de la base de données "db201_bibliotheque"
use db201_bibliotheque;

-- DDL create / alter / drop (Data Definition Language)

drop table if exists livres_auteurs;
drop table if exists livres;
drop table if exists 
drop table if exists editeurs;


create table editeurs
(
	editeur_id int primary key identity(1,1)
	,editeur_nom varchar(100) not null default 'editeur inconnu'
)
;

create table auteurs
(
	auteur_id int
	,auteur_nom varchar(100) not null
	,auteur_prenom varchar(100) null
	,primary key (auteur_id) -- syntaxe recommandée
)
;

create table etats_livres
(
	etat_livre_id int identity(1,1)
	,etat_livre_nom varchar(50)
	,primary key (etat_livre_id)
)
;

create table livres
(
	livre_id int identity(1,1)
	,livre_nom char(17) not null
	,livre_titre varchar(255) not null
	,livre_date_achat date not null default current_timestamp
	,etat_livre_commentaire varchar(1000) null
	,etat_livre_id int not null
	,editeur_id int not null
	,primary key (livre_id)
	,foreign key (etat_livre_id) references etats_livres(etat_livre_id)
	,constraint FK_livres_editeur foreign key (editeur_id) references editeurs(editeur_id)
)
;

create table livres_auteurs
(
	auteur_id int 
	,livre_id int
	,primary key (auteur_id, livre_id)
)
;

alter table livres_auteurs
 add foreign key (auteur_id) references auteurs(auteur_id)
 ,constraint 

/* alter table auteurs
	add primary key (auteur_id) */