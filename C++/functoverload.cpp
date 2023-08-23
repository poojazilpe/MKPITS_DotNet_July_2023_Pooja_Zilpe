#include<iostream>
using namespace std;
class calculation
{
	public:
		int add(int n1,int n2)
		{
			return n1+n2;
		}
		float add(float n1,float n2)
		{
			return n1+n2;
		}
};
int main()
{
	calculation c;
	cout<<"Addition of integer :"<<c.add(5,3)<<endl;;
	cout<<"Addition of float :"<<c.add(5.0f,7.0f);
	return 0;
}
