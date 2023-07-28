#include<stdio.h>
void sayhello()
{
	printf("Hello\n");
}
void main()
{
	printf("Calling function\n");
	sayhello();
	printf("Back in main function\n");
	sayhello();
	printf("Bye");
}

//Algorithum
//1) start
//2) define the function sayhello
//3) print hello, go to main function
//4) in main function print calling function
//5) call function sayhello
//6) print back in main function
//6)  main function say hello
//7) stop

