select * from stud1

create function fun5(@m1 int,@m2 int,@m3 int)
  returns decimal
  as
  begin
  return (select (@m1+@m2+@m3)* 0.3 ) 
  end
  
  select dbo.fun5(m1,m2,m3) as 'percentage' from stud1
