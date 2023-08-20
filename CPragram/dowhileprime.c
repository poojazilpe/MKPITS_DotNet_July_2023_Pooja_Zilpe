#include<stdio.h>
void main()
{
	int counter=2;
	int num;
	int rem=0;
	printf("Enter No : ");
	scanf("%d",&num);
	do
	{
		rem=num%counter;
		if(rem==0)
		{
			printf("It is not prime no");
			break;
		}
		counter=counter+1;
	}
	while (counter<num);
	if(num==counter)
	{
		printf("It is prime no");
	}
	
}

//Algorithum
//1) start
//2) declare num, counter=2, rem=0
//3) accept num
//4) rem=num%counter
//5) if rem=0 then print not prime no
//7) counter=counter+1
//8) counter<num
//print it is prime no
//7) stop

