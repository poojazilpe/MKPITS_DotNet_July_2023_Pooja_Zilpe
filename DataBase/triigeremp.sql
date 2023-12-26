create table employee(empid int primary key,
empname varchar(20) not null)

insert into employee values(13,'shashu')
insert into employee values (14,'sonu')

CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)

select * from employee
select * from EmpLog

create trigger empt
on employee
for insert
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'insert',GETDATE() from inserted; 

create trigger empu
on employee
after update
as
insert into EmpLog(empid,Operation,UpdatedDate)
select empid,'update',GETDATE() from deleted;

update employee set empname='swapnil' where empid=13;
