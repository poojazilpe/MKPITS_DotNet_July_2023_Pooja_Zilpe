#include<stdio.h>
void main()
{
	int counter=21;
	do
	{
		if(counter%2!=0)
		{
			printf("%d\n",counter);
		}
		counter=counter+1;
	}
	while(counter<=30);
}

//Algorithum
//1) start
//2) declare counter=21
//3)if counter % 2!=0 then
// print counter
//4) counter=counter+1
//5) check counter<=30
//6) stop
