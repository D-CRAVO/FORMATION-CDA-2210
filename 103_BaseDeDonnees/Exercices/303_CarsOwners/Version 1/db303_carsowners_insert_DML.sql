use db303_carsowners;

delete from owners;
dbcc checkident('owners', reseed, 0);

delete from brands;
dbcc checkident('brands', reseed, 0);

delete from cars;

insert into owners
(owner_lastname, owner_firstname)
values
('Petit', 'Annie')
,('Marsfall', 'Bénédicte')
,('Doe', 'John')
,('Bouchra', 'Amine')
,('Jones', 'Steeven')
;

insert into brands
(brand_name)
values
('AMC')			-- 1
,('Audi')		-- 2
,('Chevrolet')	-- 3
,('Peugeot')	-- 4
,('Toyota')		-- 5
;

insert into cars
(car_id, car_registration, car_name, car_owner_id, brand_id)
values
(12, 'AA-123-AA', 'Chevelle Concours', 1, 3)
,(16, 'BB-274-BB', 'A6 Break', 5, 2)
,(21, 'CA-789-BA', 'Corolla', 2, 5)
,(19, 'CC-546-FV', 'Monte Carlo', 4, 3)
,(27, 'CG-274-ZG', '504', 4, 4)
,(30, 'ER-355-GX', 'Q8', 3, 2)
,(28, 'FV-313-FT', '100 LS', 5, 2)
,(23, 'DE-228-KS', 'Hornet', 5, 1)
,(26, 'CF-614-PM', '3008', 5, 4)
;