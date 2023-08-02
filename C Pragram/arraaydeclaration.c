// Array declaration with ilnitialisation
//Array declaration with initialisation
#include<stdio.h>
void main()
{
	int i, sum=0;
	int mark[3]={83,58,79};
	for(i=0;i<3;i++)
	{
		printf("mark = %d\n",mark[i]);
		sum=sum+mark[i];
	}
	printf("Total Mark =%d",sum);
	
}

//Algorithum
//1) start
//2) declare variable i, sum=0
//3) accept no mark are already declare
//4) if i=0,i<3,i++ then 
//5) print mark
//6) sum=sum+mark[i]
//7) print Total mark
//8) stop
