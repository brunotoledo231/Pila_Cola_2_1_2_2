﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Colas
{
    interface IColleccion
    {
        bool EstaVacia();
        int Extraer();
        int Primero();
        bool Añadir();
    }
}
