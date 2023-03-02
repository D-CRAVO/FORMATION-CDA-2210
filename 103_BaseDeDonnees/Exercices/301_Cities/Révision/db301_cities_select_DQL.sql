use db301_cities_revision;

select * from countries;
select * from cities;

-- 5
select
	ci.city_id as 'City Id'
	,ci.city_name as 'City Name'
	,co.country_code as 'Country Code'
	,co.country_name as 'Country Name'
	,count(ci2.country_code) as 'Number of cities'
from cities as ci
	inner join countries as co on co.country_code = ci.country_code
	inner join cities as ci2 on ci2.country_code = co.country_code
group by
	ci.city_id
	,ci.city_name
	,co.country_code
	,co.country_name

-- 4
-- Sélectionner le code ISO et le nom de tous les pays avec le nombre de villes par pays. Les pays avec le moins de villes 
-- apparaissent en 1er.select 	countries.country_code	,country_name	,count(city_id)from countries	inner join cities on cities.country_code = countries.country_codegroup by	countries.country_code	,country_name