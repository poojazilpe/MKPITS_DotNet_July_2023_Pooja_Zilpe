#include<iostream>
using namespace std;
class Shape
{
public:
virtual void drow()=0;	
};
class Rectangle:public Shape
{
	public:
		void drow()
		{
			cout<<"Drow from rectangle"<<endl;
		}
};
int main()
{
	Rectangle r;
	r.drow();
	return 0;
}
