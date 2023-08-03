//write a program to multiplication of 2 matrices
#include<stdio.h>
void main()
{
	int row,col;
	int arr1[2][2];
	int arr2[2][2];
	int arr3[2][2];
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
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		arr3[row][col]=arr1[row][col]*arr2[row][col];
		}
	}
	printf("Multiplication of table\n");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("%d\t",arr3[row][col]);
		}
		printf("\n");
	}
}
//Algorithum
//1) start
//2) declare arr1[2][2], arr2[2][2],arr3[2][2] row, col,
//3) accept first matrices and then second matrices
//4)if row=0;row<2;row++
//5) col=0;col<2;col++
//6)arr3=[row][col]=arr1[row][col]*arr2[col][row]
//7) then print multiplication of matrics
//8) stop
