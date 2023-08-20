// enter any no then print square from 1 to given no and sum of their no.
#include<stdio.h>
void main()
{
	int num, i;
	int square;
	int sum=0;
	printf("Enter No :");
	scanf("%d",&num);
	
	printf("square from 1 to %d are:\n",num);
	for (i=1;i<=num;i++)
	{
		square=i*i;
		printf("%d\n",square);
		sum=sum+square;
		
	}
	printf("\nThe sum of square natural no upto %d terms : %d\n",num,sum);
}

//Algorithum
//1) start
//2) declare num,i,square,sum
//3) accept no
//4) if i=1,i<=num,i++
//5) square=i*i then print square
//6) sum=sum+square the print sum
//7)stop

