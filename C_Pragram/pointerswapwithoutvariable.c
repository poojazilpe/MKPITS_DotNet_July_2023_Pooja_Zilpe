//swap without using 3rd variable
#include<stdio.h>
void main()
{
	int n1=10;
	int n2=20;
	int *p1=&n1;
	int *p2=&n2;
	printf("before swap *p1=%d,*p2=%d\n",*p1,*p2);
	*p1=*p1+*p2;
	*p2=*p1-*p2;
	*p1=*p1-*p2;
	printf("after swap *p1=%d,*p2=%d",*p1,*p2);
}

//Algorithum
//1) start
//2) declare temp, n1=10,n2=20, p1,p2
//3) accept no
//4) p1=p1+p2
//p2=p1-p2
//p1=p1-p2
//5) print after swap no
//6) stop
