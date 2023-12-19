create table person(pid int identity primary key,
fname varchar(20) not null,
lname varchar (20) not null,
email varchar(20) not null)

insert into person values ('pooja','zilpe','p@gmail.com')
insert into person values ('poo','zilp','p@gmail.com')
select * from person

create table person1(pid int identity primary key,
fname varchar(20) not null,
lname varchar (20) not null,
email varchar(20) not null,
unique (email))

insert into person1 values ('pooja','zilpe','p@gmail.com')
insert into person1 values ('poo','zilp','p@gmail.com')
select * from person

create table person2(pid int identity primary key,
fname varchar(20) not null,
lname varchar (20) not null,
email varchar(20) not null,
 constraint cc1 unique (email))

 insert into person2 values ('pooja','zilpe','p@gmail.com')
insert into person2 values ('poo','zilp','p@gmail.com')
select * from person2

CREATE TABLE person_skills (
    id INT IDENTITY PRIMARY KEY,
    person_id int,
    skill_id int,
    updated_at DATETIME,
    UNIQUE (person_id, skill_id))


insert into person_skills values(111,10,'2021-12-12')
insert into person_skills values(111,10,'2021-12-12')
insert into person_skills values(112,10,'2021-12-12')
insert into person_skills values(111,11,'2021-12-12')
select * from person_skills



