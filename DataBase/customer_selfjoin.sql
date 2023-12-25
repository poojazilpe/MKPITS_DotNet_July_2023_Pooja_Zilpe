create table mcustomer(id int ,name varchar(20),phone bigint,city varchar(20))
insert into mcustomer  values (1,'pooja',702045,'nagpur'),
(2,'kareena',703045,'nagpur'),
(3,'chandima',802045,'amravati'),
(4,'akash',756045,'amravati'),
(5,'swapnil',708945,'bhandara');
select * from mcustomer

select c1.name,c2.phone,c1.id,c2.city
from mcustomer c1, mcustomer c2
where c1.id<>c2.id and c1.city=c2.city
order by c2.city;