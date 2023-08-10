#include<iostream>
using namespace std;
class bank
{
	public:
		int accno,balance,amt;
		bank(int balance,int amt)
		{
		this ->	balance=balance;
		this ->	amt=amt;
		}
		int getdeposite()
		{
			cout<<"Enter deposite amount :";
			cin>>amt;
			balance=balance+amt;
			cout<<"Amount Deposite :"<<balance<<endl;
			return 0;
		}
		int getwithdrow()
		{
			cout<<"Enter withdrow amount :";
			cin>>amt;
			balance=balance-amt;
			cout<<"Total Amount after withdrow:"<<balance<<endl;
		}
		
};
int main()
{
	int balance,amt;
	bank b1(balance,amt);
	cout<<"Enter account no and balance";
	cin>>b1.accno>>b1.balance;
	b1.getdeposite();
	b1.getwithdrow();
	return 0;
}
