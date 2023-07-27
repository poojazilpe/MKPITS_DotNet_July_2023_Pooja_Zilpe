#include<stdio.h>
void main()
{
	int row, col;
	for (row=1; row<=5; row++)
	{
		for(col=1; col<=row; col++)
		{
			printf("*\t");
		}
		printf("\n");
	}
}

//Algorithum
//1) start
//2) declare row, col
//3) row=1, row<=5, row++
//4) col=1, col<=row, col++
//5) print star
//6) stop

