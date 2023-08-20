#include<stdio.h>
void addition(int n1, int n2)
{
	int result=n1+n2;
	printf("Addition of 2 nos = %d\n",result);
}
void main()
{
	
	char ch='y';
	while(ch=='y')
	{
		int num1,num2;
		printf("Enter 2 no =");
		scanf("%d%d",&num1,&num2);
		addition(num1,num2);
		printf("Do you want to continue, press y : ");
		fflush(stdin);
		scanf("%c",&ch);
		
	}
	
}

//Algorithum
//1) start
//2) define the function Addition
//3) declare int n1,n2
//4) result=n1=n2 then print result
//5) end the function
//6) declare ch='y'
//7) while ch='y'
//8) accept 2 no
//9) call the addition function
//10) then print for continue press y
//7) stop
