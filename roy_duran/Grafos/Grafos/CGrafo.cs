using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Grafos
{
    class CGrafo
    {
        public List<CVertice> nodos;     //lista de nodos del grafo

        public CGrafo()                  //Constructor
        {
            nodos = new List<CVertice>();
        }

        //=============================  operaciones basicas  =================================

        //Construye un nodo a apartir de su valor y lo agrega a la lista de nodos

        public CVertice AgregarVertice(string valor)
        {
            CVertice nodo = new CVertice(valor);
            nodos.Add(nodo);
            return nodo;
        }
        //agregar un nodo en la lista de nodos del grafo
        public void AgregarVertice(CVertice nuevonodo)
        {
            nodos.Add(nuevonodo);
        }
        //buscar un nodo en la lista de nodos del garfo
        public CVertice BuscarVertice(string valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }
        //crea una lista a partir de los valores de los nodos de origen y de destino
        public bool AgregarArco(string origen, string nDestino, int peso = 1)
        {
            CVertice vOrigen, vnDestino;
            //si alguno de los nodos no esxiste, se activa una excepcion
            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
                throw new Exception("El nodo " + vOrigen + " no existe dentro del grafo");
            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
                throw new Exception("El nodo " + nDestino + " no existe dentro del grafo");
            return AgregarArco(vOrigen, vnDestino);
        }
        //crea la arista a partir de los nodos de arigen y de destino
        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso = 1)
        {
            if (origen.ListaAdyacencia.Find(v => v.nDestino == nDestino) == null)
            {
                origen.ListaAdyacencia.Add(new CArco(nDestino, peso));
                return true;
            }
            return false;
        }
        //Metodo para dibujar el grafo
        public void DibujarGrafo(Graphics g)
        {
            //dibuja los arcos
            foreach (CVertice nodo in nodos)
                nodo.DibujarArco(g);
            //dibuja los vertices
            foreach (CVertice nodo in nodos)
                nodo.DibujarVertice(g);

        }
        //metodo para detectar si se ha posicionado algun nodo y lo devuelve
        public CVertice DetectarPunto(Point posicionMouse)
        {
            foreach (CVertice nodoActual in nodos)
                if (nodoActual.DetectarPunto(posicionMouse)) return nodoActual;
            return null;
        }
        //metodo para regresar al estado original
        public void ReestablecerGrafo(Graphics g)
        {
            foreach (CVertice nodo in nodos)
            {
                nodo.Color = Color.White;
                nodo.FontColor = Color.Black;
                foreach (CArco arco in nodo.ListaAdyacencia)
                {
                    arco.grosor_flecha = 1;
                    arco.color = Color.Black;
                }
            }
            DibujarGrafo(g);
        }
    }
}
