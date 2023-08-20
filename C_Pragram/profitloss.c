#include<stdio.h>
void main()
{
	int s,c,profit,loss;
	printf("Enter selling price=");
	scanf("%d",&s);
	printf("Enter cost price=");
	scanf("%d",&c);
	profit=s-c;
	loss=c-s;
	if(s>c)
	{
		printf("Profit =%d",profit);
	}
	else
	{
		printf("Loss=%d",loss);
	}
	}
