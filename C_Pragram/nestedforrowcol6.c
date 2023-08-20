#include<stdio.h>
void main()
{
	int row, col;
	for (row=3; row>=1; row--)
	{
		for (col=1; col<=row; col++)
		{
			printf("%d\t",col);
			
		}
		printf("\n");
	}
}

//Algorithum
//1) start
//2) declare row, col
//3) row=3, row>=1, row--
//4) col=1, col<=row, col++
//5) print column
//6) stop

