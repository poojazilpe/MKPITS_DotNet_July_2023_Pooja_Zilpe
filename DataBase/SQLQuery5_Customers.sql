create table Customers(customer_id int,  cust_name varchar(20), city varchar(20) ,grade int, salesman_id int)
insert into Customers values (3002,' Nick Rimando','New York',100, 5001)
insert into Customers values (3007,' Brad Davis ',' New York' ,200 , 5001)
insert into Customers values (3002,' Nick Rimando','New York',100, 5001)
insert into Customers values (3003,'  Rimando','Paris',100, 5002)
insert into Customers values (3007,' Brad Davis ',' New York' ,200 , 5001)
insert into Customers values (3002,' Nick Rimando','New York',100, 5001)
select * from Customers
select customer_id, cust_name, city, grade, salesman_id from Customers where grade=200