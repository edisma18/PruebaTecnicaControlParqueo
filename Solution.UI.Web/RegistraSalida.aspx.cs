using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Solution.Bussines.Entities;
using Solution.Bussines.Components;
using Solution.BusinessLogic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Solution.UI.Web
{
    public partial class RegistraSalida : System.Web.UI.Page
    {
        private int Id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
            {
                Id = int.Parse(Request.QueryString["Id"]);
                if (!IsPostBack)
                    LoadCustomer();
            }

            if (!IsPostBack)
                LoadCategories();
            this.txtTime.Text = DateTime.Now.ToString();

            optResident.Enabled = false;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            RegistroEntradasComponent tiempo = new RegistroEntradasComponent();

            //if (Id > 0)
            //{
            //    cust = custc.getCustomer(Id);
            //    cust.Name = txtPlaca.Text;

            //    Category category = custc.GetCategory(
            //        int.Parse(ddlCategories.SelectedValue));
            //    cust.Category = category;
            //    custc.UpdateCustomer(cust);
            //}
            //else
            //{
            // agregar    
            //car = new Carros();
            //car.Placa = txtPlaca.Text;

            ////Category category = custc.GetCategory(
            ////    int.Parse(ddlCategories.SelectedValue));
            ////cust.Category = category;
            //carc.CreateCarro(car);
            ////}
            ///

            Managers mn = new Managers();

            RegistroTiemposParqueo rt = new RegistroTiemposParqueo();
            rt.Placa = txtPlaca.Text;
            rt.HoraSalida = DateTime.Now;
            rt.EstaParqueado = false;

            rt = mn.RegistrarSalida(rt);

            

            if (rt == null)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "AnyValue", "showAlert();", true);

            }
            else
            {
                // Es un residente
                if (optResident.Items[2].Selected)
                    lblPago.Text = "MXN$" + (rt.TiempoAcumulado * 0.5).ToString();
                else
                    lblPago.Text = "MXN$0.00";
            }

            //Response.Redirect("Default.aspx");
        }


        private void LoadCustomer()
        {
            CustomersComponent custc = new CustomersComponent();
            Customers cust = custc.getCustomer(Id);
            txtPlaca.Text = cust.Name;
            //ddlCategories.SelectedValue = cust.Category.Id.ToString();
        }

        private void LoadCategories()
        {
            //CustomersComponent custc = new CustomersComponent();
            //ddlCategories.DataSource = custc.ListCategories();
            //ddlCategories.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefaultMain.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            lblName.Text = string.Empty;
            optResident.ClearSelection();

            Managers mn = new Managers();
            Carros car = new Carros();
            car = mn.GetVehiculo(txtPlaca.Text);

            //ScriptManager.RegisterStartupScript(this, GetType(), "AnyValue", "showAlert();", true);
            ScriptManager.RegisterStartupScript(this, GetType(), "AnyValue", "displayMessage(" + txtPlaca.Text + ");", true);
            if (car != null)
            {
                lblName.Text = " Propietario: " + car.Nombre;
                if (car.EsResidente)
                {
                    optResident.Items[0].Selected = true;
                }
                else
                {
                    optResident.Items[1].Selected = true;
                }

            }
            else
            {
                lblName.Text = " Vehiculo no registrado";
                optResident.Items[2].Selected = true;
            }
        }
    }
}
