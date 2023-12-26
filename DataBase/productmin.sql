select * from product

    SELECT ProductName, Quantity, Price  
    FROM Product  
    WHERE Quantity = (  
    SELECT MIN(Quantity) AS "Minimum Quantity"   
    FROM Product);  
