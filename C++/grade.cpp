#include<iostream>
using namespace std;
class student
{
	public:
	int rollno, clas;
	string name;
	void getstudent()
	{
		cout<<"Enter student Name, class, Roll No";
		cin>>name>>clas>>rollno;
	}
	void displaystudent()
	{
		cout<<"Student Name :"<<name<<endl;
		cout<<"Student Class :"<<clas<<endl;
		cout<<"student Roll No :"<<rollno;
	}
	float calculateGrade()
	{
		float m1,m2,m3,per,total;
		cout<<"Enter 3 subject marks :";
		cin>>m1>>m2>>m3;
		total=m1+m2+m3;
		cout<<"Total Mark :"<<total<<endl;
		per=(total/300)*100;
		cout<<"Percentage :"<<per<<endl;
		if(per>=75)
		{
			cout<<"Grade is Distinction"<<endl;
		}
		else if(per>=60)
		{
			cout<<"Grade is A"<<endl;	;
		}
		else if(per>=40)
		{
			cout<<"Grade is B"<<endl;
		}
		else
		{
			cout<<"Fail"<<endl;
		}
		return per;
	}
};
	int main()
	{
		student stud1;
		stud1.getstudent();
		stud1.displaystudent();
		stud1.calculateGrade();
		return 0;
		
	}

