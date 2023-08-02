#include<stdio.h>
void main()
{
	int i,j,arr[5], temp;
	printf("Enter no : ");
	for(i=0;i<5;i++)
	{
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]<=arr[j])
			{
				temp=arr[i];
				arr[i]=arr[j];
				arr[j]=temp;	
			}
		}
	}
	printf("Descending order :");
	for(i=0;i<5;i++)
	{
		printf("%d",arr[i]);
	}
}

//Algorithum
//1) start
//2) declare variable i,j, arr[5], temp
//3) accept no
//4) if i=0,i<15,i++ then 
//5) if j=i+1,j<5,j++
//6) arr[i]<=arr[j]
//7) temp=arr[i], arr[i]=arr[j], arr[j]=temp
//6) print Descending order
//7) stop
