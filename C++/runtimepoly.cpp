#include<iostream>
using namespace std;
class shape
{
	public:
		virtual void drow()
		{
			cout<<"Method of shape class "<<endl;
		}
};
class rectangle:public shape
{
	public:
		void drow()
		{
			cout<<"method of rectangle class"<<endl;
		}
};
int main(){
	shape *s;
	shape s1;
	rectangle r1;
	s=&s1;
	s->drow();
	s=&r1;
	s->drow();
	return 0;
}
