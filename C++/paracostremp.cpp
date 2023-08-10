#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee (int eno,string ename )
		{
			empno=eno;
			empname=ename;
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
	string ename;
	employee emp1(11,"pooja");
	emp1.display();
	return 0;
	
}
