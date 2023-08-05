#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void main()
{
	struct book b1;
	strcpy(b1.title,"Dotnet");
	strcpy(b1.author,"Pooja");
	b1.bookid=123;
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
//6) strcpy b1.title, strcpy b1.author, b1.bookid
//7) print title, author, bookid
//10) stop
