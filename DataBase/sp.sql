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

create proc pro1 
as begin
select * from products
end;
exec pro1

create proc pro2
as begin select * from products
where myear=2022
end
exec pro2

alter proc pro2
as
begin
select pname,price from products
order by price
end;

exec pro2

alter proc pro2
	as
	begin 
	insert into products values('sport1',1,1,'2023',1200)
	select * from products
	end;