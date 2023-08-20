#include<stdio.h>
void main()
{
	int a;
	printf("Enter no =");
	scanf("%d",&a);
	if(a>60)
    {
		printf("%d is Old",a);
	}
	else
	{
		printf("%d is Adult",a);
	}
}
