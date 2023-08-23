#include<iostream>
using namespace std;
int myfunct(int x,int y)
{
	if(y<=0)
	{
	return 1;	
	}
	else
	{
		return x * (myfunct(x,y-1));
	}
}
int main()
{
	int res;
	res=myfunct(5,3);
	cout<<"result="<<res;
	return 0;
	
}
