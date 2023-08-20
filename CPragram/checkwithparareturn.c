//function with parameter and return a value.
#include<stdio.h>
int check(int num, int rem)
{
	if(num%2==0)
	{
		printf("This is a Even no");
	}
	else
	{
		printf("This is a Odd no");
	}
	return 0;
}
void main()
{
	int num, rem=0;
	printf("Enter No =");
	scanf("%d",&num);
	check(num, rem);
}

//Algorithum
//1) start
//2) define the function check
//3) declare int num, rem
//4) if num%2=0 then even else odd no
//5) end function
//6) go to main function
//7) accept no
//8) call the check function
//9) stop
