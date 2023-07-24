#include<stdio.h>
void main()
{
	char ch;
	printf("Enter Character=");
	scanf("%c",&ch);
	switch (ch)
	{
	  case 'a':
	  	case 'e':
	  		case 'i':
	  		case 'o':
	  			case 'u':
	   printf("It is Vowel");
        break;
     default:
	printf("It is  not Vowel");
	break;
	}

	
}
//Algorithum
//1) start
//2) accept character
//3) if character is (a,e,i,o,u  then
//3.1) print "it is vowel"
//4) if character is not between (a,e, i, o, u) then
//4.1 print "it is not vowel"
//5) stop


