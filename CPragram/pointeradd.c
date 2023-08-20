// write a program add 2 nos using pointer
#include<stdio.h>
void addition(int n1, int n2, int *add)
{
	*add=n1+n2;
}
void main()
{
	int n1,n2,add;
	printf("Enter 2 no =");
	scanf("%d%d",&n1,&n2);
	addition(n1,n2,&add);
	printf("Addition =%d",add);
}

//Algorithum
//1) start
//2) define the function addition
//3) declare n1,n2,add
//4) add=n1+n2
//5)end function, go to main function
//6) declare n1,n2, add
//7) accept no
//8) call the addition function
//9) print addition
//10) stop
