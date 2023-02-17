use db303_carsowners_v2;

drop table if exists registrations;
drop table if exists cars;
drop table if exists brands;
drop table if exists owners;

create table brands
(
	brand_id int identity(1,1)
	,brand_name varchar(50) not null
	,brand_slogan varchar(255) null
	,primary key (brand_id)
);

create table owners
(
	owner_id int identity(1,1)
	,owner_lastname varchar(50) not null
	,owner_firstname varchar(50) not null
	,primary key (owner_id)
);

create table cars
(
	car_id int
	,car_name varchar(100) not null
	,brand_id int not null
	,primary key (car_id)
);

create table registrations
(
	car_id int not null
	,car_owner_id int not null
	,registration char(9) not null unique
	,primary key (car_id, car_owner_id)
);

alter table registrations
	add constraint fk_registration_cars foreign key (car_id) references cars(car_id)
		,constraint fk_registration_owners foreign key (car_owner_id) references owners(owner_id)

alter table cars
	add constraint fk_cars_brands foreign key (brand_id) references brands(brand_id)
;