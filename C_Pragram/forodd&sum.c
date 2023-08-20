// write a program to display n terms of odd natural no and their sum.

# include<stdio.h>
void main()
{
	int num, i, sum=0;
	printf("Enter No :");
	scanf("%d",&num);
	printf("Odd no from 1 to %d are :\n",num);
	for (i=1; i<=num; i++)
	{
		if(i%2!=0)
		{
			printf("%d\n",i);
			sum=sum+i;
		}
	}
	printf("\n The sum of odd natural no upto %d terms : %d\n",num,sum);	

}

//Algorithum
//1) start
//2) declare num, i, sum
//3) accept num
//4) if i=1,i<=num, i++
//5) if i%2 is equal to not zero then print even no
//6) sum=sum+i then print sum
//7) stop 
