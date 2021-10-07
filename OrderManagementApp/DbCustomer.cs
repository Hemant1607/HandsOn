using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public class DbCustomer
    {
        public void InsertCustomer(string customerName,string city,string grade,int salesmanId)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("insert into customer values('" + customerName + "','" + city + "'," + grade + "," +salesmanId+ ")", sqlconnection);
            ExecuteQuery("insert into customer values('" + customerName + "','" + city + "'," + grade + "," + salesmanId + ")");
        }

        public DataTable GetCustomer()
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("select * from customer", sqlconnection);
            DataTable dt = ExecuteQuery("select * from customer");
            return dt;
        }

        public void UpdateCustomer(int customerId, string customerName, string city, string grade,int salesmanId)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("update customer set cust_name='" + customerName + "',city='" + city + "',grade=" + grade + ",salesman_id="+salesmanId+" where customer_id=" + customerId + "", sqlconnection);
            ExecuteQuery("update customer set cust_name='" + customerName + "',city='" + city + "',grade=" + grade + ",salesman_id=" + salesmanId + " where customer_id=" + customerId + "");
            
        }

        public DataTable GetCustomerById(int customerId)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("select * from customer where customer_id=" + customerId + "", sqlconnection);
            DataTable dt = ExecuteQuery("select * from customer where customer_id=" + customerId + "");
            return dt;
        }

        public void DeleteCustomerById(int customerId)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("delete from customer where customer_id=" + customerId + "", sqlconnection);
            ExecuteQuery("delete from customer where customer_id=" + customerId + "");
        }

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlDataAdapter da = new SqlDataAdapter(query, sqlconnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetSalesmanIds()
        {
            DataTable dt = ExecuteQuery("select salesman_id,name from salesman");
            return dt;
        }
    }
}