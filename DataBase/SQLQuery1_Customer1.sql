create table Customer1(CustId int,CustName varchar(20),CustAddress varchar(50))
insert into Customer1 values(1,'Pooja','ram Nagar,Nagpur')
insert into Customer1 values(2,'Kareena','shiv Nagar,Nagpur')
insert into Customer1 values(3,'Chandrima','shankar Nagar,Nagpur')
insert into Customer1 values(4,'Ayushi','Omkar Nagar,Nagpur')
insert into Customer1 values(5,'Ayushree','manish Nagar,Nagpur')
insert into Customer1 values(6,'Lucky','shivaji Nagar,Nagpur')
insert into Customer1 values(7,'Sarang','Sambhaji Nagar,Nagpur')
insert into Customer1 values(8,'Ashwin','Ram Nagar,Nagpur')
insert into Customer1 values(9,'Akash','Chandan Nagar,Nagpur')
insert into Customer1 values(10,'Mayuri','Shankar Nagar,Nagpur')
select *from Customer1
select * from customer1 order by CustName
select * from customer1 order by CustName desc
select * from customer1 where CustName='pooja'
select * from customer1 where Custid=1
select * from customer1 where Custid>1
select * from customer1 where Custid>1 and Custid<66

