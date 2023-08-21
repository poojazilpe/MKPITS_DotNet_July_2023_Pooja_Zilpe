#include<iostream>
using namespace std;
class person
{
	protected:
		string name;
};
class student:public person
{
	public:
		void getdata(string s)
		{
			name=s;
		}
		void displaydata()
		{
			cout<<"Name :"<<name;
		}
};
int main()
{
	student s1;
	s1.getdata("Pooja");
	s1.displaydata();
}
