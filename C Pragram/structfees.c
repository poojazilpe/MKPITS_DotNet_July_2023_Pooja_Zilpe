//Write a program to accept student name and fees for 5 month calculate amount perday
#include<stdio.h>
#include<string.h>
struct student
{
	char name[20];
	int fees;
};
void main()
{
	struct student stud[5];
	int counter, perday, total_month;
	int month;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter Name and fees :");
		scanf("%s%d",&stud[counter].name,&stud[counter].fees);
	}
	for(counter=0;counter<5;counter++)
	{
		month=20;
		total_month=month*5;
		perday=stud[counter].fees/total_month;
		printf("\nName =%s\t",stud[counter].name);
		printf("Perday =%d ru.\t",perday);
		
	}
	//Algorithum
//1) start
//2) define structure student
//3) declare name, fees 
//4) go to main function
//4) create an array of structure student stud with size 5, declare counter, perday, total month, month
//5) loop from counter=0 to counter<5
//6) accept name and fees
//7) in loop if month=20, total month=month*5, perday=fees/total month
//8) print name and perday fees 
//9) stop
	
	
}
