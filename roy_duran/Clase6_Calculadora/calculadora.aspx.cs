using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase6_Calculadora
{
    public partial class calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Bienvenido " + ClsUsuario.GetNombre() + " Hoy es: " + DateTime.Now;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Contactenos.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void rbResta_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            radioButton();
        }

        protected void radioButton() {
            ClsCalculadora calculo = new ClsCalculadora(float.Parse(txtValor1.Text), float.Parse(txtValor2.Text));
            if (rbSuma.Checked)
            {
                calculo.Sumar();
                
            }
            else if(rbResta.Checked)
            {
                calculo.Resar();
   
            }
            lblResultado.Text = Convert.ToString(calculo.respuesta());
        }
    }
}