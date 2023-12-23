select * from Salesman
select * from Orders

select * from orders
where purc_amt>(select AVG(purc_amt) from orders where orderdate ='2012-10-04')