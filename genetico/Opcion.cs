using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace genetico
{
    class Opcion
    {

        public Opcion siguiente;
        public String combinacion;

        public double pmax;
        public double pen;
        public double peso_total;
        public double ganancia_total;
        public double fnom;
        public double acumulado;

        //public int cant_obj;

        public Opcion()
        {
            siguiente = null;
            combinacion = "";
            pmax = 0;
            pen = 0;
            peso_total = 0;
            ganancia_total = 0;
        }

        public Opcion(String _Combinacion)
        {
            siguiente = null;
            combinacion = _Combinacion;
            pmax = 0;
            pen = 0;
            peso_total = 0;
            ganancia_total = 0;
        }


    }
}
