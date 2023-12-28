create table teacher(tech_id int,tech_name varchar(20),stateid int primary key)

insert into teacher values(1,'pooja',11)
insert into teacher values(2,'kareena',13)
insert into teacher values(3,'chandrima',12)

select * from teacher

create table state(stateid int constraint fk foreign key(stateid) references teacher (stateid),
statename varchar(20),countid int)

insert into state values (11,'mah',101)
insert into state values (12,'mp',101)

select * from teacher
select* from state

select t.tech_id, t.tech_name,t.stateid, s.statename, s.countid from teacher t inner join
state s 
on t.stateid=s.stateid;
