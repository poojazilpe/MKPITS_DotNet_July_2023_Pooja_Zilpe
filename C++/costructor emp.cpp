#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee()
		{
			empno=123;
			empname="Pooja";
		}
		void display()
		{
		cout<<"Emp No :"<<empno<<endl;
		cout<<"Emp Name :"<<empname;
		}
};
int main()
{
	employee emp1;
	emp1.display();
	return 0;
}
