SELECT * FROM Roles;
SELECT * FROM Personnes;
select * from residents;

select 
	personne_nom
	,personne_prenom
from Personnes
where role_id = 4

select 
	personne_nom
	,personne_prenom
from Personnes
where role_id <> 2

select 
	role_nom
	,count(Personnes.role_id)
from Personnes
inner join Roles on Roles.role_id = Personnes.role_id
group by
	role_nom

select
	Personnes.personne_nom
	,Personnes.personne_prenom
	,role_nom
	,count(P2.role_id)
from Personnes
inner join Roles on Roles.role_id = Personnes.role_id
inner join Personnes as P2 on P2.role_id = Personnes.role_id
group by
	Personnes.personne_nom
	,Personnes.personne_prenom
	,role_nom
order by
	role_nom asc

select 
	Personnes.personne_nom
	,Personnes.personne_prenom
	,Roles.role_nom
	,count(Personnes.role_id)
from Personnes
	inner join Roles on Roles.role_id = Personnes.role_id
	inner join Personnes as P2 on P2.role_id = Roles.role_id
where Personnes.role_id = 1
	--and P2.role_id in (6, 7, 8)
group by
	Personnes.personne_nom
	,Personnes.personne_prenom
	,Roles.role_nom


-- Sélectionner tous les résidents actifs du plus jeune au plus âgé.

select
	personne_nom
	,personne_prenom
	,personne_ddn
	,resident_date_depart
from Personnes
inner join Residents on Residents.personne_id = Personnes.personne_id
where resident_date_depart is not null
order by personne_ddn asc

-- Sélectionner tous les résidents suivis par un médecin avec nom et prénom du médecin attitré.

select
	Personnes.personne_nom
	,Personnes.personne_prenom
	,Residents.medecin_id
	,p2.personne_nom
	,p2.personne_prenom
from Personnes
	inner join Residents on Residents.resident_id = Personnes.personne_id
	inner join Personnes as p2 on p2.personne_id = Residents.medecin_id
where Residents.medecin_id is not null

-- Sélectionner tous les médecins avec le nombre de résidents qu’il suivent.

select 
	p2.personne_nom
	,p2.personne_prenom
	,count(residents.medecin_id) as nb_patients
from personnes
	inner join personnes as p2 on p2.personne_id = personnes.personne_id
	left join residents on residents.medecin_id = personnes.personne_id
where personnes.role_id = 3
group by 
	p2.personne_nom
	,p2.personne_prenom

