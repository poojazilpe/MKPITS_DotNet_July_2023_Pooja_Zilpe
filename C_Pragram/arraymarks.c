//write a program enter 5 sub marks and display sum of 5 sub marks.
#include<stdio.h>
void main()
{
	int i, sum=0, mark[5];
	for(i=0;i<5;i++)
	{
		printf("Enter 5 no marks =");
		scanf("%d",&mark[i]);
	}
	for(i=0;i<5;i++)
	{
		printf("Mark = %d\n",mark[i]);
		sum=sum+mark[i];
	}
	printf(" Total Marks = %d",sum);
}

//Algorithum
//1) start
//2) declare variable i, sum, mark[5]
//3) accept no
//4) if i=0,i<5,i++ then 
//5) print mark
//6) sum=sum+mark[i]
//6) then print total mark
//7) stop
