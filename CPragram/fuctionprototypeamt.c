#include<stdio.h>
void deposite(int amt, int bal);
void withdrow(int amt, int bal);
void main()
{
	int amt, bal=1000;
	printf("Enter Amount : ");
	scanf("%d",&amt);
	deposite(amt,bal);
	withdrow(amt,bal);
}
void deposite(int amt, int bal)
{
	bal=bal+amt;
	printf("Amount deposite,Balence is= %d\n",bal);
}
void withdrow(int amt, int bal)
{
	bal=bal-amt;
	printf("Amount Withdrow, Balence is = %d",bal);
}
