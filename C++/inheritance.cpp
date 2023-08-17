#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string city;
};
class student: public person
{
	public:
		int rollno;
		int mark;
};
int main()
{
	student s1;
	s1.name="Pooja";
	s1.city="Nagpur";
	s1.rollno=123;
	s1.mark=980;
	cout<<s1.name<<endl<<s1.city<<endl<<s1.rollno<<endl<<s1.mark;
}
