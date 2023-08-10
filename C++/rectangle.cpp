#include<iostream>
using namespace std;
class Rectangle
{
	public:
	int length, breath;
	int calculateArea()
	{
		int a=length*breath;
		return a;
	}
	int calculatePerimeter()
	{
		int peri=2*(length+breath);
		return peri;
	}
};
int main()
{
	int result;
	Rectangle r1;
	cout<<"Enter length and breath :";
	cin>>r1.length>>r1.breath;
	result=r1.calculateArea();
	cout<<"Area :"<<result<<endl;
	result=r1.calculatePerimeter();
	cout<<"Perimeter :"<<result;
	return 0;
}
