using System;
using System.Collections.Generic;
using System.Drawing;               //libreria agregada para poder dibujar
using System.Drawing.Drawing2D;     //libreria agregada para poder dibujar
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class CVertice
    {
        //atributos
        public string Valor; //valor que se almacena representa el nodo
        public List<CArco> ListaAdyacencia;  //lista de adyacencia del nodo

        /* Los diccionarios representan una coleccion de claves y valores, El primer parametro representa el tipo de las claves del
         * el segundo el tipo de los valores del diccionario
         * 
         * Esat clas enos sirve para definir los nodos
         */

        Dictionary<string, short> _banderas;
        Dictionary<string, short> _banderas_predeterminado;

        //Propiedades
        public Color Color
        {
            get { return color_nodo; }
            set { color_nodo = value; }
        }

        public Color FontColor
        {
            get { return color_fuente; }
            set { color_fuente = value; }
        }

        public Point Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }

        public Size Dimensiones
        {
            get { return Dimensiones; }
            set
            {
                radio = value.Width / 2;
                Dimensiones = value;
            }
        }

        public string nombre { get; internal set; }

        static int size = 35; //tamaño del nodo
        Size dimensiones;
        Color color_nodo;     //color definido para el nodo
        Color color_fuente;   //color definido para la fuente del nombre del nodo 
        Point _posicion;      //donde se dibujara el nodo
        int radio;            //radio del objeto que representa el nodo

        //metodos

        // Constructor de la clase, recibe como parametro el nombre del nodo (el valor que tendra)
        public CVertice(string Valor)
        {
            this.Valor = Valor;
            this.ListaAdyacencia = new List<CArco>();
            this._banderas = new Dictionary<string, short>();
            this._banderas_predeterminado = new Dictionary<string, short>();
            this.Color = Color.Green;                   //color del nodo
            this.Dimensiones = new Size(size, size);    //definimos las dimensiones del circulo
            this.FontColor = Color.White;               //color fde la fuente
        }

        public CVertice(): this("") { }  //constructor por default
        public CVertice(CVertice pElemento) : this(" ") { }      //Constructor por defecto (sin parametros)


        // Metodos para dibujar el nodo
        public void DibujarVertice(Graphics g)
        {
            SolidBrush b = new SolidBrush(this.color_nodo);

            //definimos donde dibujaremos el nodo
            Rectangle areaNodo = new Rectangle(this._posicion.X - radio, this._posicion.Y - radio,
                this.dimensiones.Width, this.dimensiones.Height);

            g.FillEllipse(b, areaNodo);

            g.DrawString(this.Valor, new Font("Times New Roman", 14), new SolidBrush(color_fuente),
                this._posicion.X, this._posicion.Y,
                new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                }
                );
            g.DrawEllipse(new Pen(Brushes.Black, (float)1.0), areaNodo);
            b.Dispose();            //para liberar los recursos utilizados por el objeto
        }

        //metodo para dibujar los arcos
        public void DibujarArco(Graphics g)
        {
            float distancia;
            int difY, difX;
            foreach (CArco arco in ListaAdyacencia)
            {
                difX = this.Posicion.X - arco.nDestino.Posicion.X;
                difY = this.Posicion.Y - arco.nDestino.Posicion.Y;

                distancia = (float)Math.Sqrt(difX * difX + difY * difY);

                AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
                bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;


                g.DrawLine(new Pen(new SolidBrush(arco.color), arco.grosor_flecha)
                {
                    CustomEndCap = bigArrow,
                    Alignment = PenAlignment.Center
                },
                    _posicion,
                    new Point(arco.nDestino.Posicion.X + (int)(radio * difX / distancia),
                    arco.nDestino.Posicion.Y + (int)(radio * difY / distancia)
                   )
                );

                g.DrawString(
                    arco.peso.ToString(),
                    new Font("Times New Roman", 12),
                    new SolidBrush(Color.White),
                    this._posicion.X - (int)(difX / 3),
                    this._posicion.Y - (int)(difY / 3),
                    new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Far
                    }

                );
            }
        }
        //metodos para detectar posicio en el panel donde se dibujara el nodo
        public bool DetectarPunto(Point p)
        {
            GraphicsPath posicion = new GraphicsPath();

            posicion.AddEllipse(new Rectangle(this._posicion.X - this.dimensiones.Width / 2,
                                            this._posicion.Y - this.dimensiones.Height / 2,
                                            this.dimensiones.Width, this.dimensiones.Height));
            bool retval = posicion.IsVisible(p);
            posicion.Dispose();
            return retval;
        }
        public
        override string ToString()
        {
            return this.Valor;
        }
    }
}
