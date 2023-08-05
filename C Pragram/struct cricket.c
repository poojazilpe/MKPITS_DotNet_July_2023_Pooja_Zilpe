#include<stdio.h>
#include<string.h>
struct cricket 
{
	char name[20];
	int run;
};
void main()
{
	struct cricket c1[11];
	int counter, sum=0;
	for(counter=0;counter<11;counter++)
	{
		printf("Enter Name and Run :");
		scanf("%s%d",c1[counter].name,&c1[counter].run);
	}
	for(counter=0;counter<11;counter++)
	
		sum=sum+c1[counter].run;
		printf("Total run scored by team = %d",sum);
}
//Algorithum
//1) start
//2) define structure cricket
//3) declare name,run
//4) go to main function
//4) create an array of structure cricket c1 with size 11, counter, sum=0
//5) loop from counter=0 to counter<11
//6) accept name and run
//7) in loop if sum=sum+run then 
//8) print total run scored
//9) stop
