/*write a program toread information of student name roll no birthday, addmission date 
clculate age of student at the time of admission
*/
#include<stdio.h>
#include<string.h>
struct student
{
	int rollno;
	char name[20];
	struct date
	{
		int date;
		int month;
		int year;
	} 
	birthdate, addate;
};
void main()
{
	struct student stud[3];
	int counter, r;
	for(counter=0;counter<3;counter++)
	{
		printf("Enter Rollno., Name :");
		scanf("%d%s",&stud[counter].rollno,&stud[counter].name);
		printf("Enter Birthday : ");
		scanf("%d-%d-%d",&stud[counter].birthdate.date,&stud[counter].birthdate.month,&stud[counter].birthdate.year);
		printf("Admission date : ");
		scanf("%d-%d-%d",&stud[counter].addate.date,&stud[counter].addate.month,&stud[counter].addate.year);
	}
	for(counter=0;counter<3;counter++)
	{
		r=stud[counter].addate.year-stud[counter].birthdate.year;
		printf("\nAge of student at the time of ddmission : ");
		printf("\t%d years",r);
	}
}
