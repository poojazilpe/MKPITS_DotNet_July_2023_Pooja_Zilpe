#include<stdio.h>
void addition()
{
	int n1,n2,result=n1+n2;
	printf("Addition of 2 nos = %d\n",result);
}
void main()
{
	
	char ch='y';
	do
	{
		int num1,num2;
		printf("Enter 2 no =");
		scanf("%d%d",&num1,&num2);
		addition(num1,num2);
		printf("Do you want to continue, press y");
		fflush(stdin);
		scanf("%c",&ch);
		
	}
	while(ch=='y');
}
