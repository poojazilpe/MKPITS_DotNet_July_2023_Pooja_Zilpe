select * from Employee
create table grade(GRADE_LEVEL varchar(20),  LOWEST_SAL int, HIGHEST_SAL int)
insert into grade values ('A',10000,20000)
insert into grade values ('B',20000,30000)
insert into grade values ('C',30000,49999)
insert into grade values ('D',40000,59999)
insert into grade values ('E',50000,69999)
insert into grade values ('F',60000,79999)
select * from grade

SELECT E.fname, E.lname, E.salary, J.GRADE_LEVEL
 FROM 
 Employee E 
  inner JOIN grade J
     ON E.salary BETWEEN J.LOWEST_SAL AND J.HIGHEST_SAL;
