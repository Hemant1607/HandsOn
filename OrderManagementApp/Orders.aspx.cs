﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbOrders dbobj = new DbOrders();
            DataTable dt = dbobj.GetOrders();
            gvOrdersDetails.DataSource = dt;
            gvOrdersDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string purch_amt;
            string date;
            string customerId;
            string salesmanId;

            purch_amt = txtPurchAmt.Text;
            date = OrderDate.Text;
            customerId = CustomerID.Text;
            salesmanId = SalesmanId.Text;

            DbOrders dbobj = new DbOrders();
            dbobj.InsertOrders(purch_amt,date,customerId, salesmanId);

            DataTable dt = dbobj.GetOrders();
            gvOrdersDetails.DataSource = dt;
            gvOrdersDetails.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbOrders dbobj = new DbOrders();
            dbobj.UpdateOrders(Convert.ToInt32(lblResult.Text), txtPurchAmt.Text, OrderDate.Text, CustomerID.Text, SalesmanId.Text);
            DataTable dt = dbobj.GetOrders();
            gvOrdersDetails.DataSource = dt;
            gvOrdersDetails.DataBind();
        }

        protected void gvOrdersDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int orderno = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbOrders dbOrder = new DbOrders();
                DataTable dt = dbOrder.GetOrdersById(orderno);
                txtPurchAmt.Text = dt.Rows[0][1].ToString();
                OrderDate.Text = dt.Rows[0][2].ToString();
                CustomerID.Text = dt.Rows[0][3].ToString();
                SalesmanId.Text = dt.Rows[0][4].ToString();
                lblResult.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                DbOrders dbOrder = new DbOrders();
                dbOrder.DeleteOrdersById(orderno);
                DataTable dt = dbOrder.GetOrders();
                gvOrdersDetails.DataSource = dt;
                gvOrdersDetails.DataBind();
            }
        }

        protected void gvOrdersDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvOrdersDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}