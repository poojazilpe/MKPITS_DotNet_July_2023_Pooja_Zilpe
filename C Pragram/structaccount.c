#include<stdio.h>
#include<string.h>
struct bank
{
	char name[20];
	int acc_no, bal;
};
void main()
{
struct bank b1[3];

	int counter;
	for(counter=0;counter<3;counter++)
	{
	printf("Enter name, account no and balence :");
	scanf("%s%d%d",b1[counter].name,&b1[counter].acc_no,&b1[counter].bal);
	}
	printf("Account with balance is less than 100 :\n");
	for(counter=0;counter<3;counter++)
	{
		if(b1[counter].bal<100)
		{
			printf("Name=%s,account no=%d",b1[counter].name,b1[counter].acc_no);
		}
	}
}
//Algorithum
//1) start
//2) define structure bank
//3) declare name, account no, balence, copunter
//4) create an array of structure bank b1 with size 3
//5) loop from counter=0 to counter<2
//6) accept name acc no balence
//7) in loop if bal<100 then print
//8) print their name and acc no
//9) stop
