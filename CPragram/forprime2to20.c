// write a program prime no 2 to 20.

#include<stdio.h>
void main ()
{
	int counter=2;
	int num;
	int rem=0;
	for (num=3;num<=20;num++)
	{
		counter=2;
		while (counter<num)
		{
			rem=num%counter;
		if(rem==0)
		{
			break;
		}
		counter++;
		if(num==counter)
		{
			printf("%d Is prime no\n",num);
		}
	}
}

}

//Algorithum
//1) start
//2) declare counter=2, num, rem=0
//3) if num=3, num<=20, num++ then 
//4) if counter<num then 
//5) rem=num%counter
//6) if rem=0 then break
//7) if num=counter then print prime no.
//8) stop
