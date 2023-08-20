// 3 sub mark and their sum.
#include<stdio.h>
void main()
{
	int i, sum=0, marks[3];
	marks[0]=90;
	marks[1]=45;
	marks[2]=50;
	for(i=0;i<3;i++)
	{
		printf("Marks = %d\n",marks[i]);
		sum=sum+marks[i];
	}
	printf("Total Marks %d",sum);
}

//Algorithum
//1) start
//2) declare variable i, sum, mark[3]
//3) accept no mark[0]=90, mark[1]=45, mark[2]=50
//4) if i=0,i<3,i++ then 
//5) print mark
//6) sum=sum+mark[i]
//6) then print total mark
//7) stop
