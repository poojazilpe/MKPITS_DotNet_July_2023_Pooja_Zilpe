#include<stdio.h>
int main()
{
	int age;
	printf("Enter age : ");
	scanf("%d",&age);
	if (age<=12 && age>=0 )
	{
		printf("Child");
	}
	else if (age>=13 && age<=19)
	{
		printf("Teenager");
	}
	else if (age>=20 && age<=59)
	{
		printf("Adult");	
	}
	else
	{
		printf("Senior Citizen");
	}

	return 0;
	
	
	
}
//that takes the age of a person as input & determine if they are child. 
// adult, Teenager or senior citizen 
