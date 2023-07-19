#include<stdio.h>
void main()
{
	int salary;
	char name[20],designation;
	printf("Enter Employee Name=");
	scanf("%s",&name);
	fflush(stdin);
	printf("Enter Designation(m.c,p)=");
	scanf("%c",&designation);
	switch (designation)
	{
	  case 'm':
		salary=50000;
		break;
		case 'c':
			salary=20000;
			break;
			case 'p':
		        salary=10000;
			break;
	}
	printf("Employee Name =%s",name);
	printf("\n salary =%d",salary);
			
}
//Algorithum
//1) start
//2) accept name desigmation(m,c,p)
//3) if designation is 'm' then
//3.1) salary=50000
//4) if designation is 'c' then
//4.1) salary=20000
//5) if operator is 'p' then
//5.1) salary=10000
//6) stop


