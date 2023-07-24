#include<stdio.h>
void main()
{
	int counter=2;
	do
	{
		if (counter%2==0)
		{
			printf("\n%d",counter);
		}
		counter=counter+1;
	}
	while(counter<=10);
	
}

//Algorithum
//1) Start
//2) declare counter=2
//3) if counter%2==0 then print counter
//4) increment counter= counter+1
//5) if counter<=5 
//6) stop
