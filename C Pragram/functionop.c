#include<stdio.h>
void calculate(int n1,int n2,char op)
{
	int result=0;
	switch (op)
	{
		case '+':
		result=n1+n2;
		break;
		case '-':
		result=n1-n2;
		break;
		case '*':
		result=n1*n2;
		break;
		case '/':
		result=n1/n2;
		break;
		
	}
	printf("Result = %d\n",result);
}
void main()
{
	int n1,n2,result;
    char op;
    char ch = 'y';
    while(ch='y')
    {
	printf("Enter 2 no : ");
    scanf("%d%d",&n1,&n2);
    printf("Enter any operator(+,-,*,/) :");
    fflush(stdin);
    scanf("%c",&op);
    calculate(n1,n2,op);
    printf("Do you want to continue,press y : ");
    fflush(stdin);
    scanf("%c",&ch);
    }
   
}
//Algorithum
//1) start
//2) define the function calculate
//3) int n1,n2,result=0, char op
//4) using switch statement
//5) if op is'+' then result=n1+n2, if op is '-' then result=n1-n2, op is '*' then result=n1*n2, op is '/' then n1/n2
//5) exit loop, end the function
//6) call the calculate function
//7) accept 2 no, enter operator.
//7) stop

    

