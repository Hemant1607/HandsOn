create database Product
use Product

--Create table Salesman
create table salesman(salesman_id int primary key,
						name varchar(30),	
						city varchar(30),
						commission decimal(5,2))

--Create table customer
create table customer(customer_id int primary key,
						cust_name varchar(30),
						city varchar(30),
						grade int,
						salesman_id int references salesman(salesman_id))

--Create table orders
create table orders(ord_no int primary key,
						purch_amt decimal(8,2),
						ord_date date,
						customer_id int references customer(customer_id),
						salesman_id int references salesman(salesman_id))

--insert values into salesman table
insert into salesman values(5001,'James Hoog','New York',0.15)
insert into salesman values(5002,'Nail Knite','Paris',0.13)
insert into salesman values(5005,'Pit Alex','London',0.11)
insert into salesman values(5006,'Mc Lyon','Paris',0.14)
insert into salesman values(5007,'Paul Adam','Rome',0.13)
insert into salesman values(5003,'Lauson Hen','San Jose',0.12)

--insert values into customer table
insert into customer values(3002,'Nick Rimando','New York',100,5001)
insert into customer values(3007,'Brad Davis','New York',200,5001)
insert into customer values(3005,'Graham Zusi','California',200,5002)
insert into customer values(3008,'Julian Green','London',300,5002)
insert into customer values(3004,'Fabian Johnson','Paris',300,5006)
insert into customer values(3009,'Geoff Cameron','Berlin',100,5003)
insert into customer values(3003,'Jozy Altidor','Moscow',200,5007)
insert into customer (customer_id,cust_name,city,salesman_id) values(3001,'Brad Guzan','London',5005)

--insert values into orders table
insert into orders values(70001,150.5,'2012-10-05',3005,5002)
insert into orders values(70009,270.65,'2012-09-10',3001,5005)
insert into orders values(70002,65.26,'2012-10-05',3002,5001)
insert into orders values(70004,110.5,'2012-08-17',3009,5003)
insert into orders values(70007,948.5,'2012-09-10',3005,5002)
insert into orders values(70005,2400.6,'2012-07-27',3007,5001)
insert into orders values(70008,5760,'2012-09-10',3002,5001)
insert into orders values(70010,1983.43,'2012-10-10',3004,5006)
insert into orders values(70003,2480.4,'2012-10-10',3009,5003)
insert into orders values(70012,250.45,'2012-06-27',3008,5002)
insert into orders values(70011,75.29,'2012-08-17',3003,5007)
insert into orders values(70013,3045.6,'2012-04-25',3002,5001)

--Q1
select * from salesman

--Q2
select name,commission from salesman

--Q3
select ord_date,salesman_id,ord_no,purch_amt from orders

--Q4
select salesman_id from salesman

--Q5
select name,city from salesman where city='Paris'

--Q6
select * from customer where grade=200

--Q7
select ord_no,ord_date,purch_amt from orders where salesman_id=5001

--Q8
select * from customer where grade>100

--Q9
select * from customer where grade>100 and city='New York'

--Q10
select * from customer where grade>100 or city='New York'

--Q11
select * from customer where grade!>100 or city='New York'

--Q12
select * from customer where grade!>100 and city!='New York'

--Q13
select * from orders where (ord_date!='2012-09-10' and salesman_id!>5005) or purch_amt!>1000

--Q14
select * from salesman where commission between 0.10 and 0.12

--Q15
select sum(purch_amt) 'TotalPurchaseAmount' from orders

--Q16
select avg(purch_amt) 'AveragePurchaseAmount' from orders

--Q17
select count(salesman_id) 'Unique SalesPeople' from salesman

--Q18
select count(customer_id) 'Number of Customers' from customer

--Q19
select count(customer_id) 'Number of Customers' from customer where grade is not null

--Q20
select max(purch_amt) 'Maximum Purchase Amount' from orders

--Q21
select min(purch_amt) 'Minimum Purchase Amount' from orders

--Q22
select customer_id,ord_date,max(purch_amt) 'max'
		from orders group by customer_id,ord_date having max(purch_amt)>2000

--Q23
select customer_id,ord_date,max(purch_amt) 'max'
		from orders group by customer_id,ord_date having max(purch_amt) between 2000 and 6000

--Q24
select customer_id,ord_date,max(purch_amt) 'max'
		from orders group by customer_id,ord_date 
		having max(purch_amt) in (2000,3000,5760,6000)

--Q25
select customer_id,max(purch_amt) 'max'
		from orders where customer_id between 3002 and 3007 group by customer_id