#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length, breath;
		int a,peri;
		rectangle(int length, int breath)
		{
			this ->length=length;
			this ->breath=breath;
		}
		float calculateArea()
		{
			float a=length*breath;
			return a;
		}
		float calculateperi()
		{
			float peri=2*(length+breath);
			return peri;
		}
};
int main()
{
	int length,breath,result;
	rectangle r1(length,breath);
	cout<<"Enter Length and Breath :";
	cin>>r1.length>>r1.breath;
	result=r1.calculateArea();
	cout<<"Area ="<<result<<endl;
	result=r1.calculateperi();
	cout<<"Perimeter ="<<result<<endl;
	return 0;
}
