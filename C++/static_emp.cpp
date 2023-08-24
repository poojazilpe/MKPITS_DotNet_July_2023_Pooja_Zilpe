#include<iostream>
using namespace std;
class Employee
{
	public:
		int empno;
		string name;
		static string company;
		Employee(int empno,string name)
		{
			this -> empno=empno;
			this -> name=name;
		}
		void display()
		{
			cout<<"Employee No"<<empno<<endl;
			cout<<"Employee Name:"<<name<<endl;
			cout<<"Company Name"<<company;
		}
};
string Employee::company="Microsoft";
int main()
{
	Employee e=Employee(123,"Pooja");
	Employee e1=Employee(212,"Kareena");
	e.display();
	e1.display();
	return 0;
}
