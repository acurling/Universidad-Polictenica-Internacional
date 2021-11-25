using System;
using System.Collections.Generic;
using System.Drawing;               //libreria agregada para poder dibujar
using System.Linq;
using System.Text;

namespace Grafos
{
    class CArco
    {
        //atributos
        //nos sirve para definir los arcos o aristas del grafo
        public CVertice nDestino;
        public int peso;            //peso (valor) de cada arco (Arista)
        public float grosor_flecha;
        public Color color;

        //Metodos
        public CArco(CVertice destino) : this(destino, 1)
        {
            this.nDestino = destino;
        }

        public CArco(CVertice destino, int peso)
        {
            this.nDestino = destino;
            this.peso = peso;
            this.grosor_flecha = 2;
            this.color = Color.Red;
        }
    }
}
