using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication3
{
    public class DbConnection
    {
        public void InsertSalesman(string salesmanName,string city,string commission)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("insert into salesman values('" + salesmanName + "','" + city + "'," + commission + ")", sqlconnection);
            ExecuteQuery("insert into salesman values('" + salesmanName + "','" + city + "'," + commission + ")");

        }
        public void UpdateSalesman(int salesmanId,string salesmanName, string city, string Commission)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("update salesman set name='"+salesmanName+"',city='"+city+"',commission="+Commission+" where salesman_id="+salesmanId+"", sqlconnection);
            ExecuteQuery("update salesman set name='" + salesmanName + "',city='" + city + "',commission=" + Commission + " where salesman_id=" + salesmanId + "");
        }
        public void DeleteSalesmanById(int salesmanId)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("delete from salesman where salesman_id=" + salesmanId + "", sqlconnection);
            ExecuteQuery("delete from salesman where salesman_id=" + salesmanId + "");
        }
        public DataTable GetSalesman()
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("select * from salesman", sqlconnection);
            DataTable dt = ExecuteQuery("select * from salesman");
            return dt;
        }
        public DataTable GetSalesmanById(int salesmanId)
        {
            //SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            //SqlCommand sqlcommand = new SqlCommand("select * from salesman where salesman_id="+salesmanId+"", sqlconnection);
            DataTable dt = ExecuteQuery("select * from salesman where salesman_id=" + salesmanId + "");
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

    }
}