#include<stdio.h>
int main() 
{
int m1,m2,m3,total;
float per;
printf("Enter 3 Subject Marks =\n");
scanf("%d%d%d",&m1,&m2,&m3);
total=m1+m2+m3;
per=(total/300.0f)*100.0f;
printf("Enter Total Mark=%d\n",total);
printf("Enter Per=%f\n",per);

if (per>=75)
{
	printf("Grade = Distinction");
}
else if(per>=60 && per<75)
{
	printf("\nGrade = A");
}
else if(per>=50 && per<60)
{
	printf("\nGrade = B");
}
else if(per>=35 && per<35)
{
	printf("\nGrade = c");
}
else
{
	printf("\n Fail");
}
return 0;
}

//Algorithum
//1) start
//2) accept 3 sub marks, input m1,m2,m3;
//3) if percent is greater than equal to 75;
//    3.1 print "Grade is Distinction";
//4) else if percent greater than equal to 60 and less than 75;
//    4.1 print "Grade is First";
//5) else if percent is greater than qual to 50 and less than 60;
//    5.1 print "Grade is Second";
//6) else if percent is greater than equql to 35 and less than 35
//    6.1 else print "Fail"
//7) stop
