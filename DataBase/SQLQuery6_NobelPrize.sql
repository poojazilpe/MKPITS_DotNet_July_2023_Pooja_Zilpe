create table NobelPrize(YEAR int ,SUBJECT varchar(20), WINNER varchar(20), COUNTRY varchar(20),
CATEGORY varchar(20))
insert into NobelPrize values(1970,' Physics', 'Hannes Alfven', 'Sweden', 'Scientist')
insert into NobelPrize values(1970,' Physics', 'Louis Neel',' France',' Scientist')
insert into NobelPrize values(1972, 'Chemistry', 'Luis Federico', 'Leloir France',' Scientist')
insert into NobelPrize values(1970, 'Physiology', 'Ulf von Euler', 'Sweden',' Scientist')
insert into NobelPrize values(1970,' Physics', 'Hannes Alfven', 'Sweden', 'Scientist')
select*from NobelPrize
select YEAR, SUBJECT, WINNER FROM NobelPrize where YEAR=1970
select WINNER from NobelPrize where SUBJECT='Physics' and YEAR=1970
insert into NobelPrize values(1970, 'Physiology', 'Ulf von Euler', 'Sweden',' Scientist')
insert into NobelPrize values(1970,' Physics', 'Hannes Alfven', 'Sweden', 'Scientist')
select WINNER from NobelPrize where SUBJECT='Physics'or YEAR=1970

select YEAR, SUBJECT, WINNER,  COUNTRY from NobelPrize where YEAR between 1965 and 1975 and SUBJECT='chemistry'
select YEAR, SUBJECT, WINNER,  COUNTRY from NobelPrize where YEAR>1972
select YEAR, SUBJECT, WINNER,  COUNTRY from NobelPrize where YEAR>1970
select YEAR, SUBJECT, WINNER,  COUNTRY from NobelPrize where WINNER='Hannes Alfven'