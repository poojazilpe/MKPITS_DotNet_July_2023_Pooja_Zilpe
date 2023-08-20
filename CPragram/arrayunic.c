// write a program to print all unique element in an array
#include<stdio.h>
void main()
{
	int i, j, arr[5], cnt=0;
	for(i=0;i<5;i++)
	{
		printf("Enter no :");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{	cnt=0;
		for(j=0;j<5;j++)
		{
			if(i!=j)
			{
			if(arr[i]==arr[j])
				{
				cnt++;
				break;
				}
			}
		}
		if(cnt==0)
		{
			printf("Unique = %d\n",arr[i]);
		}
	}
	
}

//Algorithum
//1) start
//2) declare variable i,j, arr[5], cnt
//3) accept no
//4) if i=0,i<5,i++ then cnt=0 
//5) if j=0,j<5,j++ if i!=j then
//6) arr[i]=arr[j] then cnt++
//7) if cnt==0
//6) print unique
//7) stop

