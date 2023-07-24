#include<stdio.h>
void main()
{
	int counter=1;
	int sum=0;
	while(counter<=5)
	{
		sum=sum+counter;
		counter=counter+1;
	}
	printf("Sum=%d",sum);
}

//Algorithum
//1) Start
//2) declare counter=1 and sum=0
//3) if counter<=5 then
//4) sum=sum+1
//5) increment counter= counter+1
//6) print sum
//7) stop
