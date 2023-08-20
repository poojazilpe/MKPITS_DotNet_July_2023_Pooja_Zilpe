//write a program to display the cube of no upto integer.

#include<stdio.h>
void main()
{
	int num, i, cube;
	printf("Enter No :");
	scanf("%d",&num);
	for (i=1;i<=num;i++)
	{
		cube=i*i*i;
		printf("\n%d Cube is : %d",i,cube);
	}
}

//Algorithum
//1) start
//2) declare num, i, cube
//3) accept no
//4)if i=1, i<=num, i++ then
//5) cube=i*i*i then print cube
//6) stop


