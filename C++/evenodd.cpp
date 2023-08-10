#include<iostream>
using namespace std;
int main()
{
	int num, rem;
	cout<<"Enter no :";
	cin>>num;
	while(num>0)
	if(num%2==0)
	{
		cout<<"even";
		break;
	}
	else
	{
		cout<<"odd";
		break;
	}
}
