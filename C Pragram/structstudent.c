#include<stdio.h>
#include<string.h>
struct student 
{
	int rollno;
	char name[20];
};
void main()
{
	struct student stud[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter Roll no and Name :");
		scanf("%d%s",&stud[counter].rollno,stud[counter].name);
	}
	printf("\n Student Details :");
	for(counter=0;counter<5;counter++)
	{
		printf("\nRoll No =%d\t",stud[counter].rollno);
		printf("Name =%s",stud[counter].name);
	}
}
//Algorithum
//1) start
//2) define structure student
//3) declare name, roll no
//4) go to main function
//4) create an array of structure student stud with size 5, counter
//5) loop from counter=0 to counter<11
//6) accept name and roll no
//7) in loop if  then 
//8) print name and roll no
//9) stop
