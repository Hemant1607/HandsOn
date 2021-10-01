--Q1 
select * from orders 
where 
salesman_id=(select salesman_id from salesman where name='Paul Adam')

--Q2
select * from orders 
where 
salesman_id in (select salesman_id from salesman where city='London')

--Q3
select * from orders 
where 
salesman_id in (select salesman_id from customer where customer_id=3007)

--Q4
select * from orders
where 
purch_amt>(select avg(purch_amt) from orders where ord_date='2012-10-10')

--Q5
select * from orders 
where 
customer_id in (select customer_id from customer where city='New York')

--Q6
select salesman.salesman_id,sum(salesman.commission*orders.purch_amt) 'Commission Earned'
from salesman join orders on salesman.salesman_id=orders.salesman_id 
where city='Paris'
group by salesman.salesman_id

--Q7
select * from customer 
where 
customer_id<((select salesman_id from salesman where name='Mc Lyon')-2001)

--Q8
select grade,count(customer_id) 'Count' from customer
where grade>(select avg(grade) from customer where city='New York')
group by grade