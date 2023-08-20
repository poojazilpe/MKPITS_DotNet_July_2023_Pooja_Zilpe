// write a program to count total no of duplicate element in an array
#include<stdio.h>
void main()
{
	int i, j, arr[5], cnt;
	for(i=0;i<5;i++)
	{
		printf("Enter no :");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]==arr[j])
			{
				cnt++;
				break;
			}
		}
	}
	printf(" No of duplicate element : %d",cnt);
}

//Algorithum
//1) start
//2) declare variable i,j, arr[5], cnt
//3) accept no
//4) if i=0,i<15,i++ then 
//5) if j=i+1,j<5,j++
//6) arr[i]=arr[j] then cnt++
//7) print duplicate element
//7) stop
