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
        public void InsertOrders(string PurchAmt,string date, int customerId, int salesmanId)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("insert into orders values(" + PurchAmt + ",'" + date + "'," + customerId + "," + salesmanId + ")", sqlconnection);
            ExecuteQuery("insert into orders values(" + PurchAmt + ",'" + date + "'," + customerId + "," + salesmanId + ")");
        }

        public DataTable GetOrders()
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("select * from orders", sqlconnection);
            DataTable dt = ExecuteQuery("select * from orders");
            return dt;
        }

        public void UpdateOrders(int order_no, string amount, string date, int customerId,int salesmanId)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("update orders set purch_amt=" + amount + ",ord_date='" + date + "',customer_id=" + customerId + ",salesman_id="+salesmanId+" where ord_no=" + order_no + "", sqlconnection);
            ExecuteQuery("update orders set purch_amt=" + amount + ",ord_date='" + date + "',customer_id=" + customerId + ",salesman_id=" + salesmanId + " where ord_no=" + order_no + "");
           
        }
        public void DeleteOrdersById(int order_no)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("delete from orders where ord_no=" + order_no + "", sqlconnection);
            ExecuteQuery("delete from orders where ord_no=" + order_no + "");
        }

        public DataTable GetOrdersById(int order_no)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("select * from orders where ord_no=" + order_no + "", sqlconnection);
            DataTable dt = ExecuteQuery("select * from orders where ord_no=" + order_no + "");
            return dt;
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
        public DataTable GetCustomerIds()
        {
            DataTable dt = ExecuteQuery("select customer_id,cust_name from customer");
            return dt;
        }
    }
}