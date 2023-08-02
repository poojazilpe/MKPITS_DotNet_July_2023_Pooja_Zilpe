#include<stdio.h>
void main()
{
	int i,arr[5],max,min;
	printf("Enter no : ");
	for(i=0;i<5;i++)
	{
		scanf("%d",&arr[i]);
	}
	max=arr[0];
	for(i=0;i<5;i++)
	{
		if(arr[i]>max)
		{
			max=arr[i];
		}
	}
	min=arr[0];
	for(i=0;i<5;i++)
	{
		if(arr[i]<min)
		{
			min=arr[i];
		}
	}
	printf("Maximum value :%d\n",max);
	printf("Minimum value :%d\n",min);	
}

//Algorithum
//1) start
//2) declare variable i,arr[5], max, min
//3) accept no
//4) max=arr[0]
//5) if i=0,i<5,i++ then 
//6) arr[i]>max then max=arr[i]
//7) min=arr[0]
//8) if i=0,i<5,i++ then 
//9) arr[i]<min then min=arr[i]
//10) print maximum value and minumum value
//11) stop
