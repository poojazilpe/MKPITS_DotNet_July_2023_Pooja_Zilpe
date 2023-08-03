//write a program to find sum of rows and column of matrices
#include<stdio.h>
void main()
{
	int row, col;
	int arr[2][2];
	int sr, sc;
	printf("Enter matrices :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		sr=sc=0;
		for(col=0;col<2;col++)
		{
		sr=sr+arr[row][col];
		sc=sc+arr[col][row];
		}
		printf("Sum of row =%d\n",sr);
		printf("Sum of col =%d\n",sc);
	}
	
	
}
//Algorithum
//1) start
//2) declare arr[2][2], row, col,sr,sc
//3) accept first matrices
//4)if row=0;row<2;row++
//5) col=0;col<2;col++
//6)sr=sr+arr[row][col];
//7) sc=sc+arr[col][row]
//8) then print sum of row and sum of col 
//9) stop
