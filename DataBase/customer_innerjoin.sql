create table customer(id int ,name varchar(20),phone bigint)
insert into customer  values (1,'pooja',702045),
(2,'kareena',703045),
(3,'chandima',802045),
(4,'akash',756045),
(5,'swapnil',708945);
select * from customer

create table orders(ordid int,orddate date,id int,pname varchar
(20),qty int,rate int)
insert into orders values (11,'2023-10-25',2,'pen',5,10),
(12,'2023-09-15',5,'powder',2,10),
(12,'2023-10-10',3,'pencil',3,20);
select * from orders

select c.id,c.name,c.phone,o.ordid,o.orddate,o.pname,o.qty,o.rate
from customer c
inner join orders o
on c.id=o.id;