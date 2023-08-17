#include<iostream>
using namespace std;
class circle
{
	public:
		int r;
		circle()
		{
			r=0;
		}
		float area()
		{
			float area=3.14f*r*r;
			return area;
		}
		float coc()
		{
			float coc=2*3.14f*r;
			return coc;
		}
};
int main()
{
	float result;
	float area, coc;
	circle c1;
	cout<<"Enter radius :";
	cin>>c1.r;
	result=c1.area();
	cout<<"Area ="<<result<<endl;
	result=c1.coc();
	cout<<"Coc ="<<result;
	return 0;
}
