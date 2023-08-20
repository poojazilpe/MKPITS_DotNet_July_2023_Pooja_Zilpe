// print a table of given no.
#include<stdio.h>
void main()
{
	int num;
	int counter;
	int result=0;
	printf("Enter No :");
	scanf("%d",&num);
	for (counter=1;counter<=10;counter++)
	{
		result=num*counter;
		printf("%d*%d=%d\n",num,counter,result);
	}
} 

//Algorithum
//1) start
//2) declare num, counter, result=0
//3) accept num
//4) if counter=1, counter<=10, counter++
//5) result=num*counter then print table
//6) stop 
