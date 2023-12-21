create table student1(id int identity primary key,
ad_no varchar(20),fname varchar (20),lname varchar(20),
city varchar (20))
insert into student1 values (1001,'pooja','zilpe','nagpur'),
(1002,'kareena','dhapodkar','nagpur'),
(1003,'chandrima','kumbhalkar','nagpur'),
(1004,'akash','kale','nagpur'),
(1005,'ayushree','shende','nagpur');
select * from student1

create table fee(ad_no int,course varchar(20), amount int)
insert into fee values (1001,'java',65000),
(1004,'java',65000),
(1002,'java',65000);
select * from fee

select student1.ad_no,student1.fname,student1.lname,student1.city,fee.course,fee.amount
from student1
inner join fee 
on student1.ad_no=fee.ad_no;
