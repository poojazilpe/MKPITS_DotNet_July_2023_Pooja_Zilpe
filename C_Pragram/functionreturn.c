#include<stdio.h>
int addition(int num1, int num2)
{
	int result=num1+num2;
	return result;
}
void main()
{
	char ch='y';
	while(ch=='y')
	{
	int num1,num2,result;
	printf("Enter 2 no =");
	scanf("%d%d",&num1,&num2);
	result=addition(num1,num2);
	printf("result=%d\n",result);
	printf("Do you want to continue, press y :");
	fflush(stdin);
	scanf("%c",&ch);
}
}
