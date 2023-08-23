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
	int n1,n2;
	float n1f,n2f;
	calculation c;
	cout<<"Enter 2 no:";
	cin>>n1>>n2;
	cout<<"Addition of integer :"<<c.add(n1,n2)<<endl;
	cout<<"Enter 2 no:";
	cin>>n1f>>n2f;
	cout<<"Addition of float :"<<c.add(n1f,n2f);
	return 0;
}
