#include<iostream>
using namespace std;
class shape
{
	public:
		int calculatearea(int l, int b)
		{//rectangle
		int a=l*b;
		return a;
		}
		float calculatearea(int r)
		{//circle
		float result=3.14f*r*r;
		return result;
		}
};
int main()
{
	shape c;
	cout<<"area of rec"<<c.calculatearea(2,5)<<endl;
	cout<<"area of cir"<<c.calculatearea(5);
	return 0;	
}
