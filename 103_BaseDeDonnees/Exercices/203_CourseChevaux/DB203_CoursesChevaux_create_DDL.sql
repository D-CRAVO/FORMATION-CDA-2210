drop table if exists Course_Cheval;
drop table if exists Cheval;
drop table if exists Pari;
drop table if exists Course;
drop table if exists Categorie;


create table Categorie
(
	categorie_id int identity(1,1)
	,categorie_libelle varchar(50) not null
	,primary key (categorie_id)
)
;

create table Course
(
	course_nom varchar(50) not null
	,course_date date not null
	,course_resultat varchar(50) not null
	,primary key (course_nom)
)
;

-- Est-ce acceptable d'intégrer directement les foreign key au creat table ?

create table Pari
(
	pari_id int identity(1,1)
	,pari_somme decimal(10,2) not null
	,pari_ordre varchar(50) not null
	,categorie_id int
	,course_nom varchar(50)
	,primary key (pari_id)
	,foreign key (categorie_id) references Categorie(categorie_id)
	,foreign key (course_nom) references Course(course_nom)
)
;

create table Cheval
(
	cheval_nom varchar(50) not null
	,cheval_numero tinyint not null
	,primary key (cheval_nom)
)
;

create table Course_Cheval
(
	course_nom varchar(50)
	,cheval_nom varchar(50) 
	,primary key (course_nom, cheval_nom)
	,foreign key (course_nom) references Course(course_nom)
	,foreign key (cheval_nom) references Cheval(cheval_nom)
)
;