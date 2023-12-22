select*from products

create proc prod11(@minp as decimal=100,@maxp as decimal=null,@pn as varchar(max))
as
begin
select * from products
where
price >= @minp AND
        (@maxp IS NULL OR price <= @maxp) AND
        pname LIKE '%' + @pn + '%'
end;

exec prod11 50,500,'engine oil'
