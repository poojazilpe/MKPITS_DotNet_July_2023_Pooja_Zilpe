#include<stdio.h>
void main()
{
	int counter=1;
	int sum=0;
	do
	{
		sum=sum+counter;
		counter=counter+1;
	}
	while(counter<=5);
	printf("Sum=%d",sum);
}

//Algorithum
//1) Start
//2) declare counter=1 and sum=0
//3) sum=sum+1 
//4) increment counter= counter+1
//5) if counter<=5 then
//6) print sum
//7) stop
