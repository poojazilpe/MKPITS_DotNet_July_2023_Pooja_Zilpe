#include<iostream>
using namespace std;
class employee
{
	public:
		int empno, salary;
		string name;
		string design;
	void getemp()
	{
	cout<<"Empno :"<<"Name :"<<"Designation :"<<"Salary :";
	cin>>empno>>name>>design>>salary;
	}
	void displayemp()
	{
		cout<<"Emp no :"<<empno<<endl;
		cout<<"Emp Name :"<<name<<endl;
		cout<<"Designation :"<<design<<endl;
		cout<<"Salary :"<<salary<<endl;
	}
};
	int main()
	{
		employee emp1, emp2;
		cout<<"Employee 1 :"<<endl;
		emp1.getemp();
		emp1.displayemp();
		cout<<"Employee 2 :"<<endl;
		emp2.getemp();
		emp2.displayemp();
		return 0;
	}
		
		

