using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public class DbOrders
    {
        public void InsertOrders(string PurchAmt,string date, string customerId, string salesmanId)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("insert into orders values(" + PurchAmt + ",'" + date + "'," + customerId + "," + salesmanId + ")", sqlconnection);
            sqlconnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }

        public DataTable GetOrders()
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("select * from orders", sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = sqlcommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlconnection.Close();
            return dt;
        }

        public void UpdateOrders(int order_no, string amount, string date, string customerId,string salesmanId)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("update orders set purch_amt=" + amount + ",ord_date='" + date + "',customer_id=" + customerId + ",salesman_id="+salesmanId+" where ord_no=" + order_no + "", sqlconnection);
            sqlconnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }
        public void DeleteOrdersById(int order_no)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("delete from orders where ord_no=" + order_no + "", sqlconnection);
            sqlconnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }

        public DataTable GetOrdersById(int order_no)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("select * from orders where ord_no=" + order_no + "", sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = sqlcommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlconnection.Close();
            return dt;
        }
    }
}