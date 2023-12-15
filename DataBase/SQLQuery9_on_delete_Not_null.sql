create table vendor_groups(groupid int primary key,groupname varchar(20))
create table vendor(vendorid int, vendorname varchar(20),groupid int,
constraint fk1 foreign key (groupid) references vendor_groups(groupid) on delete set null)

insert into vendor_groups values(6,'pooja')
insert into vendor values (11,'panthela',6)
select*from vendor_groups
select*from vendor

delete from vendor_groups where groupid=6