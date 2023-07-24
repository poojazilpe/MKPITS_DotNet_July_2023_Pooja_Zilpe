#include<stdio.h>
void main()
{
	int counter=10;
	int sum=0;
	do
	{
		sum=sum+counter;
		counter=counter+1;
		
	}
	while(counter<=20);
	printf("Sum=%d",sum);
}

//Algorithum
//1) start
//2) declare counter=10 and sum=0
//3) sum=sum+counter
//4) counter=counter+1
//5) check counter<=20
// print sum
//6) stop
