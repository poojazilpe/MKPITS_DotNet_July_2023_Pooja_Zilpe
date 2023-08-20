//function with parameter and return a value
#include<stdio.h>
int area(int side)
{
	int result=side*side;
	return result;
}
void main()
{
	int side, result;
	printf("Enter side =");
	scanf("%d",&side);
	result=area(side);
	printf("Area of Square = %d",result);
}
//Algorithum
//1) start
//2) define the function area
//3) declare side, result.
//4) result=side*side, return result
//5) end function
//6) go to main function
//7) declare side, result
//8)accept num
//9) call the area function
//10) print area of square
//11) stop
