//function with parameter and return a value
#include<stdio.h>
int average(float n1,float n2,float  n3, float n4, float n5,float add)
{
	float result=add/5.0f;
	return result;

}
void main()
{
	float n1,n2,n3,n4,n5,add,result;
	printf("Enter 5 no =");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	add= n1+n2+n3+n4+n5;
	printf("Addition = %f",add);
	result=average(n1,n2,n3,n4,n5,add);
	printf("Average = %f",result);
}

//Algorithum
//1) start
//2) define the function average
//3) declare n1,n2,n3,n4,n5, add, result
//4) result=add/5
//5) end function
//6) go to main function
//7) accept no
//9) call the average function
//10) print average
//11) stop
