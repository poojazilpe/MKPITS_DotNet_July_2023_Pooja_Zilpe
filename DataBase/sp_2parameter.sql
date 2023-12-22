select*from products

create proc prod1 (@min as decimal,@max as decimal,@pn as varchar(20))
as begin select * from products
where price>@min and price<@max and
pname=@pn 
order by pname
end;
exec prod1 @min=50,@max=500,@pn='numberplate'

create proc prod9(@minp as decimal,@maxp as decimal,@pn as varchar(max))
as
begin
select * from products
where price > @minp and price < @maxp
and pname LIKE '%' + @pn + '%'

order by pname
end;

exec prod9 @minp=50,@maxp=500,@pn='plate'


