#include<iostream>
using namespace std;
int area(int num)
{
	int result=num*num;
	return result;
}
int main()
{
	int num,result;
 	cout<<"Enter no :";
 	cin>>num;
 	result=area(num);
 	cout<<"Area ="<<result;
 	return 0;	
	
}
