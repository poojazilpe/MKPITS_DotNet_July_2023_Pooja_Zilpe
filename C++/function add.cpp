#include<iostream>
using namespace std;
int addition(int n1,int n2)
{
	int result=n1+n2;
	cout<<"Addition = "<<result<<endl;
}
int main()
{
	int n1,n2;
	cout<<"Enter no :";
	cin>>n1>>n2;
	addition(n1,n2);
	return 0;
}
