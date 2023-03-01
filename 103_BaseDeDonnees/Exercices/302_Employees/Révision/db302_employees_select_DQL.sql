-- 1
-- S�lectionner le nom, pr�nom et salaire de tous les employ�s tri�s par date d�embauche de la plus ancienne � la plus 
-- r�cente.

select 
	emp_lastname
	,emp_firstname
	,emp_salary
from employees
order by
	emp_hiredate asc

-- 2
-- S�lectionner le nom, salaire, date d�embauche de tous les employ�s tri�s par identifiant de manager (croissant) puis par 
-- nom (ordre alphab�tique).

select 
	emp_lastname
	,emp_salary
	,emp_hiredate
from employees
order by 
	emp_manager_id asc
	,emp_lastname asc

-- 3
-- S�lectionner le nom, pr�nom, salaire, date d�embauche, nom et pr�nom du manager de tous les employ�s. Trier la liste par 
-- nom de manager (ordre croissant) puis par date d�embauche de la plus r�cente � la plus ancienne.

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
-- S�lectionner les employ�s sans manager.
select 
	emp_lastname
	,emp_firstname
from employees
where emp_manager_id is null

-- 5
-- S�lectionner le pr�nom et nom de tous les managers avec, pour chacun, le nombre de leur subordonn�s. Les managers 
-- avec le moins de subordonn�s apparaissent en 1er.

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
-- S�lectionner le nom de tous les managers avec, pour chacun, la moyenne des salaires de leur subordonn�s. Trier le r�sultat 
-- selon la valeur de la moyenne par ordre d�croissant.

select
	e1.emp_lastname as manager_lastname
	,avg(e2.emp_salary) as salary_average
from employees as e1
	inner join employees as e2 on e2.emp_manager_id = e1.emp_id
group by 
	e1.emp_lastname

-- contr�le

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