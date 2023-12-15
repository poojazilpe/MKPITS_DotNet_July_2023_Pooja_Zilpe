create table vendor_groups1(groupid int  primary key,group_name varchar(20) not null)
create  table vendors1(groupid int,vendorid int, vendorname varchar(20),
constraint fk foreign key (groupid) references vendor_groups1 (groupid) on delete cascade)
insert into vendor_groups1 values (1,'pen')
insert into vendors1 values (1,12,'pooja')
insert into vendor_groups1 values (2,'pencil')
insert into vendor_groups1 values (3,'laptop')
select * from vendor_groups1
select * from vendors1

delete from vendor_groups1 where groupid=1