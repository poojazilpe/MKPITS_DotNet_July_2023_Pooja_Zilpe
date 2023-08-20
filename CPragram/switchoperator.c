#include<stdio.h>
void main()
{
	int num1,num2,result=0;
	char op;
	printf("Enter 2 Nos=");
	scanf("%d%d",&num1,&num2);
	printf("Enter (+,-,*,/)=");
	fflush(stdin);
	scanf("%c",&op);
	switch (op)
	{
	  case '+':
		result=num1+num2;
		break;
		case '-':
			result=num1-num2;
			break;
			case '*':
		result=num1*num2;
		break;
		case '/':
			result=num1/num2;
			break;
			default:
				printf("Invalid Operator");
				break;
	}
	printf("Result=%d",result);
			
}
//Algorithum
//1) start
//2) accept 2 nos, input num1,num2
//3) if operator is '+' then
//3.1) print "result = num1+num2
//4) if operator is '-' then
//4.1) print "result = num1-num2
//5) if operator is '*' then
//5.1) print "result = num1*num2
//6) if operator is '/' then
//6.1) print "result = num1/num2
//7) if operator is not between (+,-,*,/) then
//7.1) printf "invalid operator"
//8) stop



