
#include<stdio.h>
void main()
{
	int cnt=0;
	char name[10];
	char *ptr;
	printf("Enter name :");
	gets(name);
	ptr=name;
	while(*ptr != '\0')
	{
		if(*ptr=='a' ||*ptr=='e' ||*ptr=='i' ||*ptr=='o' ||*ptr=='u')
		{
			cnt=cnt+1;
		}
		ptr++;
	}
	printf("No of vowels in a sting = %d",cnt);
}
//Algorithum
//1) start
//2) declare name, ptr, cnt
//3) accept name
//4) ptr=name
//5) if ptr1 != null
//6) if(ptr=='a or ptr=='e' or ptr=='i' or ptr==o, ptr=='u'
//7) cnt=cnt+1
//8) ptr++
//9) print no of vowels in name
