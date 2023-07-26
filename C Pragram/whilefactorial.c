#include<stdio.h>
void main()
{
	int num;
	int fact=1;
	printf("Enter No=");
	scanf("%d",&num);
	while(num>0)
	{
		fact=fact*num; 
		num=num-1;
	}
	printf("Factorial=%d",fact);
}




//Algorithum
//1) start
//2) declare num,fact=1
//3) accept num
//4) if num>0 then
//5) fact=fact*num
//6) num=num-1
//print factorial
//7) stop
		
		                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
