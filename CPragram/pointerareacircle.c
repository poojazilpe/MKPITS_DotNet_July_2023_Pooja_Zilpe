//write a program to calculate area and coc
#include<stdio.h>
void calculate(int r,float *a,float *c)
{
	*a=3.14f*r*r;
	*c=2*3.14f*r;
}
void main()
{
	int radius;
	float area, coc;
	printf("Enter no =");
	scanf("%d",&radius);
	calculate(radius,&area,&coc);
	printf("Area of circle = %f\n",area);
	printf("Cicumference of circle = %f",coc);
	
		
}
//Algorithum
//1) start
//2) define the function calculate
//3) declare radius, area, coc
//4) area=3.14*radius*radius
//	 coc=2*3.14*radius
//5)end function, go to main function
//6) declare radius,area,coc
//7) accept no
//8) call the calculate function
//9) print Area and Coc
//10) stop
