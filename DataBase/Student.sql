create table Student(RollNo int,First_Name varchar(20),Last_Name varchar(20),state varchar(20))
insert into Student values(1,'Pooja','Zilpe','Maharashtra')
insert into Student values(2,'Chandrima','Ghosh','Kolkata')
insert into Student values(3,'Akash','Gautam','Mp')
insert into Student values(4,'Pooja','Zilpe','Maharashtra')
select * from Student
select *from Student where First_Name='Pooja' and Last_Name='Zilpe'
select * from Student where state='Kolkata'
select * from Student where state='Maharashtra' order by First_Name



