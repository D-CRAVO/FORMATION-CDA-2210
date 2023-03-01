drop table if exists registrations;
drop table if exists cars;
drop table if exists owners;
drop table if exists brands;

create table brands
(
	brand_id int identity(1,1)
	,brand_name varchar(50) not null
	,brand_slogan varchar(255)
	,primary key(brand_id)
);

create table owners
(
	owner_id int identity(1,1)
	,owner_lastname varchar(50) not null
	,owner_firstname varchar(50) not null
	,primary key(owner_id)
);

create table cars
(
	car_id int unique not null
	,car_name varchar(100) not null
	,brand_id int not null
);

create table registrations
(
	registration char(9) unique not null
	,car_id int not null
	,owner_id int not null
	,primary key(car_id, owner_id)
);

alter table registrations
	add constraint fk_registrations_cars foreign key (car_id) references cars(car_id)
		,constraint fk_registrations_owners foreign key (owner_id) references owners(owner_id)
;

alter table cars
	add constraint fk_cars_brands foreign key (brand_id) references brands(brand_id)
;