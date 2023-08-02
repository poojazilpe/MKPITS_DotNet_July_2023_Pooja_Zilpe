// Write a program cancatenate 2 string using pointer
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
	while(*ptr1 != '\0')
	{
	ptr1++;
	}
	ptr2=name2;
	while(*ptr2 !='\0')
	{
		*ptr1=*ptr2;
		ptr1++;
		ptr2++;
	}
	*ptr1='\0';
	printf("Concatenated string :%s",name1);
}

//Algorithum
//1) start
//2) declare name1, name2, ptr1, ptr2
//3) accept name
//4) ptr1=name1 and ptr2=name2
//5) if ptr1 != null  then ptr++
//6) if ptr2 != null then ptr1=ptr2 and ptr1++, ptr2++
//7) ptr1=null then print concatenate
//8) stop
