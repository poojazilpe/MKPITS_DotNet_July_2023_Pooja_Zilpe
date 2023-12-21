select * from student1
select s.ad_no,s.fname,s.lname,s.city,f.course,f.amount
from student1 s
cross join fee f;