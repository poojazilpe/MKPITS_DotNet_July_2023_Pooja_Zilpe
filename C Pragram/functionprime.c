#include<stdio.h>
void prime(int num,int counter, int rem)
{
	while(counter<num)
	{
		rem=num%counter;
		if(rem==0)
		{
			printf("It is not prime no.");
			break;
		}
		counter++;
	}
	if(num==counter)
	{
		printf("It is prime no.");
	}
}

void main()
{
	int num, counter=2, rem=0;
	printf("Enter no : ");
	scanf("%d",&num);
	prime(num,counter,rem);
}

//Algorithum
//1) start
//2) define the function prime 
//3) declare int num,counter, rem
//4) while counter<0 then rem=num%counter
//5) if rem 0 then print it is not prime no then break and counter increment by 1
//6) if num=counter then print prime no
//7) end the function, goto main function
//8) declare variable
//6) accept 2 no
//6) call the prime function
//7) stop

