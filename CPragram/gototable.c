#include<stdio.h>
void main()
{
	int num, i=1;
	printf("Enter no=");
	scanf("%d",&num);
	table:
		printf("%d*%d=%d\n",num,i,num*i);
		i++;
		if(i<=10)
		{
			goto table;
		}
		
			
		}

//Algorithum
//1) start
//2) declare variable num i=1
//3) accpt no
//4) use lable table
//5) print num*i=result then increment i
//6) if i<=10 then goto table
//7) stop

