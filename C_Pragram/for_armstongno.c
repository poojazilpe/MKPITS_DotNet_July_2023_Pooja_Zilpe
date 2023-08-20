//write a program to cheak whether the given no is Amstrong or not
#include<stdio.h>
void main()
{
	int num,sum=0,r,i,cube;
	printf("Enter any no :");
	scanf("%d",&num);
	for(i=num;num!=0;num=num/10)
	{
		r=num%10;
		cube=r*r*r;
		sum=sum+cube;
		printf("cube=%d\n",cube);
	}
		printf("sum=%d\n",sum);
	if(sum==i)
	{
		printf("%d Armstrong no",sum);
	}
	else 
	{
		printf("%d Not Amstrong no",sum);
	}
	
}

//Alorithum
//1) start
//2) declare num,rem,sum,cube,a
//3) accept num
//4) if num>0 then
//5) rem=num%10
//6)cube=rem*rem*rem
//7)sum=num=/10 the print cube and sum
//8)if num=sum print Amstrong no. otherwise not
//9)stop

