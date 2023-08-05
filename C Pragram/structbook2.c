#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
	
};
void printbook (struct book b1);
void main()
{
	struct book b1;
	printf("Enter Title, Author and Book Id :");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);
	printbook (b1);
}
void printbook(struct book b1)
{
	printf("Title =%s\n",b1.title);
	printf("Author =%s\n",b1.author);
	printf("Book Id =%d",b1.bookid);
}
//Algorithum
//1) start
//2) define structure book
//3) declare title, author bookid
//4) go to main function
//5) declare structure book b1
//6) accept title, author, bookid
//7) call function printbook (b1)
//8) declare function printbook (struct book b1)
//9) print title, author, bookid
//10) stop
