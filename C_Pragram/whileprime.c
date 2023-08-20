#include<stdio.h>
void main()
{
	int counter=2;
	int rem=0;
	int num;
	printf("Enter No =");
	scanf("%d",&num);
	while (counter<num)
	{
		rem=num%counter;
		if(rem==0)
		{
			printf("Not a prime no");
			break;
		}
		counter=counter+1;
		}
		if(num==counter)
		{
			printf("It is prime no");
		}
}


//Algorithum
//1) start
//2) declare num, counter=2, rem=0
//3) accept num
//4) if counter<num then
//5) rem=num%counter
//6) if rem=0 then print not prime no
//7) counter=counter+1qaw
//print result
//7) stop

