-- use ECF_SQL

drop table if exists production_done;
drop table if exists production_lines;
drop table if exists products;

create table products
(
	product_id int unique not null
	,product_name varchar(128) unique not null
	,product_value int not null
	,primary key(product_id)
);

create table production_lines
(
	line_id char(3) unique not null
	,line_label varchar(50) not null
	,product_id int not null
	,primary key(line_id)
);

create table production_done
(
	forge_id int unique not null
	,forge_date date not null
	,forge_quantity int not null
	,line_id char(3) not null
	,product_id int not null
	,primary key(forge_id)
);

alter table production_done
	add constraint fk_production_done_production_line foreign key (line_id) references production_lines(line_id)
		,constraint fk_production_done_products foreign key (product_id) references products(product_id)
;

alter table production_lines
	add constraint fk_production_lines_products foreign key (product_id) references products(product_id)
;
