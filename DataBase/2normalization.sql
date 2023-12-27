create table teacher_details(techid int primary key, teacher_age int)

insert into teacher_details values (1,25),(2,27),(3,25),(4,28),(5,27);
select * from teacher_details

create table teacher_subject(techid int,subject varchar(20),
constraint t1 foreign key(techid) references teacher_details
(techid))
insert into teacher_subject values(1,'chemistry')
insert into teacher_subject values(3,'math')
insert into teacher_subject values(2,'chemistry')

select * from teacher_details
select * from teacher_subject

