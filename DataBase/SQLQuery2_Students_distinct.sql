create table Students (RollNo int,Name varchar(20),Course varchar(20),City varchar(20))
insert into Students values(1,'Pooja','Dotnet','Nagpur')
insert into Students values(2,'Akash','Dotnet','Amravati')
insert into Students values(3,'Chandrima','Java','Bhandara')
insert into Students values(4,'Kareena','Java','Ramtek')
insert into Students values(5,'Pooja','Dotnet','Nagpur')
insert into Students values(6,'Akash','Dotnet','Amravati')
insert into Students values(7,'Chandrima','Java','Bhandara')
select * from Students

select distinct Name from Students
select distinct Course from Students