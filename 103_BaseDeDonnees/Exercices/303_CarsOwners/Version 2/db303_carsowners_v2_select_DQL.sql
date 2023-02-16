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

-- 7 S�lectionner les noms et pr�noms des propri�taires poss�dant plus d�une voiture avec le nombre de voitures poss�d�es 
-- par propri�taire. Trier la liste par nombre de voitures poss�d�es. Les propri�taires poss�dant le plus de voitures
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

-- 8 S�lectionner les noms et pr�noms des propri�taires poss�dant plus d�une voiture de m�me marque. Pour chaque marque 
-- de voiture trouv�e, afficher le nom de la marque et le nombre de voiture poss�d�es pour cette marque

select 
	owner_lastname
	,owner_firstname
	--,cars.brand_id
	--,brand_name
	,count(cars.brand_id) as nb_cars
from owners
	inner join registrations on owners.owner_id = registrations.car_owner_id
	inner join cars on registrations.car_id = cars.car_id
	inner join brands on cars.brand_id = brands.brand_id
group by
	owner_lastname
	,owner_firstname
	,cars.brand_id
	--,brand_name
having count(cars.brand_id) > 1

select * from registrations;

SELECT owners.owner_firstname, owners.owner_lastname, COUNT(B.brand_id) AS nbVehicules
FROM owners
INNER JOIN cars_owners AS CO ON CO.car_owner_id = owners.owner_id
INNER JOIN cars AS C ON C.car_id = CO.car_id
INNER JOIN brands AS B ON B.brand_id = C.brand_id
GROUP BY owners.owner_firstname, owners.owner_lastname
HAVING COUNT(CO.car_owner_id) > 1
ORDER BY nbVehicules DESC;