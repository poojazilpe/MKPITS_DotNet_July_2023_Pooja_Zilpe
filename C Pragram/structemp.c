#include<stdio.h>
#include<string.h>
struct employee
{
	int empid, salary;
	char empname[20];
	char design[20];
	char dept [20];
};
void main()
{
	struct employee emp[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter Empid, Name, Designation, Department, salary :");
		scanf("%d%s%s%s%d",&emp[counter].empid,emp[counter].empname,emp[counter].design,emp[counter].dept,&emp[counter].salary);
	}
	printf("\nEmployee Datails :");
	for(counter=0;counter<5;counter++)
	{
		printf("\nEmployee Id =%d\t",emp[counter].empid);
		printf("Employee Name=%s\t",emp[counter].empname);
		printf("Designation =%s\t",emp[counter].design);
		printf("Department =%s\t",emp[counter].dept);
		printf("Salary =%d",emp[counter].salary);
		
	}
}
//Algorithum
//1) start
//2) define structure employee
//3) declare emp id, name, designation, department, salary
//4) go to main function
//4) create an array of structure employee emp with size 5, counter
//5) loop from counter=0 to counter<5
//6) accept emp id, name designation, department salary
//7) in loop 
//8) print emp id, name, designation department, salary
//9) stop
