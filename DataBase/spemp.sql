create table getempcount(empname varchar(50))
insert into getempcount values('Pooja'),('Sonu'),('Monu')
create procedure pro
as 
begin
select * from getempcount
end
exec pro

select count(empname) as 'total Employee' from getempcount