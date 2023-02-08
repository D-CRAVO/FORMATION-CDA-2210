drop table if exists cities;
drop table if exists countries;

create table countries
(
	country_code char(2) unique
	,country_name varchar(100)
	,primary key(country_code)
);

create table cities
(
	city_id int identity(1,1)
	,city_name varchar(100)
	,country_code char(2)
	,primary key(city_id)
);

alter table cities
	add foreign key (country_code) references countries(country_code)
;