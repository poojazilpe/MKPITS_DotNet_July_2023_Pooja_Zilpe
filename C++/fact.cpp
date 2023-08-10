#include<iostream>
using namespace std;
int main()
{
	int num, fact=1;
	cout<<"Enter no.";
	cin>>num;
	while(num>0)
	{
		fact=num*fact;
		num=num-1;
	}
	cout<<"factorial = "<<fact<<endl;
	return 0;
	
}
