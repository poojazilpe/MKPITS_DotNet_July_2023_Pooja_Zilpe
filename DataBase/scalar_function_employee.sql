select * from Employee1

create function funEmp1(
@emp_name varchar(50),
@occup varchar(20)
)
returns varchar(100)

as 
begin return(select @emp_name+''+@occup+'')
end;

select dbo.funEmp1 (empName,occupation,whr) as 'Details' 
from Employee1;