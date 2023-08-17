#include<stdio.h>
int main()
{
	int age;
	char name[20];
	char gender;
	printf("Name:\tAge:\tGender(M/F):");
	scanf("%s%d%s",&name,&age,&gender);
	printf("\n");
	if (gender=='m')
	{
	
	   if (age>21)
	    {
		    printf("Eligible To Vote\n");
	    }
	else
		{
			printf("Not Eligible To Vote\n");
		}
	}
	else 
   {
	if (age>18)
	{
		printf("Eligible To Vote\n");
	}
	else
	{
		printf(" Not Eligible To Vote\n");
	}
}
	
	return 0;
}
	

