
#include<stdio.h>
void main()
{
	int row, col;
	for(row=1; row<=5; row++)
	{
		for(col=1; col<=row; col++)
		{
			printf("*\t");
		}
		printf("\n");
    }	
	for (row=5; row>=1; row--)
	{
		for (col=1; col<=row; col++)
		{
			printf("*\t");
			
		}
		printf("\n");
	}
}
