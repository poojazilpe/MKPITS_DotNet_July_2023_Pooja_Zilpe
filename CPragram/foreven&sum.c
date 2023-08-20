//write a program to display the no of even natural no and their sum.

# include<stdio.h>
void main()
{
	int num, i, sum=0;
	printf("Enter No :");
	scanf("%d",&num);

	printf("Even no from 1 to %d are :\n",num);
	
	for (i=1; i<=num; i++)
	{
		if(i%2==0)
		{
		printf("%d\n",i);
		sum=sum+i;
		}
	}
	printf("\n The sum of even natural no upto %d terms : %d\n",num,sum);	

}

//Algorithum
//1) start
//2) declare num, i,sum
//3) accept no
//4) if i=1, i<=num, i++
//5) if i%2=0 then print even no
//6) sum=sum+i
//7) print sum of even no
//8) stop
