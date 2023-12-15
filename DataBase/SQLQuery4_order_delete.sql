create table orders(orderid int primary key, orddate date,custid int)
create table orderdetails(orderid int,productname varchar(20), quantity int,
constraint fk foreign key (orderid) references orders(orderid))
insert into orders values(1,'2022-12-15',123)
insert into orders values(2,'2022-12-15',156)
insert into orders values(3,'2022-11-15',178)
insert into orderdetails values(1,'tv',2)
insert into orderdetails values(1,'fridge',3)
insert into orderdetails values(2,'cupboard',1)
insert into orderdetails values(2,'pen',10)
insert into orderdetails values(2,'laptop',1)
select * from orders
select* from orderdetails

delete from orderdetails where orderid=1
delete from orders where orderid=1