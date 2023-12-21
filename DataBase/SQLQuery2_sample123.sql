create table sample123(id int identity primary key, name varchar
(20))
insert into sample123 values ('mouse')
insert into sample123 values ('keyboard')
insert into sample123 values ('printer')
select* from sample123
delete from sample123

insert into sample123 values ('mouse')
insert into sample123 values ('keyboard')
insert into sample123 values ('printer')
select* from sample123

truncate table sample12

alter table sample123
add price int

sp_rename 'sample123', 'newsample1'
sp_help sample123