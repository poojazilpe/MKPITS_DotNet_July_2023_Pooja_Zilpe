create table order5(ordid int primary key,ordname varchar (20))
create table order_details5(proname varchar(20), custid int, ordid int,
constraint fk5 foreign key (ordid) references order5(ordid) on delete no action)
insert into order5 values(3,'dress')
insert into order_details5 values ('pant',13,3)
insert into order5 values(4,'cupboard')
insert into order_details5 values ('lg1',14,3)
select*from order5
select*from order_details5
delete from order5 where ordid=2