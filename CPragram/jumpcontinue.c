#include<stdio.h>
void main()
{
	int i;
	for(i=1;i<=10;i++)
	{
		if(i%2==0)
		{
			continue;
		}
		printf("num= %d\n",i);
	}
	printf("\nbye");
}

//Algorithum
//1) start
//2) declare variable i
//3) if i=1, i<=10, i++
//5) if i%2=0 then continue
//6) print num
//7) and print bye
//8) stop
