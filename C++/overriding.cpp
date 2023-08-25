#include<iostream>
using namespace std;
class Account
{
	public:
		int accno;
		int bal;
		void deposite(int amt)
		{
			cout<<"Hello deposite";
		}
};
class Saving:public Account
{
	public:
		
		void deposite(int amt)
		{
			int intrest=500;
			bal=bal+amt+intrest;
			cout<<"Balance with intrest :"<<bal<<endl;
		}
};
class Current:public Account
{
	public:
		void deposite(int amt)
		{
			bal=bal+amt;
			cout<<"Balance without intrest :"<<bal<<endl;
		}
};
int main()
{
	Saving s;
	Current c;
	s.accno=123;
	s.bal=2000;
	s.deposite(1000);
	c.accno=212;
	c.bal=1000;
	c.deposite(500);
	return 0;
}
