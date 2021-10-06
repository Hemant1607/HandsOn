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
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("insert into salesman values('" + salesmanName + "','" + city + "'," + commission + ")", sqlconnection);
            sqlconnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();

        }
        public void UpdateSalesman(int salesmanId,string salesmanName, string city, string Commission)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("update salesman set name='"+salesmanName+"',city='"+city+"',commission="+Commission+" where salesman_id="+salesmanId+"", sqlconnection);
            sqlconnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }
        public void DeleteSalesmanById(int salesmanId)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("delete from salesman where salesman_id=" + salesmanId + "", sqlconnection);
            sqlconnection.Open();
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
        }
        public DataTable GetSalesman()
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("select * from salesman", sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = sqlcommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlconnection.Close();
            return dt;
        }
        public DataTable GetSalesmanById(int salesmanId)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=LAPTOP-N42Q6CD6; Initial Catalog=Product; Integrated Security= True");
            SqlCommand sqlcommand = new SqlCommand("select * from salesman where salesman_id="+salesmanId+"", sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = sqlcommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlconnection.Close();
            return dt;
        }

    }
}