// write a program to print factorial of no using pointer
#include<stdio.h>
void factorial(int num, int *fact)
{
	while(num>0)
	{
	*fact=*fact*num;
	 num=num-1;
    }	
}
void main()
{
	int num,fact=1;
	printf("Enter no =");
	scanf("%d",&num);
	factorial(num,&fact);
	printf("Factorial = %d",fact);
}

//Algorithum
//1) start
//2) define the function factorial
//3) declare num, fact
//4) if num>0 and
//	fact=fact*num
//	num=num-1
//5)end function, go to main function
//6) declare num fact=1
//7) accept no
//8) call the factorial function
//9) print factorial
//10) stop
