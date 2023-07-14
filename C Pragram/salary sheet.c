#include<stdio.h>
void main()
{
	float basic,hra,da,total_salary;
	printf("Enter Basic =");
	scanf("%f",&basic);
	hra=basic*0.35f;
	da=basic*0.45f;
	total_salary=basic+hra+da;
	printf("HRA =%f\n",hra);
	printf("DA =%f\n",da);
	printf("Total_Salary = %f",total_salary);
}
