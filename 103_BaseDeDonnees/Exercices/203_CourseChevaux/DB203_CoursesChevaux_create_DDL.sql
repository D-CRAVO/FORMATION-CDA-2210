drop table if exists epreuve_cheval;
drop table if exists cheval;
drop table if exists pari;
drop table if exists categorie;
drop table if exists course;
drop table if exists ordre;


create table ordre
(
	ordre_id int primary key identity(1,1)
	,ordre_arrivee varchar(150) not null
)
;

create table course
(
	course_nom varchar(50) primary key not null
)
;

create table epreuve
(
	epreuve_id int primary key identity(1,1)
)
;

create table categorie
(
	categorie_id int primary key identity(1,1)
	,categorie_libelle varchar(50) not null
)
;

create table pari
(
	pari_id int primary key identity(1,1)
	,pari_somme decimal(10,2) not null
	,ordre_id int
	,categorie_id int
	,epreuve_id int
	,foreign key (ordre_id) references ordre(ordre_id)
	,foreign key (categorie_id) references categorie(categorie_id)
	,foreign key (epreuve_id) references epreuve(epreuve_id)
)
;

create table cheval
(
	cheval_nom varchar(50) primary key not null
)
;

create table epreuve_cheval
(
	epreuve_id int
	,cheval_nom varchar(50) 
	,cheval_numero tinyint not null unique
	,primary key (epreuve_id, cheval_nom)
	,foreign key (epreuve_id) references epreuve(epreuve_id)
	,foreign key (cheval_nom) references cheval(cheval_nom)
)
;