create table mstudent(id int identity primary key,
ad_no varchar(20),fname varchar (20),lname varchar(20),
city varchar (20))
insert into mstudent values (1001,'pooja','zilpe','nagpur'),
(1002,'kareena','dhapodkar','nagpur'),
(1003,'chandrima','kumbhalkar','chandrapur'),
(1004,'akash','kale','bhandara'),
(1005,'ayushree','shende','bhandara');
select * from mstudent

select s1.ad_no,s2.fname,s1.lname,s2.city
from mstudent s1,mstudent s2
     where s1.id <> s2.id 
     and s1.city=s2.city
     order by s2.city
