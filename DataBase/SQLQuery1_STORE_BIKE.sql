CREATE TABLE stores (
	store_id INT IDENTITY (1, 1) PRIMARY KEY,
	store_name VARCHAR (255) NOT NULL,
	phone VARCHAR (25),
	email VARCHAR (255),
	street VARCHAR (255),
	city VARCHAR (255),
	state VARCHAR (10),
	zip_code VARCHAR (5)
);

insert into stores(store_name,phone,email,street,city,state,zip_code) values ('mana','1234567890','mana@gmail.com',
'sadar','nagpur','maharastra','4400')
select * from stores
insert into stores(store_name,phone,email,street,city,state,zip_code) values ('dhanush','2234567890',
'd@gmail.com','sadar','nagpur','maharastra','4400')



create table staff10(staff_id int identity primary key,
fname varchar(20) not null,
lname varchar(20) not null,
email varchar (50) not null,
phone varchar(25),
active int not null,
store_id int not null,
manager_id int,
foreign key (store_id) references stores (store_id)
on delete cascade on update cascade)

insert into staff10 values ('pooja','zilpe','p@gmail','702045',1,1,1)
insert into staff10 values ('kareena','likhar','k@gmail','703045',1,2,2)
insert into staff10 values ('chandrima','ghosh','c@gmail','704545',1,3,2)
insert into staff10 values ('Akash','gautam','a@gmail','707845',1,4,3)

select * from staff10

create table categories(cid int identity (1,1) primary key,
cname varchar(20) not null )

insert into categories values ('electric bike')
insert into categories values ('children bike')
insert into categories values ('comfort')

select * from categories

create table brands(bid int identity(1,1) primary key,
bname varchar(20) not null)

insert into brands values ('Hero')
insert into brands values ('Heller')
insert into brands values ('Electra')

select * from brands

create table products(pid int identity (1,1) primary key,
pname varchar(20) not null,
bid int  not null,
cid int not null,
myear int not null,
price dec(10,2) not null,
foreign key (cid) references categories (cid)
on delete cascade on update cascade,
foreign key (bid) references brands (bid)
on delete cascade on update cascade)

insert into products values('front wheel',1,1,2022,500)
insert into products values('engine oil',2,2,2023,50)
insert into products values('numberplate',3,3,2023,100)
select * from products 

create table customers(custid int identity (1,1) primary key,
fname varchar(20) not null,
lname varchar(20) not null,
phone varchar(20),
email varchar (20) not null,
street varchar (50),
city varchar(20),
state varchar (20),
pcode varchar (20))

insert into customers values ('ayushi','tale','70208956','aa@gmail.com',
'chandan nagar','nagpur','mah','441110')
insert into customers values ('priya','tale','70276956','pi@gmail.com',
'vaishali nagar','nagpur','mah','441110')
select * from customers

create table orders(ordid int identity (1,1) primary key,
custid int,ordstatus int not null,
-- Order status: 1 = Pending; 2 = Processing; 3 = Rejected; 4 = Completed
orddate date not null,
redate date not null,
shippedate date, store_id int null,staff_id int,foreign key (custid) references customers
(custid) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (store_id) 
        REFERENCES stores (store_id) 
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (staff_id) 
        REFERENCES staff10 (staff_id) 
        ON DELETE NO ACTION ON UPDATE NO ACTION
);
 insert into orders values(1,2,'2022-09-11','2022-10-23','2022-11-25',1,1)
 insert into orders values(1,2,'2023-09-11','2023-10-23','2023-11-25',2,2)
 insert into orders values(1,2,'2023-03-11','2023-11-23','2023-12-25',1,1)
 select*from orders

 CREATE TABLE order_items(
	ordid INT,
	item_id INT,
	pid INT NOT NULL,
	quantity INT NOT NULL,
	price DECIMAL (10, 2) NOT NULL,
	discount DECIMAL (4, 2) NOT NULL DEFAULT 0,
	PRIMARY KEY (ordid, item_id),
	FOREIGN KEY (ordid) 
        REFERENCES orders (ordid) 
		        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (pid) 
        REFERENCES products (pid) 
        ON DELETE CASCADE ON UPDATE CASCADE
);
insert into order_items values (1,1,1,2,110,10)
insert into order_items values (2,2,2,3,150,15)
insert into order_items values (3,3,3,4,170,17)

select * from order_items

CREATE TABLE stocks (
	store_id INT,
	pid INT,
	quantity INT,
	PRIMARY KEY (store_id, pid),
	FOREIGN KEY (store_id) 
        REFERENCES stores (store_id) 
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (pid) 
        REFERENCES products (pid) 
        ON DELETE CASCADE ON UPDATE CASCADE)

		insert into stocks values (1,1,5)
		insert into stocks values (2,2,10)
		insert into stocks values (1,2,55)
		select * from stocks

		select * from stores
		select * from staff10
		select * from categories
		select * from brands
		select * from products 
		select * from customers
		select * from orders
		select * from order_items
		select * from stocks
