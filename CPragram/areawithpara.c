//function with parameter and no return a value
#include<stdio.h>
void area(int side)
{
	int result=side*side;
	printf("Area of square = %d",result);
}
void main()
{ 
	int side;
	printf("Enter side = ");
	scanf("%d",&side);
	area(side);
}

//Algorithum
//1) start
//2) define the function area
//3) result=side*side
//4) print area of square
//5) end function
//6) go to main function
//7) declare side
//8) accept side
//9) call the area function
//10) stop
