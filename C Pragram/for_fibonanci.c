//write a program print Fiboncci series 0,1,1,2,3,5,8...

#include<stdio.h>
void main()
{
	int i;
	int num1=0;
	int num2=1;
	int add=num1+num2;
	printf("%d,%d",num1,num2);
	for (i=3;i<=10;i++)
	{
		printf(",%d",add);
	
	num1=num2;
	num2=add;
	add=num1+num2;
}
}

//Algorithum
//1) start
//2) declare i, num1=0, num2=1, add=num1=num2
//3) print num1 and num2
//4) if i=3, i<=10, i++ then print add
//5) num1=num2
//   num2=add
//   add=num1+num2
//6) stop

