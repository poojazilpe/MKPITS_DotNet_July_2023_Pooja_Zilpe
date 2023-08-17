#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mob;
	void getpersondata(string name, int mob)
	{
		name=name;
		mob=mob;
	}
};
class employee : public person
{
	public:
		int empno;
		int salary;
	void getempdata(int empno,int salary)
	{
		empno=empno;
		salary=salary;
	}
	void display()
	{
		cout<<"Name :"<<name<<endl;
		cout<<"Mob No :"<<mob<<endl;
		cout<<"Emp No :"<<empno<<endl;
		cout<<"Salary :"<<salary<<endl;
	}
};
int main()
{
	employee e1;
	string name;
	int mob,empno, salary;
	cout<<"Enter Name, Mobno, Emp no, Salary :"<<endl;
	cin>>e1.name>>e1.mob>>e1.empno>>e1.salary;
	e1.getpersondata(e1.name,e1.mob);
	e1.getempdata(e1.empno,e1.salary);
	e1.display();
	return 0;
	
}
