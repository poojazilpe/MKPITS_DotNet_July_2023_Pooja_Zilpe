#include<stdio.h>
int main()
{
int num;
printf("Enter No =");
scanf("%d",&num);
if (num<0)
{
	printf("%d is Negative",num);
}
else if(num==0)
{
	printf("%d is eual to Zero",num);
}
else
{
	printf("%d is Positive",num);
}
return 0;
}

//Algorithum
//1) start
//2) accept num 
//3) if num is less than zero
//    3.1 print "num is negative"
//4) else if num is equal to zero
//    4.1 print " num is equal to zero"
//5) else print "num is positive"
//6) stop
