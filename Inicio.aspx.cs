using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UPIWEB
{
    public partial class inicio : System.Web.UI.Page
    {
        static float num1 = 0;
        static float num2 = 0;
        static float resultado = 0;
        static string res = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
           

            

            //lresultado.Text = res;

            //if (Dropoperaciones.SelectedIndex == 0)
            //{
            //    resultado = num1 + num2;
            //}
            //else
            //{
            //    resultado = num1 - num2;
            //}

            if (ListBox1.SelectedIndex == 0)
            {
                resultado = num1 + num2;
            }
            if (ListBox1.SelectedIndex ==1)
            {
                resultado = num1 - num2;

            }
            if (ListBox1.SelectedIndex == 2)
            {
                resultado = num1 * num2;

            }
            if (ListBox1.SelectedIndex == 3)
            {
                resultado = num1 / num2;

            }
            lresultado.Text = resultado.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(TxtValor1.Text);
            float num2 = float.Parse(TxtValor2.Text);

            if (RadioSuma.Checked)
            {
                resultado = num1 + num2;
            }
            if(RadioResta.Checked)
            {
                resultado = num1 + num2;

            } if (RadioMulti.Checked)
            {
                resultado = num1 * num2; 
            }
            if (RadioDivi.Checked)
            {
                resultado = num1 / num2;
                res = res + "División: " + resultado.ToString();

            }
            lresultado.Text = res;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(TxtValor1.Text);
            float num2 = float.Parse(TxtValor2.Text);

            if (CheckSuma.Checked)
            {
                resultado = num1 + num2;
                res = res + " Suma: " + resultado.ToString();
            }

            if (CheckResta.Checked)
            {
                resultado = num1 - num2;
                res = res + " Resta:  " + resultado.ToString();
            }
            if (CheckMulti.Checked)
            {
                resultado = num1 * num2;
                res = res + "Multiplicación: " + resultado.ToString();
            }
            if (CheckDivi.Checked)
            {
                resultado = num1 / num2;
                res = res + "División: " + resultado.ToString();
            }
            lresultado.Text = res;

        }
    }
}