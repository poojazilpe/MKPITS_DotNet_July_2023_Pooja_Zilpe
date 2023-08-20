#include<stdio.h>
void main() 
{
	char name[10];
int salary,bonus=0;
printf("Enter Name =\n");
scanf("%s",&name);
printf("Enter Salary =\n");
scanf("%d",&salary);
if (salary>=10000)
{
	bonus=5000;
}
else if(salary>=5000 && salary<10000)
{
	bonus=2000;
}
else 
{
    bonus=1000;
}
printf("Emp Name=%s\n",name);
printf("Basic Salary=%d\n",salary);
printf("Bonus = %d",bonus);

}

//Algorithum
//1) start
//2) Accept employee name and salary
//3) if salary is greater than equal to 10,000;
//    3.1 print "Bonus is equal to 5,000;
//4) else if salary is greater than equal to 5,000 and less than 10,000
//    4.1 print "Bonus is equal to 2,000
//5) else print "Bonus is equal to 1,000"
//6) stop
