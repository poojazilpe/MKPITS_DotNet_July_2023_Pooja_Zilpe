create table TableCourseRegDetail(CourseRegId int primary key identity,CategoryId int, FullName varchar(1500),
GenderId int)


create table TableRegAdddress(RegAddressId int primary key identity, CourseRegId int foreign key(CourseRegId)
references TableCourseRegDetail(CourseRegId), NationId int foreign key(NationId) 
references TableNation1 (NationId), StateId int foreign key(StateId) references TableState(StateId),
CityId int foreign key(CityId) references TableCity(CityId))

create table TableFeeDetail(FeeID int primary key identity,CourseRegId int foreign key (CourseRegId)
references TableCourseRegDetail(CourseRegId),TotalAmount decimal,MinPer decimal,PaidAmount decimal,
BalAmount decimal,PaidDate datetime)
drop table TableFeeDetail

select * from TableNation1
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAdddress
select * from TableFeeDetail