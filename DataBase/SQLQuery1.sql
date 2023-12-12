create table sample(id int)
create table student(RollNo int,Name varchar(20))
insert into student values (1,'Pooja')
select * from student
insert into student values(2,'Chandrima')
select * from student
insert into student values (3,'Kareena')
select*from student

create table Product(ProductId int,ProductName varchar(20),Price int,Quantity int)
insert into Product values(1,'Laptop',50000,2)
insert into Product values(2,'Mouse',120,3)
insert into Product values(3,'Keyboard',250,2)
select * from Product

create table Customer(CustId int primary key,CustName varchar(20))
insert into Customer values(1,'Pooja')
insert into Customer values(2,'Chandu')
insert into Customer values(3,'Kareena')
select * from Customer