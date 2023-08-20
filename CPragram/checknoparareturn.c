//function without parameter and return a value.
#include<stdio.h>
int check()
{
	int num, rem=0;
	printf("Enter no =");
	scanf("%d",&num);
	if(num%2==0)
	{
	printf("This is a even no");
	}
	else
	{
		printf("This is odd no");
	}
	return 0;
}
void main()
{
	int num, rem=0;
	check(num,rem);
}

//Algorithum
//1) start
//2) define the function check
//3) declare int num, rem
//4) accept no
//5) if num%2=0 then even else odd no
//6) end function
//7) go to main function
//8) call the check function
//9) stop

