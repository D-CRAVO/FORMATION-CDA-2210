-- 1
-- Sélectionner le nom, prénom et salaire de tous les employés triés par date d’embauche de la plus ancienne à la plus 
-- récente.

select 
	emp_lastname
	,emp_firstname
	,emp_salary
from employees
order by
	emp_hiredate asc

-- 2
-- Sélectionner le nom, salaire, date d’embauche de tous les employés triés par identifiant de manager (croissant) puis par 
-- nom (ordre alphabétique).

select 
	emp_lastname
	,emp_salary
	,emp_hiredate
from employees
order by 
	emp_manager_id asc
	,emp_lastname asc

-- 3
-- Sélectionner le nom, prénom, salaire, date d’embauche, nom et prénom du manager de tous les employés. Trier la liste par 
-- nom de manager (ordre croissant) puis par date d’embauche de la plus récente à la plus ancienne.

select 
	e1.emp_lastname
	,e1.emp_firstname
	,e1.emp_salary
	,e1.emp_hiredate
	,e2.emp_lastname as manager_lastname
	,e2.emp_firstname as manager_firstname
from employees as e1
	inner join employees as e2 on e2.emp_id = e1.emp_manager_id

-- 4 
-- Sélectionner les employés sans manager.
select 
	emp_lastname
	,emp_firstname
from employees
where emp_manager_id is null

-- 5
-- Sélectionner le prénom et nom de tous les managers avec, pour chacun, le nombre de leur subordonnés. Les managers 
-- avec le moins de subordonnés apparaissent en 1er.

select
	e1.emp_lastname
	,e1.emp_firstname
	,count(e2.emp_id) as nb_subordonnees
from employees as e1
	inner join employees as e2 on e2.emp_manager_id = e1.emp_id
group by 
	e1.emp_lastname
	,e1.emp_firstname
order by
	nb_subordonnees asc

-- 6
-- Sélectionner le nom de tous les managers avec, pour chacun, la moyenne des salaires de leur subordonnés. Trier le résultat 
-- selon la valeur de la moyenne par ordre décroissant.

select
	e1.emp_lastname as manager_lastname
	,avg(e2.emp_salary) as salary_average
from employees as e1
	inner join employees as e2 on e2.emp_manager_id = e1.emp_id
group by 
	e1.emp_lastname

-- contrôle

select
	e1.emp_lastname as manager_lastname
	,e2.emp_lastname
	,e2.emp_salary
from employees as e1
	inner join employees as e2 on e2.emp_manager_id = e1.emp_id
order by
	manager_lastname

-- 7 

select 
	e1.emp_id as 'Employee id'
	,e1.emp_lastname as 'Lastname'
	,e1.emp_firstname as 'Firstname'
	,e1.emp_salary as 'Salary'
	,e1.emp_hiredate as 'Hiredate'
	,count(e2.emp_id) as 'Numbers of Employees'
	,sum(e2.emp_salary) as 'Total Salary'
	,avg(e2.emp_salary) as 'Average Salary'
from employees as e1
	inner join employees as e2 on e2.emp_manager_id is not null
where e1.emp_manager_id is null
group by
	e1.emp_id
	,e1.emp_lastname
	,e1.emp_firstname
	,e1.emp_salary
	,e1.emp_hiredate