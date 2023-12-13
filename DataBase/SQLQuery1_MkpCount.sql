create table MkpCount(RollNo int,Name varchar(20),Course varchar(20),City varchar(20))
insert into MkpCount values (1,'Pooja','Dotnet','Nagpur')
insert into MkpCount values (2,'Chandrima','Dotnet','Nagpur')
insert into MkpCount values (3,'Akash','Dotnet','Nagpur')
insert into MkpCount values (4,'Kareena','Java','Amravti')
insert into MkpCount values (5,'Sayali','Dotnet','Nagpur')
insert into MkpCount values (6,'Sonu','Java','Amravati')
select * from MKpCount
select Course,count(*) from MkpCount
where city='Nagpur'
group by Course

select City,COUNT(*) from MkpCount
where Course = 'Dotnet'
group by City 


