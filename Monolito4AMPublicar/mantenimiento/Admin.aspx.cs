using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Monolito4AMPublicar.mantenimiento
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                lbl_session.Text = "Bienvenido al sistema adminitrador:" + Session["admin"].ToString();
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        

        protected void cerrarsesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/Login.aspx");
        }
    }
}