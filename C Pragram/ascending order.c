#include <stdio.h>
//3 integer as input and print the ascending order.
int main() {
    int num1, num2, num3;

    printf("Enter three numbers: ");
    scanf("%d %d %d", &num1, &num2, &num3);

    // Check for the smallest number
    if (num1 <= num2 && num1 <= num3)
	 {
        printf("Ascending order: %d, ", num1);
        if (num2 <= num3) 
		{
            printf("%d, %d\n", num2, num3);
        } else 
		{
            printf("%d, %d\n", num3, num2);
        }
    } 
	else if (num2 <= num1 && num2 <= num3) 
	{
        printf("Ascending order: %d, ", num2);
        if (num1 <= num3) 
		{
            printf("%d, %d\n", num1, num3);
        } else
		 {
            printf("%d, %d\n", num3, num1);
        }
    } 
	else 
	{
        printf("Ascending order: %d, ", num3);
        if (num1 <= num2) 
		{
            printf("%d, %d\n", num1, num2);
        } else 
		{
            printf("%d, %d\n", num2, num1);
        }
    }

    return 0;
}

