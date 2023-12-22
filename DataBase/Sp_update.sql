select * from products
--insert query 
create proc sp_pro(@pname varchar(20),@bid int,@cid int, @myear int,@price int) 
as 
begin
insert into products values(@pname,@bid,@cid,@myear,@price)
end;

exec sp_pro 'monitor',4,4,2023,50000
select * from products




