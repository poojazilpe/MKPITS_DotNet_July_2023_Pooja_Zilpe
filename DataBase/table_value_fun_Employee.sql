select * from Employee1

create function fun_emp()
returns table
as 
return(select * from Employee1);

select * from fun_emp()