create table orders (orderid int , custid int, orderdate date,
productname varchar(20),qty int)
insert into orders values(1,1,'2022-2-2','mouse',5)
insert into orders values(1,1,'2022-2-2','keyboard',5)
insert into orders values(2,2,'2022-2-2','desktop',5)
insert into orders values(2,2,'2022-2-2','ram',5)
insert into orders values(3,3,'2022-2-2','laptop',5)
insert into orders values(4,3,'2022-1-2','mouse',5)
insert into orders values(5,4,'2022-2-2','mouse',5)
insert into orders values(6,4,'2022-2-2','ram',5)
insert into orders values(7,5,'2022-2-2','desktop',5)
insert into orders values(7,5,'2022-2-2','ram',5)
select * from orders

create table customers(custid int identity (1,1) primary key,
fname varchar(20) not null,
lname varchar(20) not null,
phone varchar(20),
email varchar (20) not null,
street varchar (50),
city varchar(20),
state varchar (20),
pcode varchar (20))

insert into customers values ('ayushi','tale','70208956','aa@gmail.com',
'chandan nagar','nagpur','mah','441110')
insert into customers values ('priya','tale','70276956','pi@gmail.com',
'vaishali nagar','nagpur','mah','441110')
insert into customers values ('pooja','zilpe','70278956','pui@gmail.com',
'vaishali nagar','bhopal','mah','441110')
select * from customers


select custid from customers where city='nagpur'


select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customers where city='nagpur')

select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customers where city='bhopal')



select orderid,custid,orderdate,productname,qty 
from orders
where custid in 
(select custid from customers where city='bhopal')
order by orderdate desc
