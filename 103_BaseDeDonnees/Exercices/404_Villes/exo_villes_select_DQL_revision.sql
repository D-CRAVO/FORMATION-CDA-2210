-- 1
-- Obtenir la liste des 10 villes les plus peuplées en 2012

select top 10
	ville_nom
	,sum(ville_population_2012) as Population_2012
from villes_france_free
group by
	ville_nom
order by
	Population_2012 desc

-- 2
-- Obtenir la liste des 50 villes ayant la plus faible superficie
select top 50
	ville_nom
	,sum(ville_surface) as Surface
from villes_france_free
group by 
	ville_nom
order by
	Surface asc

-- 3
-- Obtenir la liste des départements d’outres-mer, c’est-à-dire ceux dont le numéro de département commencent par “97”
	
select
	departement_nom
from departement
where departement_code like '97%'

-- 4 
-- Obtenir le nom des 10 villes les plus peuplées en 2012, ainsi que le nom du département associé

select 
	ville_nom
	,departement_nom
	,sum(ville_population_2012) as Population_2012
from villes_france_free as vi
	inner join departement as de on de.departement_code = vi.ville_departement
group by
	ville_nom
	,departement_nom
order by
	Population_2012 desc

-- 5
-- Obtenir la liste du nom de chaque département, associé à son code et du nombre de commune au sein de ces 
-- département, en triant afin d’obtenir en priorité les départements qui possèdent le plus de communes

select
	departement_nom
	,departement_code
	,count(ville_nom) as nb_villes
from departement as de
	inner join villes_france_free as vi on vi.ville_departement = de.departement_code
group by
	departement_nom
	,departement_code
order by 
	nb_villes desc

-- 6
-- Obtenir la liste des 10 plus grands départements, en termes de superficie

select top 10
	departement_nom
	,sum(ville_surface) as Surface
from departement as de
	inner join villes_france_free as vi on vi.ville_departement = de.departement_code
group by
	departement_nom
order by
	Surface desc

-- 7
-- Compter le nombre de villes dont le nom commence par “Saint”

