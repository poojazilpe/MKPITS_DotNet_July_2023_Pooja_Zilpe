//function without parameter no return value
#include<stdio.h>
void area()
{
	int side, result=0;
	printf("Enter side :");
	scanf("%d",&side);
	result=side*side;
	printf("Area of square = %d",result);
}
void main()
{
	int result=0,side;
	area(side,result);
		
}
//Algorithum
//1) start
//2) define the function area
//3) declare side, result.
//4) accept no
//5) result=side*side
//6) then print area of sq
//7) end function
//8) go to main function
//9) call the area function
//10) stop
