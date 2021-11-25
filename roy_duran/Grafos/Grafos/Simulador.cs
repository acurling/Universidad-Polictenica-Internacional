using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Simulador : Form
    {

        private CGrafo grafo;
        private CVertice nuevoNodo;
        private CVertice NodoOrigen;
        private CVertice NodoDestino;
        private int var_control = 0;

        //variables para el control de ventanas modales
        private Vertice ventanaVertice; //ventana para agregar los vertices
        public Simulador()
        {
            InitializeComponent();
            grafo = new CGrafo();
            nuevoNodo = null;
            var_control = 0;
            ventanaVertice = new Vertice();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
        private void Pizarra_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                grafo.DibujarGrafo(e.Graphics);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Pizarra_MouseLeave(object sender, EventArgs e)
        {
            Pizarra.Refresh();
        }

        private void Pizara_MouseUp(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 1:     //dibujando arco
                    if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && NodoOrigen != NodoDestino)
                    {
                        if (grafo.AgregarArco(NodoOrigen, NodoDestino))      //se procede a crear la arista
                        {
                            int distancia = 0;
                            NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = distancia;
                        }
                    }
                    var_control = 0;
                    NodoOrigen = null;
                    NodoDestino = null;

                    Pizarra.Refresh();
                    break;
            }
        }

        private void Pizarra_MouseMove(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 2:       //creando nuevo nodo
                    if (nuevoNodo != null)
                    {
                        int posX = e.Location.X;
                        int posY = e.Location.Y;

                        if (posX < nuevoNodo.Dimensiones.Width / 2)
                        {
                            posX = nuevoNodo.Dimensiones.Width / 2;
                        }
                            else if (posX > Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2)
                            {
                                posX = Pizarra.Size.Width - (nuevoNodo.Dimensiones.Width / 2);
                            }

                        if (posY < nuevoNodo.Dimensiones.Width / 2)
                        {
                            posY = nuevoNodo.Dimensiones.Width / 2;
                        }
                            else if (posY > Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2)
                            {
                                posY = Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2;
                            }

                        nuevoNodo.Posicion = new Point(posX, posY);
                        Pizarra.Refresh();
                        nuevoNodo.DibujarVertice(Pizarra.CreateGraphics());
                    }
                    break;
                case 1:         //Dibujar arco
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
                    bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;


                    Pizarra.Refresh();
                    Pizarra.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2)
                    {
                        CustomEndCap = bigArrow},
                        NodoOrigen.Posicion, e.Location);
                    break;
            }
        }

        private void Pizarra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)     //sise ha presionado el boton izquierdo del mouse
            {
                if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                {
                    var_control = 1;        // se utiliza para indicar el estado de la pizarra
                                            //0: sin accion, 1: Dibujando arco, 2: Nuevo vertice
                }
                if (nuevoNodo != null && NodoOrigen == null)
                {
                    ventanaVertice.Visible = false;
                    ventanaVertice.control = false;
                    grafo.AgregarVertice(nuevoNodo);
                    ventanaVertice.ShowDialog();

                    if (ventanaVertice.control)
                    {
                        if (grafo.BuscarVertice(ventanaVertice.txtVertice.Text) == null)
                        {
                            nuevoNodo.Valor = ventanaVertice.txtVertice.Text;
                        }
                        else
                        {
                            MessageBox.Show("El Nodo " + ventanaVertice.txtVertice.Text + " ya existe en el grafo", "Error nuevo nodo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    nuevoNodo = null;
                    var_control = 0;

                    Pizarra.Refresh();
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)    //si se ha preionado el bton derecho del raton
            {
                if (var_control == 0)
                {
                    if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                    {
                        CMSCrearVertice.Text = "Nodo " + NodoOrigen.Valor;
                    }
                    else
                    {
                        Pizarra.ContextMenuStrip = this.CMSCrearVertice;
                    }
                }

            }
        }
        private void eliminarVerticeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarArcoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoVerticeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            {
                nuevoNodo = new CVertice();
                var_control = 2;
            }
        }
    }
}
