#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook(struct book *ptr);
void main()
{
	struct book b1;
	printf("Enter Title, AuthorBookid :");
	scanf("%s%s%d",b1.title,b1.author,&b1.bookid);
	printbook(&b1);
}
void printbook(struct book *ptr)
{
	printf("Title =%s\n",ptr->title);
	printf("Author =%s\n",ptr->author);
	printf("Book Id =%d",ptr->bookid);
}
//Algorithum
//1) start
//2) define structure book
//3) declare title, author bookid
//4) go to main function
//5) declare structure book b1
//6) accept title, author, bookid
//7) call function printbook (b1)
//8) declare pointer printbook (struct book *ptr)
//9) print title, author, bookid
//10) stop
