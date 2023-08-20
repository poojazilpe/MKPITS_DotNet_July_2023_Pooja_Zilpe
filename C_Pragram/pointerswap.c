//swap using 3rd variable
#include<stdio.h>
void main()
{
	int temp;
	int n1=10;
	int n2=20;
	int *p1=&n1;
	int *p2=&n2;
	printf("Before swap *p1=%d,*p2=%d\n",*p1,*p2);
	temp=*p1;
	*p1=*p2;
	*p2=temp;
	printf("After swap *p1=%d,*p2=%d",*p1,*p2);
}

//Algorithum
//1) start
//2) declare temp, n1=10,n2=20, p1,p2
//3) accept no
//4) temp=p1
//p1=p2
//p2=temp
//5) print after swap no
//6) stop
