#include<iostream>
using namespace std;
class person
{
	public:
	string name;
	int mobno;
};
class employee : public person
{
	public:
		int empno;
		int salary;
};
class parttime : public employee
{
	public:
		int noofhr;
};
int main()
{
	employee e1;
	e1.name="Pooja";
	e1.mobno=123;
	e1.empno=456;
	e1.salary=20000;
	cout<<"Employee Details"<<endl;
	cout<<e1.name<<endl<<e1.mobno<<endl<<e1.empno<<endl<<e1.salary<<endl;
	
	parttime p1;
	p1.name="Sandy";
	p1.mobno=786;
	p1.empno=896;
	p1.salary=30000;
	p1.noofhr=5;
	cout<<"Part time emp details"<<endl;
	cout<<p1.name<<endl<<p1.mobno<<endl<<p1.empno<<endl<<p1.salary<<endl<<p1.noofhr<<endl;
	return 0;
}
