create table vender_groups1(groupid int identity primary key,group_name varchar(20) not null)

create table venders1(venderid int identity primary key,vender_name varchar(20),groupid int ,
constraint fk foreign key(groupid) references vender_groups1 (groupid))
insert into vender_groups1 values('pooja')
insert into venders1 values('Sonu',1)
insert into venders1 values('Monu',1)
insert into vender_groups1 values('pooja')
insert into vender_groups1 values('Minu')
insert into venders1 values('Mona',2)
select * from vender_groups1
select*from venders1