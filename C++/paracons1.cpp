#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee(int eno,string en)
		{
			empno=eno;
			empname=en;
		}
		void display()
		{
			cout<<"Emp No :"<<empno<<endl;
			cout<<"Emp Name :"<<empname;
		}
		
};
int main()
{
	int eno;
	string en;
	cout<<"Enter Emp no and Name :";
	cin>>eno>>en;
	employee e1(eno,en);
	e1.display();
	return 0;
}
