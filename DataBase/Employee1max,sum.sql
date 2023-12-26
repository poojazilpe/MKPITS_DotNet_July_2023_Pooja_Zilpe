create table Employee1
(id int identity(1,1) primary key,
empName varchar(50) not null,
occupation varchar(50) not null,
wdate date,
whr int not null,
salary int not null);

insert into Employee1 values ('pooja','manager','2023-10-25',8,50000)
insert into Employee1 values ('kareena','HR','2023-09-14',9,40000)
insert into Employee1 values ('chandrima','writer','2023-1-15',8,45000)
insert into Employee1 values ('akash','teacher','2023-10-15',12,30000)
insert into Employee1 values ('ashwin','engineer','2023-08-18',12,35000)
insert into Employee1 values ('sonu','HR','2023-07-20',7,20000)
insert into Employee1 values ('monu','writer','2023-10-27',6,25000)

select * from Employee1



    SELECT AVG(whr) AS "Average Working Hours"   
    FROM Employee1  
    WHERE occupation = 'Writer';   

	
    SELECT SUM(salary) AS "Total Salary" FROM Employee1;  

	
    SELECT SUM( DISTINCT salary) AS "Total Salary"   
    FROM Employee1;  

	
    SELECT SUM(salary) AS "Total Salary"  
    FROM Employee1   
    WHERE whr>9;  


	    SELECT occupation, SUM(salary) AS "Total Salary"  
    FROM Employee1  
    GROUP BY occupation;  
