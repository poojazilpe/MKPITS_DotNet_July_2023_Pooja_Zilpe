#include<iostream>
using namespace std;
int main()
{
	int num1,num2,add,i;
	num1=0;
	num2=1;
	add=num1+num2;
	cout<<num1<<num2;
	for(i=3;i<10;i++)
	{
		cout<<add;
		num1=num2;
		num2=add;
		add=num1+num2;	
	}
	return 0;
}
