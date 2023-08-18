#include<iostream>
using namespace std;
class account
{
	public:
		int accno;
		int bal;
		int intrest;
	void getdata(int a, int b, int c)
	{
		accno=a;
		bal=b;
		intrest=c;
	}
};
class saving:public account
{
	public:
	int deposite(int amt)
	{
		bal=bal+intrest+amt;
		return bal;
	}
};
class current:public account
{
	public:
	int deposite(int amt)
	{
		bal=bal+amt;
		return bal;
	}
};
int main()
{
	saving s1;
	current c1;
	int result;
	int accno,bal,intrest,amt;
	cout<<"Enter account no, balance, intrest, amount:";
	cin>>accno>>bal>>intrest>>amt;
	s1.getdata(accno,bal,intrest);
	result=s1.deposite(amt);
	cout<<"saving balance:"<<result<<endl;
	c1.getdata(accno,bal,intrest);
	result=c1.deposite(amt);
	cout<<"current balance:"<<result;
	return 0;
	
	
}
