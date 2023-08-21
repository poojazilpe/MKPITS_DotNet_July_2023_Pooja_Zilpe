#include<iostream>
using namespace std;
class student
{
	private:
	int rno;
	public:
		void dispaydata()
		{
			cout<<"Roll No :"<<rno;
		}
		void setdata(int r)
		{
			rno=r;
		}
	
};
int main()
{
	student s1;
	int rn;
	cout<<"Enter roll no:";
	cin>>rn;
	s1.setdata(rn);
	s1.dispaydata();
	
}
