#include<stdio.h>
void main()
{
	float radius,area,coc;
	printf("Enter Radius =",radius);
	scanf("%f",&radius);
	area=3.14f*radius*radius;
	coc=2*3.14f*radius;
	printf("Area =%f\n",area);
	printf("COC = %f",coc);
}
