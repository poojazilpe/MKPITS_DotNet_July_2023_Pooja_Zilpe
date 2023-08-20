#include<stdio.h>
struct person
{
	char name[20];
	int age;
	char gender;
};
int main()
{
	struct person people[10];
	
	printf("Enter detail for 10 people in the format: Name Age Gender(M/F)\n");
	for (int i = 0; i < 10; i++)
	{
		printf("Person %d:",i+1);
		scanf("%s %d %c", people[i].name, &people[i].age, &people[i].gender);
		
	}
	printf("%s %s %s %s\n", "No", "Name", "Age", "Eligibility");
	printf("--------------------------------\n");
	for (int i = 0; i < 10; i++)
	{
		printf("%d %s %d", i + 1, people[i].name, people[i].age);
		if(people[i].gender == 'M')
		{
		if(people[i].age > 21)
		{
			printf("%s\n", "Eligible");
		}
		else
		{
		printf("%s\n", "Not Eligible");	
		}
		}
		else if(people[i].gender == 'F')
		{
		if(people[i].age > 18)
		{
			printf("%s\n", "Eligible");
		}
		else
		{
		printf("%s\n", "Not Eligible");	
		}
		}
		else
		{
		printf("%s\n","Invalid Gender");	
		}	
	}
		
		return 0;
	}

