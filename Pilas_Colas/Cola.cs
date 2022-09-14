using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Colas
{
    internal class Cola : IColleccion
    {
        public Queue<Cola> cola;

        public bool Añadir()
        {
            bool añadir = true;
            cola.Enqueue(new Cola());
            return añadir;
        }

        public bool EstaVacia()
        {
           bool vacia=true; 
            if(cola.Count > 0)
                vacia=false;
            return vacia;
        }

        public int Extraer()
        {
            cola.Dequeue();
            return cola.Count;
        }

        public int Primero()
        {
            cola.Peek();
            return cola.Count;
        }
    }
}
