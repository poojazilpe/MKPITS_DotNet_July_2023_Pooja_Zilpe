create table TableNation(NationId int primary key, NationName varchar(500))
insert into TableNation values (1,'India'),(2,'America'),(3,'london'),(4,'Dubai')

create table TableState(StateId int primary key, NationId int constraint fk foreign key(NationId) 
references TableNation(NationId),StateName varchar(500))

insert into TableState values (101,1,'Maharashtra'),
(102,2,'MP'),(103,3,'UP'),(104,4,'Chhatisgadh')

create table TableCity(CityId int primary key,StateID int constraint fk1 foreign key(StateId)
references TableState(StateId), CityName varchar (500))

insert into TableCity values(1001,101,'Nagpur'),(1002,102,'Chindwada'),(1003,103,'Bhandara'),
(1004,104,'Gondiya')

create table TableCourseRegDetail(CourseRegId int primary key,CategoryId int, FullName varchar(1500),
GenderId int)

insert into TableCourseRegDetail values (11,21,'Pooja',31),(12,22,'Kareena',32),
(13,23,'Akash',33),(14,24,'Chandrima',34)


create table TableRegAdddress(RegAddressId int primary key, CourseRegId int foreign key(CourseRegId)
references TableCourseRegDetail(CourseRegId), NationID int foreign key(NationId) 
references TableNation (NationId), StateId int foreign key(StateId) references TableState(StateId),
CityId int foreign key(CityId) references TableCity(CityId))

insert into TableRegAdddress values (50,11,1,101,1001),(51,12,2,102,1002),(53,13,3,103,1003),
(54,14,4,104,1004)

create table TableFeeDetail(FeeID int primary key,CourseRegId int foreign key (CourseRegId)
references TableCourseRegDetail(CourseRegId),TotalAmount decimal,MinPer decimal,PaidAmount decimal,
BalAmount decimal,PaidDate datetime)

insert into TableFeeDetail values (301,11,50000.00,401,10000.00,3000.00,'2023-12-25'),
(302,12,51000.00,402.00,20000.00,2000.00,'2023-11-24'),
(303,13,52000.00,40.00,2500.00,1000.00,'2023-12-20')

select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAdddress
select * from TableFeeDetail