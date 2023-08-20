//Write a program transpose of even matrices
#include<stdio.h>
void main()
{
	int row, col;
	int arr1[2][2];
	int arr2[2][2];
	printf("Enter matrices :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		scanf("%d",&arr1[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		arr2[row][col]=arr1[col][row];
		}
	}
	printf("Tanspose of matrices\n");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("%d\t",arr2[row][col]);
		}
		printf("\n");
	}
	
}
//Algorithum
//1) start
//2) declare arr1[2][2], arr2[2][2], row col,
//3) accept no
//4)if row=0;row<2;row++
//5) col=0;col<2;col++
//6)arr2[row][col]=arr1[col][row]
//7) then print transpose matrics
//8) stop

