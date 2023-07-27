#include<stdio.h>
void main()
{
	int row, col, spc, k;
	spc=row+4-1;
	for(row=1;row<=7;row++)
	{
		for(k=spc;k>=1;k--)
		{
			printf(" ");
		}
		for(col=1;col<=row;col++)
		{
		
		if(row%2!=0)
		{
			printf("* ");
		}
		}
		spc--;
		printf("\n");
	}
}

//Algorithum
//1) start
//2) declare row, col, spc, k
//   space=row+4-1
//3) row=1, row>=7, row++
//4) k=spc, k>=1, k-- then print space 
//5) col=1, col<=row, col++
//6) if row%2!=0 then print star
//7) spc--
//6) stop
