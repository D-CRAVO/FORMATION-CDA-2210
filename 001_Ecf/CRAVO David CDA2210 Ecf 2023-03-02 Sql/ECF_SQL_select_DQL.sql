--1

select
	product_id
	,product_name
	,product_value
from products
order by product_value asc
;

-- 2

select 
	product_id
	,product_name
	,product_value
from products
where product_name like '%X'
;

-- 3

select
	line_id
	,line_label
	,product_id
from production_lines
where line_label like '%PR%'
;

-- 4

select 
	product_name
	,product_value
	,line_label
from products
	inner join production_lines on products.product_id = production_lines.product_id
;

-- 5

select
	product_name
	,product_value
	,line_label
	,forge_quantity
from products as pr
	inner join production_lines as pl on pr.product_id = pl.product_id
	inner join production_done as pd on pl.line_id = pd.line_id
where forge_quantity > 20
;

-- 6

select
	pl.line_id
	,line_label
	,pl.product_id
	,sum(forge_quantity) as Quantity
from production_lines as pl
	left join production_done as pd on pl.line_id = pd.line_id
group by
	pl.line_id
	,line_label
	,pl.product_id
;

-- 7

select
	pl.line_id
	,line_label
	,pl.product_id
	,sum(forge_quantity) as Quantity
from production_lines as pl
	left join production_done as pd on pl.line_id = pd.line_id
group by
	pl.line_id
	,line_label
	,pl.product_id
having sum(forge_quantity) > 1
;

-- à noter qu'un inner join aurait rendu le même résultat :
	
select
	pl.line_id
	,line_label
	,pl.product_id
	,sum(forge_quantity) as Quantity
from production_lines as pl
	inner join production_done as pd on pl.line_id = pd.line_id
group by
	pl.line_id
	,line_label
	,pl.product_id
;

-- 8

/*
select
	sum(forge_quantity * product_value) as PRODS_TOTAL_VALUE
from products as pr
	inner join production_done as pd on pr.product_id = pd.product_id
;

select top 1
	product_name
	,sum(forge_quantity * product_value) as Total_value
from products as pr
	inner join production_done as pd on pr.product_id = pd.product_id
group by product_name
order by Total_value desc
;

select top 1
	product_name as MOST_PROFITABLE_ITEM
	,sum(forge_quantity * product_value) as TOTAL_PRODUCT_VALUE
	,(select sum(forge_quantity * product_value) 
		from products as pr
			inner join production_done as pd on pr.product_id = pd.product_id) as PRODS_TOTAL_VALUE
from products as pr
	inner join production_done as pd on pr.product_id = pd.product_id
group by product_name
order by TOTAL_PRODUCT_VALUE desc
;
*/

select top 1
	(select sum(forge_quantity * product_value) 
		from products as pr
			inner join production_done as pd on pr.product_id = pd.product_id) as PRODS_TOTAL_VALUE
	,product_name as MOST_PROFITABLE_ITEM
from products as pr
	inner join production_done as pd on pr.product_id = pd.product_id
group by product_name
order by sum(forge_quantity * product_value) desc
;