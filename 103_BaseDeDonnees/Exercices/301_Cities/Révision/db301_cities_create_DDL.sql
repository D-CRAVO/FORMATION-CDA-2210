use db301_cities_revision;

drop table if exists cities;
drop table if exists countries;

create table countries
(
	country_code char(2) unique not null
	,country_name varchar(100) not null
	,primary key(country_code)
);

create table cities
(
	city_id int identity(1,1)
	,city_name varchar(100) not null
	,country_code char(2)
	,primary key (city_id)
);

alter table cities
	add constraint fk_cities_countries foreign key (country_code) references countries(country_code)
;