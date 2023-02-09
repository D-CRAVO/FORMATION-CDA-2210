drop table if exists employees;

create table employees
(
	emp_id int identity(1,1)
	,emp_lastname varchar(50) not null
	,emp_firstname varchar(50) not null
	,emp_salary int not null check (emp_salary>0)
	,emp_hiredate date not null
	,emp_manager_id int
	,primary key (emp_id)
);

alter table employees
	add constraint fk_emp_manager_id foreign key (emp_manager_id) references employees(emp_id)
;