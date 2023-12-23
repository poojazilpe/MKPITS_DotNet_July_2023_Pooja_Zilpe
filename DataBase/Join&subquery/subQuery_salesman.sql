select * from Salesman

create table Orders(Id int,Purc_amt float,OrderDate date,CustomerId int,SalesmanId int)
insert into Orders values (70001, 150.5, '2012-10-05', 3005, 5002)
insert into Orders values (70002, 140.5, '2012-10-04', 3006, 5003)
insert into Orders values (70003, 120.5, '2012-11-05', 3007, 5004)
insert into Orders values (70004, 150.5, '2012-12-05', 3008, 5005)
insert into Orders values (70005, 140.5, '2012-11-07', 3009, 5001)
select * from Orders

select * from orders
where salesmanId in (select salesmanId from Salesman where SalesmanName = 'Pooja')