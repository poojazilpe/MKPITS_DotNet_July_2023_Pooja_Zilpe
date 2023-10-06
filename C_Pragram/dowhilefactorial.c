#include<stdio.h>
void main()
{
	int num,i;
	int fact=1;
	printf("Enter No :");
	scanf("%d",&num);
	for(i=1;i<num;i++)
	{
		fact=fact*i;
		num=num-1;
	
	}
	
	printf("Factorial = %d",fact,num);
	
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
