using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDoble {
    internal class LEDoble {
        Nodo Primero { get; set; }
        Nodo Ultimo { get; set; }

        //agrega un valor al inicio de LE Doble
        public void AgregaPrimero(int valor) 
        {
            Nodo nuevo = new Nodo(valor);
            if (this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                Nodo prim = this.Primero;
                nuevo.Sig = prim;
                this.Primero = nuevo;
            }
        }

        //agrega un valor al final de LE Doble
        public void AgregaFinal(int valor) 
        {
            Nodo nuevo = new Nodo(valor);
            if (this.Primero == null)
            {
                this.Primero = nuevo;
                this.Ultimo = nuevo;
            }
            else
            {
                this.Ultimo.Sig = nuevo;
                nuevo.Ant = this.Ultimo;
                this.Ultimo = nuevo;
            }
        }  

        //ve valores separados por comas de la LEDoble
        public override string ToString() 
        {
            string listaVag = "";
            Nodo tmp = this.Primero;
            while (tmp != null)
            {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listaVag;
        }
    }
}
