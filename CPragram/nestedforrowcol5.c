#include<stdio.h>
void main()
{
	int row, col, k=1;
	for(row=1; row<=3;row++)
	{
	for(col=1; col<=row; col++)
	{
		printf("%d\t",k++);
		}
		printf("\n");	
	}
}

//Algorithum
//1) start
//2) declare row, col, k=1
//3) row=1, row<=3, row++
//4) col=1, col<=3, col++
//5) print k++
//6) stop

