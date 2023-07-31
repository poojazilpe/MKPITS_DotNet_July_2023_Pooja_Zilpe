//function without parameter and return value
#include<stdio.h>
int area()
{
	int side;
	printf("Enter side =");
	scanf("%d",&side);
	int result=side*side;
	return result;
}
void main()
{
	int result;
	result=area();
	printf("Area of Square = %d",result);
}
//Algorithum
//1) start
//2) define the function area
//3) declare side, result.
//4) accept no
//5) result=side*side
//6) return value
//7) end function
//8) go to main function
//9) call the area function
//10) print area of square.
//11) stop
