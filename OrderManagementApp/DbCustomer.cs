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
        public void InsertCustomer(string customerName,string city,string grade,string salesmanId)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("insert into customer values('" + customerName + "','" + city + "'," + grade + "," +salesmanId+ ")", sqlconnection);
            sqlconnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }

        public DataTable GetCustomer()
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("select * from customer", sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = sqlcommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlconnection.Close();
            return dt;
        }

        public void UpdateCustomer(int customerId, string customerName, string city, string grade,string salesmanId)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("update customer set cust_name='" + customerName + "',city='" + city + "',grade=" + grade + ",salesman_id="+salesmanId+" where customer_id=" + customerId + "", sqlconnection);
            sqlconnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }

        public DataTable GetCustomerById(int customerId)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("select * from customer where customer_id=" + customerId + "", sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = sqlcommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlconnection.Close();
            return dt;
        }

        public void DeleteCustomerById(int customerId)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("delete from customer where customer_id=" + customerId + "", sqlconnection);
            sqlconnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }
    }
}