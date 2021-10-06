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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbobj = new DbConnection();
            DataTable dt = dbobj.GetSalesman();
            gvSalesmanDetails.DataSource = dt;
            gvSalesmanDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string salesmanName;
            string salesmanCity;
            string commission;

            salesmanName = txtSalesmanname.Text;
            salesmanCity = txtSalesmancity.Text;
            commission = txtSalesmancommision.Text;

            DbConnection dbobj = new DbConnection();
            dbobj.InsertSalesman(salesmanName, salesmanCity, commission);

            DataTable dt = dbobj.GetSalesman();
            gvSalesmanDetails.DataSource = dt;
            gvSalesmanDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        protected void gvSalesmanDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvSalesmanDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DbConnection dbobj = new DbConnection();
            dbobj.UpdateSalesman(Convert.ToInt32(lblResult.Text), txtSalesmanname.Text, txtSalesmancity.Text, txtSalesmancommision.Text);
            DataTable dt = dbobj.GetSalesman();
            gvSalesmanDetails.DataSource = dt;
            gvSalesmanDetails.DataBind();
        }

        protected void gvSalesmanDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int salesmanid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetSalesmanById(salesmanid);
                txtSalesmanname.Text = dt.Rows[0][1].ToString();
                txtSalesmancity.Text = dt.Rows[0][2].ToString();
                txtSalesmancommision.Text = dt.Rows[0][3].ToString();
                lblResult.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbConnection dbConnection = new DbConnection();
                dbConnection.DeleteSalesmanById(salesmanid);
                DataTable dt = dbConnection.GetSalesman();
                gvSalesmanDetails.DataSource = dt;
                gvSalesmanDetails.DataBind();
            }
        }
    }
}