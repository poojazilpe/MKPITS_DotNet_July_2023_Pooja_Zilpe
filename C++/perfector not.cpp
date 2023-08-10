#include<iostream>
using namespace std;
int main()
{
	int num,i,sum=0;
	cout<<"Enter no :";
	cin>>num;
	cout<<"excluding of enter no are "<<endl;
	for(i=1;i<num;i++)
	{
		if(num%i==0)
		{
			cout<<i;
			sum=sum+i;
		}
	}
	cout<<endl<<"Sum ="<<sum<<endl;
	if(num==sum)
	{
		cout<<"Perfect";
	}
	else
	{
		cout<<"not perfect";
	}
	}
