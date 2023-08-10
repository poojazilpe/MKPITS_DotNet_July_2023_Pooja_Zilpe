#include<iostream>
using namespace std;
class Circle
{
	public:
		int radius;
		float calculateArea()
		{
			float a=3.14f*radius*radius;
			return a;
		}
		float calculateCoc()
		{
			float Coc=2*3.14f*radius;
			return Coc;
		}
};
int main()
{
	float result;
	Circle c1;
	cout<<"Enter Radius :";
	cin>>c1.radius;
	result=c1.calculateArea();
	cout<<"Area :"<<result<<endl;
	result=c1.calculateCoc();
	cout<<"Circumferance of Circle :"<<result;
	return 0;	
}
