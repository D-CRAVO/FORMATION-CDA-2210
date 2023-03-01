--1 
-- S�lectionner le nom et le num�ro d�immatriculation de toutes les voitures tri�es par immatriculation (ordre croissant).

select 
	car_name
	,registration
from registrations as re
	inner join cars as ca on re.car_id = ca.car_id
order by registration asc

-- 2
-- S�lectionner toutes les informations de toutes les voitures, incluant le nom de la marque ainsi que le nom et pr�nom du 
-- propri�taire. Trier la liste par nom de marque (ordre croissant) puis par nom de propri�taire (ordre croissant).

select 
	brand_name
	,car_name
	,registration
	,owner_lastname
	,owner_firstname
from brands
	inner join cars on brands.brand_id = cars.brand_id
	inner join registrations on registrations.car_id = cars.car_id
	inner join owners on owners.owner_id = registrations.owner_id
order by
	brand_name asc
	,owner_lastname asc

-- 3 
-- S�lectionner le nom de toutes les marques incluant le nombre de voitures de chaque marque.

select 
	brand_name
	,count(cars.brand_id) nb_cars
from brands
	inner join cars on cars.brand_id = brands.brand_id
group by
	brand_name

-- 4 
-- S�lectionner le nom de toutes les marques incluant le nombre de propri�taires de chaque marque.
select 
	brand_name
	,count(distinct owners.owner_id) as nb_owners
from owners
	inner join registrations on registrations.owner_id = owners.owner_id
	inner join cars on cars.car_id = registrations.car_id
	inner join brands on brands.brand_id = cars.brand_id
group by 
	brand_name

-- 5
-- S�lectionner les pr�noms des propri�taires dont le pr�nom commence par la lettre A.
		
select 
	owner_firstname
from owners
where owner_firstname like 'A%'

-- 6
-- S�lectionner le noms et pr�nom des propri�taires dont le pr�nom contient plus de 5 lettres.

select 
	owner_lastname
	,owner_firstname
from owners
where len(owner_firstname) > 5

-- 7 
-- S�lectionner les noms et pr�noms des propri�taires poss�dant plus d�une voiture avec le nombre de voitures poss�d�es 
-- par propri�taire. Trier la liste par nombre de voitures poss�d�es. Les propri�taires poss�dant le plus de voitures
-- apparaissent en 1er.

select 
	owner_lastname
	,owner_firstname
	,count(registrations.car_id) as nb_cars
from owners
	inner join registrations on registrations.owner_id = owners.owner_id
group by
	owner_lastname
	,owner_firstname
order by
	nb_cars desc

-- 8
-- S�lectionner les noms et pr�noms des propri�taires poss�dant plus d�une voiture de m�me marque. Pour chaque marque 
-- de voiture trouv�e, afficher le nom de la marque et le nombre de voiture poss�d�es pour cette marque.

select 
	owner_lastname
	,owner_firstname
	,brand_name
	,count(cars.car_id) as nb_cars
from owners
	inner join registrations on registrations.owner_id = owners.owner_id
	inner join cars on cars.car_id = registrations.car_id
	inner join brands on brands.brand_id = cars.brand_id
group by
	owner_lastname
	,owner_firstname
	,brand_name
having count(cars.car_id) > 1