using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Solution.Bussines.Components;
using Solution.Bussines.Entities;
using System.Transactions;
using Solution.Data;

namespace Solution.UI.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                        
            if (!IsPostBack)
            {
                LoadCustomers();               
            }
        }

        protected void grdCustomers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                string id = grdCustomers.DataKeys[Convert.ToInt32(e.CommandArgument)].Value.ToString();
                Response.Redirect("UpdateCustomers.aspx?Id=" + id);
            }
            else if (e.CommandName == "Delete")
            {
                int id = int.Parse(e.CommandArgument.ToString());
                delCustomer(id);
                LoadCustomers();
            }
        }

        private static void delCustomer(int id)
        {            
            CustomersComponent cust = new CustomersComponent();
            cust.delCustomer(id);
        }


        private void LoadCustomers()
        {
            CustomersComponent cust = new CustomersComponent();
            grdCustomers.DataSource = cust.ListCustomers();
            grdCustomers.DataBind();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateCustomers.aspx");
        }

        protected void grdCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdCustomers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCustomers.PageIndex = e.NewPageIndex;
            LoadCustomers();
        }

        protected void grdCustomers_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            
        }

        protected void grdCustomers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton l = (LinkButton)e.Row.FindControl("LinkButton1");
                l.Attributes.Add("onclick", "javascript:return " +
                "confirm('Seguro de eliminar el registro  " +
                DataBinder.Eval(e.Row.DataItem, "Id") + " ?')");
            }
        }

        protected void grdCustomers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Console.Write("delete");
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            CustomersComponent cust = new CustomersComponent();
            grdCustomers.DataSource = cust.SelectByName(txtFilterName.Text);
            grdCustomers.DataBind();
        }
      


    }
}
