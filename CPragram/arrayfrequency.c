//write a program to count the frequency of each element in an array
#include<stdio.h>
void main()
{
	int i, j, arr[5],fre[5],count;
	printf("Enter no :");
	for(i=0;i<5;i++)
	{
		scanf("%d",&arr[i]);
		fre[i]=-1;
	}
	for(i=0;i<5;i++)
	{
		count=1;
		for(j=i+1;j<5;j++)
		{
			if(arr[i]==arr[j])
			{
				count++;
				fre[j]=0;
			}
		}
		if(fre[i]!=0)
		{
			fre[i]=count;
		}
	}
	printf("\n Frequency of element :\n");
	for(i=0;i<5;i++)
	{
		if(fre[i]!=0)
		{
			printf("%d occurs %d time \n",arr[i],fre[i]);
		}
	}
}
