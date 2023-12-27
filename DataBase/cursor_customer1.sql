select * from customer1

declare 
@cust_Id int,
@cust_name varchar(max);

declare cursorp1 cursor
for select
CustId,CustName
from customer1
where CustId>3;

open cursorp1

fetch next from cursorp1 into
@cust_Id,
@cust_name;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @cust_name + CAST(@cust_Id AS varchar);
        FETCH NEXT FROM cursorp1 INTO 
            @cust_Id, 
            @cust_name;
    END;


	close cursorp1;
	deallocate cursorp1;
