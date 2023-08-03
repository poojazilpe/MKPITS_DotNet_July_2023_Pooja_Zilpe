//Write a program addition of 2 matrices
#include<stdio.h>
void main()
{
	int row, col;
	int arr1[2][2]={{1,2},{3,4}};
	int arr2[2][2]={{5,6},{7,8}};
	int arr3[2][2];
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr3[row][col]=arr1[row][col]+arr2[row][col];
		}
	}
	printf("Addition of table :\n");
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
//2) declare arr1[2][2]={{1,2},{3,4}}, arr2[2][2]={{5,6},{7,8}},arr3[2][2] row, col,
//3)if row=0;row<2;row++
//4) col=0;col<2;col++
//5)arr3[row][col]=arr1[row][col]+arr2[col][row]
//6) then print addition of matrics
//7) stop
