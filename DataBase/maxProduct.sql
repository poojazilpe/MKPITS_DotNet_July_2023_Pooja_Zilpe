select * from Product

select ProductName, Price,Quantity
from product where Price=(
select max(price) as "Minimum Quantitiy" 
from Product);

select * from product

   SELECT Productname, MIN(price) AS "Minimum price"   
    FROM Product 
    GROUP BY Productname  
    HAVING MIN(price)>300;  

	SELECT ProductName, Quantity, Price  
    FROM Product  
    WHERE Quantity = (  
    SELECT MAX(Quantity) AS "Maximum Quantity"   
    FROM Product);   

