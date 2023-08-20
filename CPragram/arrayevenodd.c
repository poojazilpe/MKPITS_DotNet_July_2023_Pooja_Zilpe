#include<stdio.h>
void main()
{
	int i, arr[5];
	for(i=0;i<5;i++)
	{
		printf("Enter no :");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		if(arr[i]%2==0)
		{
			printf("No is even : %d\n",arr[i]);
		}
		else 
		{
			printf("No is odd  : %d\n",arr[i]);
		}
	}
	
}

//Algorithum
//1) start
//2) declare variable i, arr[5]
//3) accept no
//4) if i=0,i<5,i++ then 
//5) if arr[i]%2==0
//6) then print no is even
//7) no is odd
//8) stop
