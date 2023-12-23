create table department(dep_id int primary key,dep_name varchar(20), manager_id int,loc_id int)
insert into department values (1,'mechanical',202,1700)
insert into department values (2,'civil',203,1800)
insert into department values (3,'It',204,1100)
insert into department values (4,'cs',205,1200)
insert into department values (5,'Aronotical',206,1300)
insert into department values (6,'mechanical',207,1400)
insert into department values (7,'civil',208,1500)
insert into department values (8,'It',209,1600)
insert into department values (9,'Cs',201,1700)
insert into department values (10,'civil',210,1800)
select * from department

create table Employee(emp_id int primary key,fname varchar(20),lname varchar(20),email varchar(20),
phone bigint,hire_date date,job_id int,salary int,com_pct int,manager_id int,dep_id int)

insert into Employee values(100,'Steven','King','SKING',51545869,'2003-06-17',1,24000,2,202,1) 
insert into Employee values(101,'pooja','Zilpe','Poozi',51895869,'2003-07-12',2,25000,3,203,3) 
insert into Employee values(102,'chandu','ghosh','cghosh',89545869,'2003-05-27',3,21000,4,207,2) 
insert into Employee values(103,'akash','gautam','agautam',51545869,'2003-09-15',4,22000,2,209,5) 
insert into Employee values(104,'mayuri','ingle','maingle',85545869,'2003-04-13',5,29000,3,208,4) 
insert into Employee values(105,'mrunal','kale','mrukale',57895869,'2003-02-11',6,25000,2,201,6) 
select * from Employee

select E.fname , E.lname , 
       E.dep_id , D.dep_name 
        FROM employee E 
         inner join department D 
          ON E.dep_id = D.dep_id;

