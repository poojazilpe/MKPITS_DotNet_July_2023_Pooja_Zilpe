#include<stdio.h>
void main()
{
	int num;
	int counter=1;
	int result=0;
	printf("Enter no :");
	scanf("%d",&num);
	do
	{
		result=num*counter;
		counter=counter+1;	
		printf("%d\n",result);
	}
	while(counter<=10);
	
}

//Algorithum
//1) start
//2) declare num, counter=1, result=0
//3) accept num
//4) result=num*counter
//5) counter=counter=1
//print result
//6) when counter<=10
//7) stop

