//function with parameter no return value
#include<stdio.h>
void average(float n1,float n2,float n3,float n4,float n5)
{
	float add=n1+n2+n3+n4+n5;
	float result=add/5.0f;
	printf("Addition = %f\n",add);
	printf("Average = %f",result);
}
void main()
{
	float n1,n2,n3,n4,n5,add, result;
	printf("Enter 5 no =");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	average(n1,n2,n3,n4,n5);
}
//Algorithum
//1) start
//2) define the function average
//3) declare n1,n2,n3,n4,n5, add, result
//4) add=n1+n2+n3+n4+n5
//6) result=add/5
//7) then print average
//8) end function
//9) go to main function
//10) accept no
//9) call the average function
//11) stop
