// without parameter and no return value
#include<stdio.h>
void average()
{
	float n1,n2,n3,n4,n5,add;
	float result;
	printf("Enter 5 no =");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	add=n1+n2+n3+n4+n5;
	printf("Addition = %f\n",add);
	result=add/5.0f;
	printf("Average = %f",result);
	
}
void main()
{
	float n1,n2,n3,n4,n5,add;
	float result;
	average(n1,n2,n3,n4,n5,add, result);
}

//Algorithum
//1) start
//2) define the function average
//3) declare n1,n2,n3,n4,n5, add, result
//4) accept no
//5) add=n1+n2+n3+n4+n5
//6) result=add/5
//7) then print average
//8) end function
//8) go to main function
//9) call the average function
//10) stop
