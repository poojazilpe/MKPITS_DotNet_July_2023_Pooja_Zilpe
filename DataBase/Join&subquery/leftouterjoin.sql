select * from Employee
select * from department

select e.fname, e.lname, d.dep_id, d.dep_name
from Employee e
left outer join department d
on e.dep_id=d.dep_id;