create table TableProductGSTDetail(Product_GST_ID int primary key, GstDetail_Name varchar (500),
CGST decimal,SGST decimal,IGST decimal)

insert into TableProductGSTDetail values (1,'Laptop',100.00,120.00,130.00),
(2,'Mobile',101.00,121.00,131.00),
(3,'Printer',102.00,122.00,132.00)

create table TableProductCategory (Product_Category_id int primary key, Product_Type_Name varchar(500),
Product_GSt_ID int foreign key(Product_GST_ID) references TableProductGSTDetail(Product_GST_ID))

insert into TableProductCategory values (11,'kayboard',1),(12,'Mouse',2),(13,'Monitor',3)

create table TableProduct(ProductId int primary key,ProductTypeId int,ProductName varchar(500))

insert into TableProduct values (21,31,'Pen'),(22,32,'Pencile'),(23,33,'Powder')

create table TableInvoiceDetails(Invoice_Detail_Id int primary key,
Customer_Name varchar(500),Customer_Contact varchar(15),Product_Category_id int foreign key (Product_Category_id)
references TableProductCategory(Product_Category_id), ProductId int foreign key(ProductId)
references TableProduct(ProductId),Residential_Type_Id int,Invoice_Date datetime,Quantity decimal,
Price decimal,CGST decimal,SGST decimal,IGST decimal,CGST_value decimal,SGST_Value decimal,
IGST_Value decimal,TotalAmount decimal)

insert into TableInvoiceDetails values (50,'Pooja','702045',11,21,60,'2023-10-24',2,50000,100.00,120.00,130.00,105.00,125.00,135.00,60000),
(51,'Kareena','703045',12,22,60,'2023-10-22',3,40000,101.00,121.00,131.00,106.00,126.00,136.00,70000)

select * from TableProductGSTDetail
select * from TableProductCategory
select* from TableProduct
select * from TableInvoiceDetails