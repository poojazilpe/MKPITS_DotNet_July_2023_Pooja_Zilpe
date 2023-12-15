create table vendor_groups1(groupid int primary key,group_name varchar(20) not null)
create  table vendors1(vendorid int, vendorname varchar(20),groupid int
constraint fk foreign key (groupid) 
references vendor_groups1 (groupid) on delete no action)

insert into vendor_groups1 values (5,'gfmhg')
insert into vendors1 values (5,20,'shxhoja')
insert into vendor_groups1 values (33,'hkhql')

select * from vendor_groups1
select * from vendors1
delete from vendor_groups1 where groupid=2
insert into vendors1 values (21,'tv',33)

insert into vendors1 values(1,5,'fridge')