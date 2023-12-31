select * from Product
begin transaction
insert into Product values (7,'headphone',1000,2)
update product set Price= 200 where ProductId=2
commit transaction