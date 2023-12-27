select * from product

declare
@prod_name varchar(max),
@list_price decimal;

declare cursorp cursor
for select
ProductName,Price 
from product;


open cursorp

fetch next from cursorp into
@prod_name,
@list_price;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @prod_name + CAST(@list_price AS varchar);
        FETCH NEXT FROM cursorp INTO 
            @prod_name, 
            @list_price;
    END;


	close cursorp;
	deallocate cursorp;
