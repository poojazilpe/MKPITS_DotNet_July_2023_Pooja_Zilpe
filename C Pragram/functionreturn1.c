#include<stdio.h>
int addition()
{
	int n1,n2;
	printf("Enter 2 no =");
	scanf("%d%d",&n1,&n2);
	int result=n1+n2;
	return result;
}
void main()
{
	char ch='y';
	while(ch=='y')
	{
		int result;
		result=addition();
		printf("Result = %d\n",result);
		printf("Do you want to continue, press y :");
		fflush(stdin);
		scanf("%c",&ch);
	}
}
