
#include<stdio.h>
//#include<string.h>
void main()
{
	char name[10];
	char *ptr;
	printf("Enter name : ");
	gets(name);
	ptr=name;
	while(*ptr != '\0')
	{
		printf("%c",*ptr);
		ptr++;
	}
	
	
}
//Algorithum
//1) start
//2) declare name,ptr
//3) accept name
//4) ptr=name
//5) if ptr1 != null then printf name
//6) ptr++
//8) stop
