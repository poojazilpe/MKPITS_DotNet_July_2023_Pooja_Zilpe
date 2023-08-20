#include<stdio.h>
void main()
{
	int counter=10;
	int sum=0;
	while (counter<=20)
	{
		sum=sum+counter;
		counter=counter+1;
	}
	printf("Sum=%d",sum);
}

//Algorithum
//1) start
//2) declare counter=10 and sum=0
//3)if counter <=20 then
//4) sum=sum+counter
//5) counter=counter+1
// print sum
//6) stop
