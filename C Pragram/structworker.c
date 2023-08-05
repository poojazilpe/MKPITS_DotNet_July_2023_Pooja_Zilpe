#include<stdio.h>
#include<string.h>
struct worker
{
	char name[20];
	int wage, workday, total;
};
void main()
{
	struct worker work[2];
	int counter;
	for (counter=0;counter<2;counter++)
	{
		printf("Enter Name, Wage, Working days :");
		scanf("%s%d%d",&work[counter].name,&work[counter].wage,&work[counter].workday);
	}
	for(counter=0;counter<2;counter++)
	{
		work[counter].total=work[counter].wage*work[counter].workday;
	}
	printf("\nWorker details :");
	for(counter=0;counter<2;counter++)
	{
		printf("\nTotal Payment = %d",work[counter].total);
	}
}
//Algorithum
//1) start
//2) define structure worker
//3) declare name,wage, workday, total
//4) go to main function
//4) create an array of structure worker work with size 2, counter
//5) loop from counter=0 to counter<2
//6) accept name and run
//7) in loop if total=wage* workday then 
//8) print total payment
//9) stop
