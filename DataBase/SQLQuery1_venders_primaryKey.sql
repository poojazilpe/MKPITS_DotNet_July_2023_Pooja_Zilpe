create table vender_groups(groupid int identity primary key,group_name varchar(20) not null)

create table venders1(venderid int identity , vender_name varchar(20) ,
groupid int )
select * from vender_groups
insert into venders1(venderid,vender_name) values('pooja',1)
select * from venders1
drop table venders1