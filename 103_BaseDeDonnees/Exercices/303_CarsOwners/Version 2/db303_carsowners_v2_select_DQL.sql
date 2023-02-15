use db303_carsowners_v2

-- 1
select 
	car_name
	,registration
from cars
	inner join registrations on cars.car_id = registrations.car_id
order by registration asc
;

-- 2
select
	brand_name
	,car_name
	,registration
	,owner_lastname
	,owner_firstname
from brands
	inner join cars on cars.brand_id = brands.brand_id
	inner join registrations on registrations.car_id = cars.car_id
	inner join owners on owners.owner_id = registrations.car_owner_id
order by
	brand_name asc
	,owner_lastname asc
;

-- 3
select
	brand_name
	,count(distinct owner_id)
from brands
	inner join cars on brands.brand_id = cars.brand_id
	inner join registrations on registrations.car_id = cars.car_id
	inner join owners on owners.owner_id = registrations.car_owner_id
group by brand_name
;

-- 5
select
	owner_firstname
from owners
where owner_firstname like 'A%'
;

-- 6
select
	owner_lastname
	,owner_firstname
from owners
where len (owner_firstname) > 5
;

-- 6 Sélectionner les noms et prénoms des propriétaires possédant plus d’une voiture avec le nombre de voitures possédées 
-- par propriétaire. Trier la liste par nombre de voitures possédées. Les propriétaires possédant le plus de voitures
-- apparaissent en 1er
--.
select
	owner_lastname
	,owner_firstname
	,count(car_id) as nb_cars
from owners
	inner join registrations on registrations.car_owner_id = owners.owner_id
group by 
	owner_lastname
	,owner_firstname
having count(car_id) > 1
order by nb_cars desc
;

-- 7 Sélectionner les noms et prénoms des propriétaires possédant plus d’une voiture de même marque. Pour chaque marque 
-- de voiture trouvée, afficher le nom de la marque et le nombre de voiture possédées pour cette marque

select 
	owner_lastname
	,owner_firstname
	,brand_name
	,count(


select * from registrations;