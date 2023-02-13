use db303_carsowners;

-- 1
select
	car_name
	,car_registration
from cars
order by car_registration
;

-- 2
select
	owner_lastname
	,owner_firstname
	,brand_name
	,car_registration
	,car_name
from owners
	inner join cars on cars.car_owner_id = owners.owner_id
	inner join brands on brands.brand_id = cars.brand_id
order by
	brand_name asc
	,owner_lastname asc
;

-- 3
select
	brand_name
	,count(cars.brand_id)
from brands
	inner join cars on brands.brand_id = cars.brand_id
group by
	brand_name
;

-- 4
select 
	brand_name
	,count(distinct cars.car_owner_id)
from brands
	inner join cars on cars.brand_id = brands.brand_id
group by 
	brand_name
;

-- 5
select 
	owner_firstname
from owners
where owner_firstname like 'A%'
;

-- 6
select
	owner_firstname
	,owner_lastname
from owners
where len(owner_firstname) > 5
;

-- 7
select
	owner_lastname
	,owner_firstname
	,count(cars.car_id) as 'nb_cars'
from owners	
	inner join cars on cars.car_owner_id = owners.owner_id
group by 
	owner_lastname
	,owner_firstname
order by nb_cars desc
;

-- 8
select
	owner_lastname
	,owner_firstname
	,brand_name
	,count(cars.brand_id) as 'nb_cars'
from owners
	inner join cars on cars.car_owner_id = owners.owner_id
	inner join brands on brands.brand_id = cars.brand_id
group by
	owner_lastname
	,owner_firstname
	,brand_name
having count(cars.brand_id) > 1
;
