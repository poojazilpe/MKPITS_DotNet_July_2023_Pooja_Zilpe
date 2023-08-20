#include<stdio.h>
void main()
{
int day_no;
printf("enter day_no =");
scanf("%d",&day_no);
switch(day_no)
{
case 1:
 printf("\n Monday");
break;
case 2:
 printf("\n Tuesday");
break;
case 3:
 printf("\n Wednesday");
break;
case 4:
 printf("\n Thursday");
break;
case 5:
 printf("\n Friday");
break;
case 6:
 printf("\n Saturday");
break;
case 7:
 printf("\n Sunday");
break;
default:
 printf("\n Invalid");
break;
}
}

//Algorithum
//1) start
//2) Accept day_no
//3) if day no =1 then 
//3.1 print"Monday"
//4) if day no = 2 then
//4.1 print "tuesday"
//5) if day no =3 then 
//5.1 print"wednesday"
//6) if day no = 4 then
//6.1 print "thursday"
//7) if day no =5 then 
//7.1 print"friday"
//8) if day no =6 then
//8.1 print "saturday"
//9) if day no =7 then 
//9.1 print"sunday"
//10) if day no is not between 1 and 7 then
//10.1 printf "invalid day no"
//11) stop




