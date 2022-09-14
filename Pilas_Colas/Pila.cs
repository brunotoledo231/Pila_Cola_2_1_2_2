using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pilas_Colas
{
    public class Pila : IColleccion
    {
        public Stack<int> pila;
        public int contador=0;
       

        public bool EstaVacia()
        {
            bool vacio = true;
            if(pila != null)
                vacio = false;
            return vacio;
        }

        public int Extraer()
        {
            int primero=pila.First();
            pila.Pop();
            return primero;
        }

        public int Primero()
        {
            int primero = pila.First();
            return primero;
        }
        public bool Añadir()
        {
            bool ok = true;

            if(pila == null)
            {
                pila.Push(
                contador++;
                return ok;
            }
            else
            {
                return false;
            }
        }
    }
}
