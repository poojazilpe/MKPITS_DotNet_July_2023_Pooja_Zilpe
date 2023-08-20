//Write a program to copy the element one array into another array.
#include<stdio.h>
void main()
{
	int i, arr1[10], arr2[10];
	for(i=0;i<10;i++)
	{
		printf("Enter no : ");
		scanf("%d",&arr1[i]);
	}
	for(i=0;i<10;i++)
	{
		arr2[i]=arr1[i];
	}
	printf("Element of arr1 :");
	for(i=0;i<10;i++)
	{
		printf("%d",arr1[i]);
	}
	printf("\nElement of arr2 :");
	for(i=0;i<10;i++)
	{
		printf("%d",arr2[i]);
	}
}

//Algorithum
//1) start
//2) declare variable i, arr1[10],arr2[10]
//3) accept no
//4) if i=0,i<10,i++ then 
//5) arr2[i]=arr1[i]
//6) print element of arr1 and arr2
//7) stop
