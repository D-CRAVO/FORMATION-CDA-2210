use db302_employees;

select * from employees;

-- 1
select 
	emp_lastname
	,emp_firstname
	,emp_salary
	,emp_hiredate
from employees
order by emp_hiredate asc

-- 2
select 
	emp_lastname
	,emp_salary
	,emp_hiredate
	,emp_manager_id
from employees
order by 
	emp_manager_id asc
	,emp_lastname asc

-- 3
select 
	employees.emp_lastname
	,employees.emp_firstname
	,employees.emp_salary
	,employees.emp_hiredate
	,employees.emp_manager_id
	,e1.emp_lastname as manager_lastname
	,e1.emp_firstname as manager_firstname
from employees
left join employees as e1 on e1.emp_id = employees.emp_manager_id
order by manager_lastname asc
	,emp_hiredate asc

-- 4
select
	emp_lastname
	,emp_firstname
from employees
where emp_manager_id is null

-- 5
select 
	e1.emp_firstname as manager_firstname
	,e1.emp_lastname as manager_lastname
	,count(employees.emp_id) as number_employees
from employees
inner join employees as e1 on  e1.emp_id = employees.emp_manager_id
group by e1.emp_firstname, e1.emp_lastname
order by number_employees asc

select 
	count(*)
from employees
where emp_manager_id = 5

select 
	e1.emp_firstname as manager_firstname
	,e1.emp_lastname as manager_lastname
	,count(employees.emp_id) as number_employees
	,(
		select 
			count(*)
		from employees as e2
		where e2.emp_manager_id = e1.emp_manager_id
	)
from employees
inner join employees as e1 on  e1.emp_id = employees.emp_manager_id
group by 
	e1.emp_firstname 
	,e1.emp_lastname
	,e1.emp_manager_id
order by number_employees asc

select 
	count(*)
from employees
where emp_manager_id = 5

-- 6
select 
	e1.emp_lastname
	--,employees.emp_salary
	,avg(employees.emp_salary) as average_salary
from employees
inner join employees as e1 on e1.emp_id = employees.emp_manager_id
group by e1.emp_lastname
order by average_salary desc

-- 7

select 
	count(emp_id) as nb_employees
	,sum(emp_salary) as sum_salary
	,avg(emp_salary) as average_salary
from employees
where emp_manager_id is not null

select 
	employees.emp_lastname
	,employees.emp_firstname
	,employees.emp_salary
	,employees.emp_hiredate
from employees
where employees.emp_manager_id is null

select 
	employees.emp_lastname
	,employees.emp_firstname
	,employees.emp_salary
	,employees.emp_hiredate
	,count(e1.emp_id) as nb_employees
	,sum(e1.emp_salary) as sum_salary
	,avg(e1.emp_salary) as average_salary
from employees
inner join employees as e1 on e1.emp_manager_id is not null
where employees.emp_manager_id is null
group by
	employees.emp_lastname
	,employees.emp_firstname
	,employees.emp_salary
	,employees.emp_hiredate

select * from employees
