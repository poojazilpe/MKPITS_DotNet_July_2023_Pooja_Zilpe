select * from Employee
select * from department

create table location(loc_id int, street_add varchar(20),pcode int,city varchar(20), statep varchar(20),coun_id int)
insert into location values (1100,'chandan nagar',44110,'nagpur','mah',10)
insert into location values (1200,'ravi nagar',44110,'nagpur','mah',20)
insert into location values (1800,'ram nagar',44110,'nagpur','mah',30)
insert into location values (1700,'vaishali nagar',44110,'nagpur','mah',40)
insert into location values (1300,'chandan nagar',44110,'nagpur','mah',50)
select * from location

SELECT E.fname,E.lname, 
   D.dep_name, L.city, L.statep
     FROM employee E 
       inner join department D  
        ON E.dep_id = D.dep_id  
          inner join location L
           ON D.loc_id = L.loc_id;
