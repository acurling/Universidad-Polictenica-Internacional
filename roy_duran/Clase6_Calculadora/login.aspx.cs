using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase6_Calculadora
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            ClsUsuario usuario = new ClsUsuario(txtUser.Text, int.Parse(txtClave.Text));

            try
            {
                if (ClsUsuario.GetClave() == 123) //valida solo clave
                                                  //(ClsUsuario.GetNombre().Equals("Roy") && ClsUsuario.GetClave() == 123) valida user y clave
                {
                    Response.Redirect("calculadora.aspx");
                }
                else {
                    lblMensaje.Text = "Usuario o clave incorrecto";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Usuario o clave incorrecto";
            }

        }
    }
}