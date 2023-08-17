#include<iostream>
using namespace std;
class employee
{
	public:
		int salary;
		string dept;
};
class person : public employee
{
	public:
		string name;
		string address;
};
int main()
{
	person p1;
	cout<<" Enter Name Address Department Salary :";
	cin>>p1.name>>p1.address>>p1.dept>>p1.salary;
	cout<<"Name :"<<p1.name<<endl;
	cout<<"Address :"<<p1.address<<endl;
	cout<<"Department :"<<p1.dept<<endl;
	cout<<"Salary :"<<p1.salary;
	return 0;
}
