#include<stdio.h>
void main()
{
	int num;
	int fact=1;
	printf("Enter No :");
	scanf("%d",&num);
	do
	{
		fact=fact*num;
		num=num-1;
	}
	while(num>0);
	printf("Factorial = %d",fact);
	
}

//Algorithum
//1) start
//2) declare num,fact=1
//3) accept num
//4) fact=fact*num
//5) num=num-1
//6) if while num>0 then
//print factorial
//7) stop
