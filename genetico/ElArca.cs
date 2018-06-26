//Nodos que almacenarán el elemento mas optimo de cada generacion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace genetico
{
    class ElArca
    {

        public String binario;
        public int x;
        public double aptitud;
        public ElArca siguiente;

        public double ganancia;
        public double peso;

        public ElArca(String _binario, int _x, double _aptitud)
        {
            siguiente = null;

            binario = _binario;
            x = _x;
            aptitud = _aptitud;
        }

        public ElArca(String _combinacion, double _ganancia, double _peso)
        {
            peso = _peso;
            ganancia = _ganancia;
            binario = _combinacion;
        }

    }
}
