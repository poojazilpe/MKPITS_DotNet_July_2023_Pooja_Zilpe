//Write a program to find length of string using pointer
#include<stdio.h>
void main()
{
	int cnt=0;
	char name[20];
	char *ptr;
	printf("Enter name : ");
	gets(name);
	ptr=name;
	while(*ptr != '\0')
	{
		cnt=cnt+1;
		ptr++;
	}
	
	printf("No of letter in a string =%d",cnt);
}
//Algorithum
//1) start
//2) declare cnt, name, ptr
//3) accept name
//4) ptr=name
//5) if ptr != null then
//6) cnt=cnt+1;
//7) ptr++
//8) print total no of letter
//9) stop
