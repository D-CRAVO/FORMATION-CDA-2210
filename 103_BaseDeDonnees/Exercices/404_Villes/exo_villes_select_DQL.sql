-- 1
-- Obtenir la liste des 10 villes les plus peuplées en 2012

select top 10
	ville_nom
	,ville_population_2012
from villes_france_free
order by ville_population_2012 desc
;

-- 2
-- Obtenir la liste des 50 villes ayant la plus faible superficie

select top 50
	ville_nom
	,ville_surface
from villes_france_free
order by ville_surface asc
;

-- 3
-- Obtenir la liste des départements d’outres-mer, c’est-à-dire ceux dont le numéro de département commencent par “97”

select top 10
	ville_nom
	,ville_code_postal
from villes_france_free
where ville_code_postal like '97%'
;

-- 4
-- Obtenir le nom des 10 villes les plus peuplées en 2012, ainsi que le nom du département associé

select top 10
	ville_nom
	,ville_population_2012
	,departement_nom
from villes_france_free as vi
	inner join departement as de on  vi.ville_departement = de.departement_code
order by ville_population_2012 desc

-- 5
-- Obtenir la liste du nom de chaque département, associé à son code et du nombre de commune au sein de ces 
-- département, en triant afin d’obtenir en priorité les départements qui possèdent le plus de communes

select 
	departement_nom
	,departement_code
	,count(ville_nom)
from departement as de
	inner join villes_france_free as vi on de.departement_code = vi.ville_departement 
group by 
	departement_nom
	,departement_code

-- Contrôle
select 
	count(ville_departement)
from villes_france_free
where ville_departement = '02'


-- 6
-- Obtenir la liste des 10 plus grands départements, en termes de superficie

select top 10
	departement_nom
	,sum(ville_surface) as surface
from departement as de
	inner join villes_france_free as vi on de.departement_code = vi.ville_departement 
group by 
	departement_nom
order by surface desc

-- Contrôle
-- surface de la Guyane 83850km²
-- surface de la Gironde 9975km²

-- 7
-- Compter le nombre de villes dont le nom commence par “Saint”
-- uwu


select
	count(ville_nom)
from villes_france_free
where ville_nom like 'Saint%'
;

-- Contrôle
select
	ville_nom
from villes_france_free
where ville_nom like 'Saint%'
;

-- 8
-- Obtenir la liste des villes qui ont un nom existants plusieurs fois, et trier afin d’obtenir en premier celles dont le nom est 
-- le plus souvent utilisé par plusieurs communes

select 
	ville_nom
	,count(ville_nom) nb_fois
from villes_france_free
group by
	ville_nom
order by
	nb_fois desc
;

-- Contrôle
select 
	ville_nom
from villes_france_free
where ville_nom like 'SAINTE-COLOMBE'
;
select 
	ville_nom
from villes_france_free
where ville_nom like 'SAINT-SAUVEUR'
;

-- 9
-- Obtenir en une seule requête SQL la liste des villes dont la superficie est supérieur à la superficie moyenne

select
	avg(ville_surface)
from villes_france_free

select
	v2.ville_nom
	,v2.ville_surface
	,avg(v1.ville_surface) as surface_moyenne
from villes_france_free as v1
	inner join villes_france_free as v2 on v2.ville_id > 0 -- Demander des explications 
group by
	v2.ville_nom
	,v2.ville_surface
having v2.ville_surface > avg(v1.ville_surface)
order by
	ville_surface asc
;


select
	v2.ville_nom
	,v2.ville_surface
	,avg(v1.ville_surface) as surface_moyenne
from villes_france_free as v1
	inner join villes_france_free as v2 on v2.ville_id = v1.ville_id -- Demander des explications 
group by
	v2.ville_nom
	,v2.ville_surface
having v2.ville_surface > avg(v1.ville_surface)
order by
	v2.ville_surface asc

-- 9
-- Obtenir la liste des départements qui possèdent plus de 2 millions d’habitants

select 
	departement_nom
	,sum(ville_population_2012) as nb_habitants
from villes_france_free as vi
	inner join departement as de on  vi.ville_departement = de.departement_code
group by 
	ville_departement
	,departement_nom
having sum(ville_population_2012) > 2000000
order by nb_habitants desc
;

-- Contrôle
-- 2 145 906 habitants pour Paris en 2020
-- 2 606 200 habitants sur Nord en 2018 (Haut-de-France)

-- 10
-- Remplacez les tirets par un espace vide, pour toutes les villes commençant par “SAINT-” (dans la colonne qui contient 
-- les noms en majuscule)

update villes_france_free
set ville_nom = replace(ville_nom, '-', ' ')
where ville_nom like 'Saint%'
;

select
	ville_nom
from villes_france_free
where ville_nom like 'Saint%'
;


select * from departement;
select top 10 * from villes_france_free;