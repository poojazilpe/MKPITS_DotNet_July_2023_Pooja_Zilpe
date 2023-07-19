#include<stdio.h>
int main()
{
	int month;
	printf("Enter Month(1-12) =");
	scanf("%d",&month);
	switch (month)
	{
	  case 1:
	  case 3:
	  case 5:
	  case 7:
	  case 8:
	  case 10:
	  case 12:
	   printf("The month has 31 Days\n");
    break;
        case 4:
        case 6:
        case 9:
        case 11:
        	printf("The month has 30 Days\n");
    break;
        case 2:
        	printf("The month can have either 28 or 29 days\n");
    break;
    default:
	  printf("Invalid Month");
	  break;
	}

	return 0;
}
//Algorithum
//1) start
//2) accept month (1-12)
//3) if the vale of the month variable. for month with 31 days
// (jan,mar,may,july,aug,oct,&dec) then
//3.1) print "the month has 31 days"
//4) for month with 30 days (apr,jun,sep,&nov)then
//4.1 print "the month has 30 days"
//5) for month feb Print"it either 28 or 29 "
//6)if invalid month
// print "invalid month:
//7) stop

