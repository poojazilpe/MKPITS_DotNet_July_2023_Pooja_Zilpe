#include<iostream>
using namespace std;
int main()
{
	int n1,n2,result;
	char op;
	cout<<"Enter 2 no :";
	cin>>n1>>n2;
	cout<<"Enter op(+,-,*,/):";
	cin>>op;
	while(n1>0 && n2>0)
	{
	if(op=='+')
	{
		result=n1+n2;
	}
	else if(op=='-')
	{
		result=n1-n2;
	}
	else if(op=='*')
	{
		result=n1*n2;
	}
	else if(op=='/')
	{
		result=n1/n2;
	}

	cout<<"Result = "<<result;

	return 0;
}
	
}
