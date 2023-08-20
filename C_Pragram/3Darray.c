//  accept value from the user and store in an 3D array
#include<stdio.h>
void main()
{
	int row,col;
	int arr[3][3];
	printf("Enter no :");
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("%d\t" ,arr[row][col]);
		}
		printf("\n");
	}
}
// Algorithum
// 1) start
// 2) declare variable row,col,arr[3][3]
// 3) accept no.
// 3) if row=0;row<3;row++;
// 4) for col=0;col<3;col++ then 
// 5) print row column
// 6) stop
