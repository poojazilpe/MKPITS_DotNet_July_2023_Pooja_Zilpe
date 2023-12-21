select * from student2
select * from fees
select student2.ad_no,student2.fname,student2.lname,student2.city,fees.course,fees.amount
from Student2
full outer join fees
on student2.ad_no=fees.ad_no;