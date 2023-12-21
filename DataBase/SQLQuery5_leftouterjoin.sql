create table student2(id int identity primary key,
ad_no varchar(20),fname varchar (20),lname varchar(20),
city varchar (20))
insert into student2 values (1001,'pooja','zilpe','nagpur'),
(1002,'kareena','dhapodkar','nagpur'),
(1003,'chandrima','kumbhalkar','nagpur'),
(1004,'akash','kale','nagpur'),
(1005,'ayushree','shende','nagpur');
select * from student2

create table fees(ad_no int,course varchar(20), amount int)
insert into fees values (1001,'java',65000),
(1004,'java',65000),
(1002,'java',65000);
select * from fees

select student2.ad_no,student2.fname,student2.lname,student2.city,fees.course,fees.amount
from student2
left outer join fees 
on student2.ad_no=fees.ad_no;
