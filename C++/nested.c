#include<stdio.h>
void main()
{
	int row, col,j,spc;
	spc=row+3-1;
	for(row=1;row<3;row++)
	{
		for(j=1;j>=row;j--)
		{
			printf(" ");
		}
		for(col=1;col<row;col++)
		{
			printf("* ");
		}
		spc--;
	printf("\n");
	}
}
