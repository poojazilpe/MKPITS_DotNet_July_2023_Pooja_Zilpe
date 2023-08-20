//write a compare 2 string using pointer
#include<stdio.h>
void main()
{
	char name1[20];
	char name2[20];
	char *ptr1, *ptr2;
	printf("Enter first name :");
	gets(name1);
	printf("Enter second name :");
	gets(name2);
	ptr1=name1;
	ptr2=name2;
	while(*ptr1 != '\0' || *ptr2 != '\0')
	{
		if(*ptr1 == *ptr2)
		{
			printf("String are equal");
			break;
		}
	else
	{
		printf("String are not equal");	
		break;	
	}
}
}

//Algorithum
//1) start
//2) declare name1, name2, pot1, opt2
//3) accept name
//4) ptr1=name1 and ptr2=name2
//5) if ptr1 != null or ptr2 != null then
//6) if ptr1=ptr2 then print string are equal break
//7) else string are not equal break
//8) stop
