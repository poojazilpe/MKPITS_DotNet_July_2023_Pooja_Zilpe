#include<stdio.h>
void main() 
{
	char customer_name[10],product_name[10];
int price,quantity,total_amount,discount;
printf("Enter Customer Name =");
scanf("%s",&customer_name);
printf("Enter Product Name =");
scanf("%s",&product_name);
printf("Enter Price =");
scanf("%d",&price);
printf("Enter Quantity =");
scanf("%d",&quantity);
total_amount=price*quantity;

if(total_amount>=1000)
{
	discount=total_amount*0.40;
}
else if(total_amount>=500)
{
	discount=total_amount*0.25;
}
else 
{
  discount=total_amount*0.10;  
}
printf("Customer_Name =%s\n",customer_name);
printf("Product_Name =%s\n",product_name);
printf("Price=%d\n",price);
printf("Quantity = %d\n",quantity);
printf("Total_Amount =%d\n",total_amount);
printf("Discount =%d",discount);

}

// Algorithum
//1) start
//2) accept customer name,product name,price and quantity
//3) if total amount is greater than equal to 1000
//    3.1 print "Discount is 40%"
//4) else if total amount is greater than equal to 500
//    4.1 print "Discount is 25%"
//5) else print "Discount is 10%"
//6) stop
