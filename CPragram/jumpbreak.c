#include<stdio.h>
void main()
{
	int i;
	for(i=1;i<=10;i++)
	{
		printf("num= %d\n",i);
		if(i%2==0)
		{
			break;
		}
	}
	printf("\n Bye");
}

//Algorithum
//1) start
//2) declare variable i
//3) if i=1, i<=10, i++
//4) print num
//5) if i%2=0 then break 
//6) and print bye
//7) stop

