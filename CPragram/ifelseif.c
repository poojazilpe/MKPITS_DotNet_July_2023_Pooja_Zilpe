#include<stdio.h>
int main()
{
int n1,n2,n3;
printf("Enter 3 No =");
scanf("%d%d%d",&n1,&n2,&n3);
if(n1>n2 && n1>n3)
{
	printf("%d Is Greater",n1);
}
else if(n2>n3)
{
	printf("%d Is Greater",n2);
}
else
{
	printf("%d Is Greater",n3);
}
return 0;
}

//Algorithum
//1) start 
//2) accept 3 nos, input num1,num2,num3;
//3) if num1 is greater than num2 and num1 is greater than num3 if yes then
//   3.1) print (num1 is greater"
//4) else if num2 greater than num1 and  num2 greater than num3 if yes then
//   4.1) print"num2 is greater"
//5) else print"num3 is greater"
//6) stop
