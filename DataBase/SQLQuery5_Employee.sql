create table Employee (EmpId int primary key identity(1,1),EmpName varchar(20))

insert into Employee(EmpName)values('Sandy')
insert into Employee(EmpName)values('Sonu')
insert into Employee(EmpName)values('Swapnil')
insert into Employee(EmpName)values('Sanjay')
delete from Employee where EmpId=1
select*from Employee
