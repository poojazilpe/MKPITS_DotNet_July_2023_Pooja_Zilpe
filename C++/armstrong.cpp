#include<iostream>
using namespace std;
int main()
{
	int num,cube,i, r,sum=0;
	cout<<"Enter no :";
	cin>>num;
	i=num;
	while(num>0)	
	{
		r=num%10;
		cube=r*r*r;
		sum=sum+cube;
		num=num/10;
		cout<<"cube ="<<cube;
		
	}
	cout<<"sum ="<<sum<<endl;
	if(sum==i)
	{
		cout<<"Armstrong"<<endl;
	}
	else
	{
		cout<<"Not Armstrong"<<endl;
	}
	return 0;
	
}
