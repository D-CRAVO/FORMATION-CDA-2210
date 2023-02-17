drop table if exists cars;
drop table if exists owners;
drop table if exists brands;

create table owners
(
	owner_id int identity(1,1)
	,owner_lastname varchar(50) not null
	,owner_firstname varchar(50) not null
	,primary key(owner_id)
);

create table brands
(
	brand_id int identity(1,1)
	,brand_name varchar(50) not null
	,brand_slogan varchar(255)
);

create table cars
(
	car_id int
	,car_registration char(9) unique not null
	,car_name varchar(100) not null
	,car_owner_id int not null
	,brand_id int not null
);