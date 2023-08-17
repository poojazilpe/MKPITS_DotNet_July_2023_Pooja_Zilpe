#include<iostream>
using namespace std;
class circle
{
	public:
		int r;
		circle(float r)
		{
		this ->	r=r;
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
	int r;
	float result;
	float area, coc;
	circle c1(r);
	cout<<"Enter radius :";
	cin>>c1.r;
	result=c1.area();
	cout<<"Area ="<<result<<endl;
	result=c1.coc();
	cout<<"Coc ="<<result;
	return 0;
}
