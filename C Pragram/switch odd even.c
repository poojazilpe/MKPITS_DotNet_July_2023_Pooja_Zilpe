#include<stdio.h>
void main()
{
	int num;
	printf("Enter No =");
	scanf("%d",&num);
	switch (num%2==0)
	{
	 case 1:
	   printf("No is Even=%d",num);
        break;
     default:
	printf("No is Odd=%d",num);
	break;
	}
}

//1) Algorithum
//2) accept num
//3) if num is devided by 2 is equal to zero then
//3.1 print " num is even"
//4) otherwise print" no is odd"
//5) stop
