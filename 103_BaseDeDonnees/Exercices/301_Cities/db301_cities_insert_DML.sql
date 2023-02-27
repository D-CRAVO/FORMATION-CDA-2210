use db301_cities;

delete from cities;
dbcc checkident ('cities', reseed, 0);

delete from countries;

insert into countries
(country_code, country_name)
values
('FR', 'France')
,('US', 'United States')
,('RU', 'Russian Federation')
;

insert into cities
(city_name, country_code)
values
('Paris', 'FR')
,('Lyon', 'FR')
,('Toulouse', 'FR')
,('Marseille', 'FR')
,('Mulhouse', 'FR')
,('Boston', 'US')
,('Los Angeles', 'US')
,('Washinghton', 'US')
,('New York', 'US')
,('Moscou', 'RU')
,('Saint-Petersbourg', 'RU')
;