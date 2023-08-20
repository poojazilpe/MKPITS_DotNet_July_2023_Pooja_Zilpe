#include<stdio.h>
void main()
{
	int row, col, spc, k;
	spc=row+3-1;
	for(row=1;row<=3;row++)
	{
		for(k=spc;k>=1;k--)
		{
			printf(" ");
		}
		for(col=1;col<=row;col++)
		{
			printf("%d ",row);
		}
		spc--;
		printf("\n");
	}
}

//Algorithum
//1) start
//2) declare row, col, spc, k
//   space=row+4-1
//3) row=1, row>=3, row++
//4) k=spc, k>=1, k-- then print space 
//5) col=1, col<=row, col++
//6) then print row
//7) spc--
//6) stop
