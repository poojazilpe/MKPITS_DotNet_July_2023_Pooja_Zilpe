//write a program to read n no of values in an integer array and display in reverse order
#include<stdio.h>
void main()
{
	int i, n, num[100];
	printf("Enter n value =");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{ 
		printf("Enter no :");
		scanf("%d",&num[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("Reverse No :%d\n",num[i]);
	}
}

//Algorithum
//1) start
//2) declare variable i, n, num[100]
//3) accept size of array
//4) accept no
//4) if i=n-1,i>=0,i-- then
//6) print reverse no.
//7) stop
