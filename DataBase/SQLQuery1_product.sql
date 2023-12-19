create table Products(Prod_id int identity primary key,
Prod_name varchar(20) not null,
unit_price dec(10,2) check(unit_price>0))

insert into Products values('Mouse',120)
insert into Products values('Keyboard',150)
insert into Products values('Laptop',50000)

select * from Products

create table result(rollno int identity primary key,
stud_name varchar (20) not null,
mark int check(mark>0))

insert into result values('Pooja',99)
insert into result values('Chandu',85)
insert into result values('Kareena',0)
select * from result

create table products1(p_id int identity primary key,
p_name varchar(20) not null,
unit_price1 dec(10,2) constraint c1 check(unit_price1>0))

insert into products1 values('pen',10)
insert into products1 values('soap',10)
insert into products1 values('powder',100)
select * from products1

create table product2(Pid int identity primary key,
pname varchar(20) not null,
unit_p dec(10,2) check (unit_p>0),
discount dec(10,2) check (discount>0),
check (discount<unit_p))

insert into product2 values('pencil',10,2)
insert into product2 values('Washing powder',50,5)
insert into product2 values('spray',100,10)
select * from product2

CREATE TABLE product3(
    product_id INT IDENTITY PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    unit_price DEC(10,2),
    discounted_price DEC(10,2),
    CHECK(unit_price > 0),
    CHECK(discounted_price > 0 AND discounted_price < unit_price))
	insert into product3 values('pencil',10,2)
insert into product3 values('Washing powder',50,5)
insert into product3 values('spray',100,10)
select * from product3

create table product41(pid int identity primary key,
pname varchar(20), price dec(10,2), discount dec(10,2),
check(price>0),
check (discount > 0),
constraint c2 check(discount<price))

insert into product41 values('pest',20,2)
insert into product41 values('Washing powder',50,5)
insert into product41 values('spray',100,101)
select * from product41

alter table product41
add constraint cc2 check(price<discount)

alter table product41
add discount dec(20,2)

sp_help product41



