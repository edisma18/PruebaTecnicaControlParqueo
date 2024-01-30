using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Solution.Bussines.Entities;
using Solution.Bussines.Components;

namespace Solution.UI.Web
{
    public partial class UpdateCustomers : System.Web.UI.Page
    {
        private int Id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                Id = int.Parse(Request.QueryString["Id"]);
                if(!IsPostBack)
                    LoadCustomer(); 
            }

            if (!IsPostBack)
                LoadCategories();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            CustomersComponent custc = new CustomersComponent();
            Customers cust = null;                        

            if (Id > 0)
            {
                cust = custc.getCustomer(Id);
                cust.Name = txtName.Text;

                Category category = custc.GetCategory(
                    int.Parse(ddlCategories.SelectedValue));
                cust.Category = category;
                custc.UpdateCustomer(cust);
            }
            else
            { 
                // agregar    
                cust = new Customers();
                cust.Name = txtName.Text;

                Category category = custc.GetCategory(
                    int.Parse(ddlCategories.SelectedValue));
                cust.Category = category;
                custc.CreateCustomer(cust);
            }
            Response.Redirect("Default.aspx");
        }


        private void LoadCustomer()
        {
            CustomersComponent custc = new CustomersComponent();
            Customers cust = custc.getCustomer(Id);
            txtName.Text = cust.Name;
            ddlCategories.SelectedValue = cust.Category.Id.ToString();
        }

        private void LoadCategories()
        {
            CustomersComponent custc = new CustomersComponent();
            ddlCategories.DataSource = custc.ListCategories();
            ddlCategories.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
