//clase para cada nodo de los individuos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace genetico
{
    class Individuo
    {

        public Individuo siguiente;
        public String bites;
        public int x;
        public double aptitud;
        public double fnom;
        public double acumulado;

        public double peso;
        public double ganancia;

        //Constructor
        public Individuo(String _bites)
        {
            siguiente = null; //inicializamos a null debido a que no sabemos a que nodo apuntará
            x = 0;
            aptitud = 0;
            fnom = 0;
            acumulado = 0;
            bites = _bites;
            peso = 0;
            ganancia = 0;
        }

        public Individuo()
        {
            siguiente = null; //inicializamos a null debido a que no sabemos a que nodo apuntará
            x = 0;
            aptitud = 0;
            fnom = 0;
            acumulado = 0;
            bites = "";
            peso = 0;
            ganancia = 0;
        }

    }
}
