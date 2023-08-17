#include<stdio.h>
void main()
{
	int row, j, col;
	
	for(row=1;row<=4;row++)
	{
		for(j=4;j>=row;j--)
		{
			printf(" ");
		}
		for(col=1;col<=2*row-1;col++)
		{
	
			printf("*");
		}
		printf("\n");
	}
		
}

