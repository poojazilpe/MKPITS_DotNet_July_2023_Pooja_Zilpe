#include<stdio.h>
void addition(int n1, int n2)
{
	int result=n1+n2;
	printf("Addition of 2 nos = %d",result);
}

void main()
{

int num1,num2;
printf("Enter 2 nos =");
scanf("%d%d", &num1,&num2);
addition(num1,num2);
printf("\nbye");
}

//Algorithum
//1) start
//2) define the function Addition
//3) declare int n1,n2
//4) result=n1=n2 then print result
//5) end the function
//6) accept 2 no
//6) call the addition function
//7) stop

