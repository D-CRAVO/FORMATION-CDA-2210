select * from countries;
select * from cities;

select 
	city_id
	,city_name
from cities
order by city_name asc
;

select
	city_name
	,country_code
from cities
order by
	country_code asc
	,city_name desc
;

select
	countries.country_code
	,country_name
	,count (city_name) as 'nb_cities'
from countries
inner join cities on cities.country_code = countries.country_code
group by countries.country_code, country_name
order by nb_cities asc
;

select
	cities.city_name
	,countries.country_code
	,countries.country_name
	,count (C2.country_code) as nb_cities
from countries
inner join cities on cities.country_code = countries.country_code
inner join cities as C2 on C2.country_code = cities.country_code
group by cities.city_name, countries.country_code, countries.country_name, cities.country_code
order by nb_cities desc
;

