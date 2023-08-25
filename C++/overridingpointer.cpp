#include<iostream>
using namespace std;
class Account
{
	public:
		int accno;
		int bal;
	virtual	void deposite(int amt)=0;
		
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
	Account *a;
	Saving s;
	Current c;
	a=&s;
	a=&c;
	a->accno=123;
	a->bal=2000;
	a->deposite(1000);
	a->accno=212;
	a->bal=1000;
	a->deposite(500);
	return 0;
}
