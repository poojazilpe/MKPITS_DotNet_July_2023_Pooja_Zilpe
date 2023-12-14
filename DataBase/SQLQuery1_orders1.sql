create table orders1(orderid int ,custname varchar(20),prodname varchar(20),quantity int,orddate date)
insert into orders1 values(1,'amit','mouse',5,'2022-9-7')

insert into orders1 values(2,'amitabh','mouse',3,'2022-2-7')

insert into orders1 values(3,'ami','keyboard',3,'2022-2-7')
select * from orders1
insert into orders1 values(1,'ami','keyboard',3,'2022-5-1')
select * from orders1 where orddate between '2022-5-1' and 
'2022-9-7'
select * from orders1 where orderid in(1,3)
select * from orders1 where orderid not in(1,3)