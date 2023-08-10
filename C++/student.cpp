#include<iostream>
using namespace std;
class student
{
	public:
		int rollno;
		string name;
		string course;
	void getData()
	{
		cout<<"Roll No, "<<"Name"<< " Couse :";
		cin>>rollno>>name>>course;
	}
	void displayData()
	{
		cout<<"Roll No ="<<rollno<<endl;
		cout<<"Name ="<<name<<endl;
		cout<<"course ="<<course<<endl;
	}
};
int main()
{
student stud1, stud2;
cout<<"Student 1 :"<<endl;
stud1.getData();
stud1.displayData();
cout<<"Student 2 :"<<endl;
stud2.getData();
stud2.displayData();
return 0;
}



