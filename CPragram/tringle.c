#include<stdio.h>
int main()
{
	int a,b,c;
	printf("Enter 3 side of triangle : ");
	scanf("%d%d%d",&a,&b,&c);
	if (a + b > c && b + c > a && a + c > b)
	{
		printf("vadid");
	}
	else
	{
		printf("not valid");
	}

	return 0;
}
//3 side of triangle as input and determines whether the triangle is valid or not. 
// a triangle is valid if the sum of any 2 side is grater than 3rd side 
