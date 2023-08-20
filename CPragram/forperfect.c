// write a program to check wheather the given no is perfect or not

#include<stdio.h>
void main()
{
	int num,i;
	int sum=0;
	printf("Enter no :");
	scanf("%d",&num);
	printf("Excluding of %d are :\n",num);
	for (i=1;i<num;i++)
	{
		if(num%i==0)
		{
			printf("%d\n",i);
			sum=sum+i;
		}
	}
	printf("\n sum = %d",sum);
	if(num==sum)
	{
		printf("\n %d is a perfect no",num);
	}
	else
	{		
		printf("\n %d is not a perfect no",num);		
	}	
	
}

//Algorithum
//1) start
//2) declare num, sum=0, i
//3) accept no
//4) if i=1, i<num, i++ then
//5) if num%i==0 then print divisor no
//6) if sum=sum+i then print sum
//7) if num=sum then print perfect no otherwise not
