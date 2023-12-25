select * from customer
select * from orders

select c.id,c.name,c.phone,o.ordid,o.orddate,o.pname,o.qty,o.rate
from customer c
left outer join orders o
on c.id=o.id;
