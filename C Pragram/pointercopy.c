// write a /program to copy one string to another string
#include<stdio.h>
void main()
{
	char name1[20];
	char name2[20];
	char *ptr1, *ptr2;
	printf("Enter any name :");
	gets(name1);
	ptr1=name1;
	ptr2=name2;
	while(*ptr1 != '\0')
	{
		*ptr2=*ptr1;
		ptr1++;
		ptr2++;
	}
	*ptr2='\0';
	printf("copy name =%s",name2);
}

//Algorithum
//1) start
//2) declare name1, name2, ptr1, ptr2
//3) accept name
//4) ptr1=name1 and ptr2=name2
//5) if ptr1 != null then ptr2=ptr1 and ptr1++, ptr2++
//6) ptr2=null
//7) print copy name
//8) stop
