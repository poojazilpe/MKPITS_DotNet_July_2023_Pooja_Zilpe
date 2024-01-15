select * from Employee1

create procedure proc2 (@maxsal as decimal)
as begin
select * from Employee1
where salary > @maxsal order by salary
end
exec proc2 30000