#include<stdio.h>
void factorial(int num,int fact)
{
	while(num>0)
	{
	
	 fact=fact*num;
     num=num-1;
 	}
printf("Factorial = %d",fact);
}

void main()
{
	    int num,fact=1;
		printf("Enter no =");
		scanf("%d",&num);
		factorial(num,fact);
}

//Algorithum
//1) start
//2) define the function factorial
//3) declare int num fact
//4) while num>0 then fact=fact*num and num=num-1
//5) print factorial
//6) end the function, go to the main functoin
//6) accept num
//7) call the factorial function
//8) stop

