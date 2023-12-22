create table products(pid int identity (1,1) primary key,
pname varchar(20) not null,
bid int  not null,
cid int not null,
myear int not null,
price dec(10,2) not null)


insert into products values('front wheel',1,1,2022,500)
insert into products values('engine oil',2,2,2023,50)
insert into products values('numberplate',3,3,2023,100)
select * from products 

create proc mprod (@minprice as decimal)
as begin
select * from products
where price>@minprice
order by price
end;
exec mprod 100
exec mprod 50

create proc prod(@proid as int)
as begin 
select * from products
where pid>@proid
order by price end;
exec prod 1

create proc pp2(@pn as varchar(20))
as
begin 
select * from products
where pname=@pn
end

exec pp2 'numberplate'
exec pp2 'battery'
