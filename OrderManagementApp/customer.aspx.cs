using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCustomer dbobj = new DbCustomer();
            DataTable dt = dbobj.GetCustomer();
            gvCustomerDetails.DataSource = dt;
            gvCustomerDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string customerName;
            string customerCity;
            string Grade;
            string salesmanId;

            customerName = CustomerName.Text;
            customerCity = City.Text;
            Grade = grade.Text;
            salesmanId = SalesmanId.Text;

            DbCustomer dbobj = new DbCustomer();
            dbobj.InsertCustomer(customerName, customerCity, Grade,salesmanId);

            DataTable dt = dbobj.GetCustomer();
            gvCustomerDetails.DataSource = dt;
            gvCustomerDetails.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbCustomer dbobj = new DbCustomer();
            dbobj.UpdateCustomer(Convert.ToInt32(lblResult.Text),CustomerName.Text, City.Text, grade.Text, SalesmanId.Text);
            DataTable dt = dbobj.GetCustomer();
            gvCustomerDetails.DataSource = dt;
            gvCustomerDetails.DataBind();
        }

        protected void gvCustomerDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int customerid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbCustomer dbCustomer = new DbCustomer();
                DataTable dt = dbCustomer.GetCustomerById(customerid);
                CustomerName.Text = dt.Rows[0][1].ToString();
                City.Text = dt.Rows[0][2].ToString();
                grade.Text = dt.Rows[0][3].ToString();
                SalesmanId.Text = dt.Rows[0][4].ToString();
                lblResult.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbCustomer dbCustomer = new DbCustomer();
                dbCustomer.DeleteCustomerById(customerid);
                DataTable dt = dbCustomer.GetCustomer();
                gvCustomerDetails.DataSource = dt;
                gvCustomerDetails.DataBind();
            }
        }

        protected void gvCustomerDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvCustomerDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}