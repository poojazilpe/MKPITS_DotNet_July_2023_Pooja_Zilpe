#include<iostream>
using namespace std;
int prime(int num, int counter, int rem)
{
	while(counter<num)
	{
		rem=num%counter;
		if(rem==0)
		{
			cout<<"not prime";
			break;
		}
		counter++;
	}
	if(num==counter)
	{
	cout<<"prime";	
	}
}
int main()
{
	int num,counter=2,rem=0;
	cout<<"Enter no :";
	cin>>num;
	prime(num,counter,rem);
	return 0;
}
