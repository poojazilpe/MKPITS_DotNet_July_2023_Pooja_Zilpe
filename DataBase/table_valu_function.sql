select * from product
create function func1()
returns table
as
return(select * from product);

select * from func1()