#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
	void getdata(int a, int b)
	{
		x=a;
		y=b;
	}
};
class rectangle:public shape
{
	public:
		int crarea()
		{
			int ra;
			ra=x*y;
			return ra;
		}
};
class triangle:public shape
{
	public:
		float ctarea()
		{
			float ta;
			ta=0.5f*x*y;
			return ta;
		}
};
int main()
{
	rectangle r;
	triangle t;
	int ra;
	float ta;
	int length, breath, base, height;
	cout<<"Enter length & breath:";
	cin>>length>>breath;
	r.getdata(length,breath);
	ra=r.crarea();
	cout<<"Area of rectangle:"<<ra<<endl;
	cout<<"Enter base & height:";
	cin>>base>>height;
	t.getdata(base,height);
	ta=t.ctarea();
	cout<<"Area of triangle:"<<ta;
	return 0;
}
