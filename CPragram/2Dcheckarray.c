//Write program to check weather 2 matrices are equal or not.
#include<stdio.h>
void main()
{
	int row,col,i;
	int arr1[2][2];
	int arr2[2][2];
	printf("Enter first matrices :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		scanf("%d",&arr1[row][col]);
		}
	}
	printf("Enter second matrices :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		scanf("%d",&arr2[row][col]);
		}
	}
	i=1;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			if(arr1[row][col]!=arr2[row][col])
			i=0;
			break;
		}
	}
	if(i==1)
	{
		printf("equal");
	}
	else
	{
		printf("not equal");
	}
}

//Algorithum
//1) start
//2) declare arr1[2][2], arr2[2][2],row, col,i
//3) accept first matrices and then second matrices
//4)if row=0;row<2;row++
//5) col=0;col<2;col++
//6)arr1[row][col]!=arr2[col][row]
//7) i=0 and break
//8) if i==1 then print equal else not equal
//9) stop
