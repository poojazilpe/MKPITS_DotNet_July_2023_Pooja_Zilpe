#include<stdio.h>
int area()
{
	int side;
	printf("Enter side =");
	scanf("%d",&side);
	int result=side*side;
	return result;
}
void main()
{
	int result;
	result=area();
	printf("Area of Square = %d",result);
}
