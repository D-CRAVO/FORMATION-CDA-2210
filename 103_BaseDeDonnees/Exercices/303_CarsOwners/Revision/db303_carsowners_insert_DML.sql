insert into brands
	(brand_name)
values
('AMC')			-- 1
,('Audi')		-- 2
,('Chevrolet')	-- 3
,('Peugeot')	-- 4
,('Toyota')		-- 5
;

insert into owners
	(owner_lastname, owner_firstname)
values
('Petit', 'Annie')
,('Marsfall', 'Bénédicte')
,('Doe', 'John')
,('Bouchra', 'Amine')
,('Jones', 'Steeven')
;

insert into cars
	(car_id, car_name, brand_id)
values
(12, 'Chevelle Concours', 3)
,(16,'A6 Break', 2)
,(21,'Corolla', 5)
,(19,'Monte Carlo', 3)
,(27,'504', 4)
,(30,'Q8', 2)
,(28,'100 LS', 2)
,(23,'Hornet', 1)
,(26,'3008', 4)
;

insert into registrations
	(car_id, registration, owner_id)
values
(12, 'AA-123-AA', 1)
,(16, 'BB-274-BB', 5)
,(21, 'CA-789-BA', 2)
,(19, 'CC-546-FV', 4)
,(27, 'CG-274-ZG', 4)
,(30, 'ER-355-GX', 3)
,(28, 'FV-313-FT', 5)
,(23, 'DE-228-KS', 5)
,(26, 'CF-614-PM', 5)
;