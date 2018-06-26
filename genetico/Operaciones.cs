//Clase para realizar todas las operaciones con los individuos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace genetico
{
    class Operaciones
    {

        Individuo inicio; //variable que contendrá la lista de individuos
        Padre padres; //variable que contendrá la lista de padres
        ElArca mejores; //variable que contendrá la lista de los resultados

        public Operaciones() //constructor para iniciar lista
        {
            inicio = null;
            padres = null;
            mejores = null;
        }

        public void iniciar_poblacion(int t_poblacion) //realizar paso uno
        {
            Random rand = new Random(); //objeto para generar numeros aleatorios
            String cuerpo; //cuerpo del individuo (Grupo de 8 bits)

            int digito; //entero que estara entre 0 o 1

            for (int i = 0; i < t_poblacion; i++) //for para generar a todos los individuos
            {
                cuerpo = "";
                for(int j = 0; j < 8; j++)
                {
                    digito = rand.Next(0, 2); //generar numero que sera 0 o 1
                    cuerpo += digito.ToString();//añadir el bit al cuerpo
                }

                Individuo nuevo = new Individuo(cuerpo); // generar individuo

                if(inicio == null) //comprobar si es el primer elemento
                {
                    inicio = nuevo; 
                }
                else
                {
                    Individuo aux = inicio; //evitar que la lista se vea afectada

                    while (aux.siguiente != null)
                        aux = aux.siguiente; //conseguimos el ultimo elemento de la lista

                    aux.siguiente = nuevo; //guardamos el individuo
                }

                cuerpo = ""; //vaciamos el cuerpo para el siguiente individuo

            }
        }

        public void calcular_inicio() //calcular x y aptitud
        {
            double apti = 0; //varibale donde se almacenará la aptitud del individuo
            int x = 0;

            String cuerpo = "";
            Individuo aux = inicio;
            ElArca aux_a = mejores;

            if (aux != null)
                apti = aux.aptitud;

            while(aux.siguiente != null)
            {
                aux.x = calcular_x(aux.bites);
                aux.aptitud = calcular_aptitud(aux.x);

                if (aux.aptitud > apti)
                {
                    cuerpo = aux.bites;
                    x = aux.x;
                    apti = aux.aptitud;
                }

                aux = aux.siguiente;
            }

            if (mejores == null)
                mejores = new ElArca(cuerpo, x, apti);
            else
            {
                aux_a = mejores;

                while (aux_a.siguiente != null)
                    aux_a = aux_a.siguiente;

                aux_a.siguiente = new ElArca(cuerpo, x, apti);
            }
        }

        public void cal_final() //calculamos fnom y acumulado
        {
            double facum = 0; //varibale donde se almacenará el acumulado respectivo del individuo

            Individuo calculo = inicio; //auxiliar para asigniar ultimos valores

            while (calculo != null)
            {
                calculo.fnom = calculo.aptitud / get_sumatoria(); //realizar fnom mediante formula por individuo
                facum += calculo.fnom; //calcular acumulado 
                calculo.acumulado = facum; //asignar el acumulado al respectivo individuo

                calculo = calculo.siguiente;
            }
        }

        public void imprimir() //imprimimos la tabla
        {
            Console.Clear(); //limpiar consola

            int num = 1;
            String fx, fnom, acum; //variables para recortar

            if(inicio == null)
                Console.WriteLine("No hay nada");
            else
            { 
                Console.WriteLine("# Individuo   Decimal    f(x)    fnom    Acumulado"); //cabezera de tabla
                Individuo aux = inicio;
                while(aux != null)
                {
                    fx = aux.aptitud.ToString(); //convertimos a String para obtener los primeros 4 caracteres           
                    fnom = aux.fnom.ToString();
                    acum = aux.acumulado.ToString();

                    //imprimir informacion del individuo
                    Console.WriteLine(num.ToString() + " " + aux.bites + "\t" + aux.x + "\t " + Math.Round(aux.aptitud, 2) + "\t" + Math.Round(aux.fnom, 2) + "\t" 
                        + Math.Round(aux.acumulado,2));
                    
                    //recorremos
                    aux = aux.siguiente;
                    num++;

                }
            }
        }

        private int calcular_x(String cuerpo) //convertimos el string a numero binario
        {
            int numero = 0, //variable para obtener sumatoria
                bin = 128; // calculo de binario a decimal
            char bit; //obtener la letra en la posicion del for

            for (int i = 0; i < 8; i++)
            {
                bit = cuerpo[i];

                if (bit == '1')
                    numero += bin;

                bin /= 2;
            }

            return numero; //regresamos el numero en int 32
        }

        private double calcular_aptitud(int x) //calcular aptitud del individuo
        {
            return (Math.Sin((Math.PI * x) / 256)); //regresamos el calculo
        }

        public double get_sumatoria()
        {
            Individuo aux = inicio;
            double sum = 0;

            while(aux != null)
            {
                sum += aux.aptitud;
                aux = aux.siguiente;
            }

            return Math.Round(sum,2);
        } //calculo de la sumatoria de aptitudes


        #region Denise

        private double[] generarNumerosAleatorios(int size)
        {
            double[] array = new double[size];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = Math.Round(random.NextDouble(), 2);

            return array;
        }

        public void generarLosNuevosPadresDeLaPatria(int poblacion)
        {
            if (inicio == null)
                Console.WriteLine("No hay nada");
            else
            {
                double[] valores = generarNumerosAleatorios(poblacion);

               // Console.WriteLine("\n\n\t\t\t\t ---Padres ---\n");
                Individuo aux = inicio;
                Padre auxPadre, nuevo;

                /*Console.Write("Los numeros aleatorios son: ");
                for (int i = 0; i < valores.Length; i++)
                    Console.Write(valores[i] + " ");
                Console.Write("\n\n");*/

                for (int i = 0; i < poblacion; i++)
                {
                    while (aux != null)
                    {
                        if (aux.acumulado > valores[i])
                        {
                            if (padres == null)
                                padres = new Padre(aux.bites);
                            else
                            {
                                nuevo = new Padre(aux.bites);
                                auxPadre = padres;
                                while (auxPadre.siguiente != null)
                                    auxPadre = auxPadre.siguiente;
                                auxPadre.siguiente = nuevo;
                            }

                            break;
                        }
                        aux = aux.siguiente;
                    }
                    aux = inicio;
                }
                //imprimir
                auxPadre = padres;
                /*int n = 1;
                while(auxPadre != null)
                {
                    Console.WriteLine("Padre " + n +"   =   " + calcular_x(auxPadre.bite) + "   ---->   " + auxPadre.bite);

                    n++;
                    auxPadre = auxPadre.siguiente;
                }
                */
            }
        }

        #endregion

        public void cruze(double p_cruce, int poblacion) //metodo para realizar el cruce
        {
            //Console.WriteLine("\n\t\t\t\t ----Cruce: " + p_cruce + " | Nueva poblacion---- ");

            Padre auxPadre = padres,
                  padre1, padre2;

            Individuo aux,
                      nuevo; //nodo para crear a los hijos

            String[] a_cambiar = new String[2]; //string para almacenar los bit a cambiar;
            Random aleatorio = new Random();

            double[] chance = generarNumerosAleatorios(poblacion / 2);
            int uno, dos; //numeros para indice de corte

            inicio = null;

            for (int i = 0; i < chance.Length; i++)
            {
                if (auxPadre != null)
                {
                    //asignacion de la pareja
                    padre1 = auxPadre;
                    auxPadre = auxPadre.siguiente;
                    padre2 = auxPadre;

                    if (chance[0] <= p_cruce) //se va a realizar el cruce
                    {
                        uno = aleatorio.Next(0, 8);
                        dos = aleatorio.Next(0, 8);

                        if (uno < dos)
                        {
                            //obtener bits de los padres
                            for (int j = 0; j < 8; j++)
                            {
                                if (j >= uno && j <= dos)
                                {
                                    a_cambiar[1] += padre1.bite[j];
                                    a_cambiar[0] += padre2.bite[j];
                                }
                                else
                                {
                                    a_cambiar[0] += padre1.bite[j];
                                    a_cambiar[1] += padre2.bite[j];
                                }
                            }
                        }
                        else
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (j <= dos || j >= uno)
                                {
                                    a_cambiar[1] += padre1.bite[j];
                                    a_cambiar[0] += padre2.bite[j];
                                }

                                else
                                {
                                    a_cambiar[0] += padre1.bite[j];
                                    a_cambiar[1] += padre2.bite[j];
                                }
                            }
                        }

                        if (inicio == null)
                        {
                            nuevo = new Individuo(a_cambiar[0]);
                            inicio = nuevo;
                            nuevo.siguiente = new Individuo(a_cambiar[1]);
                        }
                        else
                        {
                            aux = inicio;

                            while (aux.siguiente != null)
                                aux = aux.siguiente;

                            nuevo = new Individuo(a_cambiar[0]);
                            aux.siguiente = nuevo;
                            nuevo.siguiente = new Individuo(a_cambiar[1]);
                        }
                    }
                    else //no hay cruce
                    {
                        if (inicio == null)
                        {
                            nuevo = new Individuo(padre1.bite);
                            inicio = nuevo;
                            nuevo.siguiente = new Individuo(padre2.bite);
                        }
                        else
                        {
                            aux = inicio;

                            while (aux.siguiente != null)
                                aux = aux.siguiente;

                            nuevo = new Individuo(padre1.bite);
                            aux.siguiente = nuevo;
                            nuevo.siguiente = new Individuo(padre2.bite);
                        }
                    }

                    a_cambiar[0] = "";
                    a_cambiar[1] = "";
                    auxPadre = auxPadre.siguiente;
                }
            }

            //eliminamos padres
            padres = null;
            //imprimir nuevo
            /*
            aux = inicio;
            int num = 1;

            while (aux != null)
            {
                Console.WriteLine("Hijo " + num + "° -> " + aux.bites);
                num++;
                aux = aux.siguiente;
            }
            */

        }

        public void mute(double mutacion) //metodo para realizar la mutacion
        {
            Individuo aux = inicio;
            Random aleatorio = new Random();

            String cuerpo = "";

            int total_m = 0;
            double rand;
            char bit;

            while (aux != null)
            {
                for(int i = 0; i < 8; i++)
                {
                    bit = aux.bites[i];
                    rand = aleatorio.NextDouble();
                    if(rand < mutacion)
                    {
                        if (bit == '1')
                            cuerpo += '0';
                        else
                            cuerpo += '1';

                        total_m++;
                    }
                    else
                        cuerpo += bit;
                }
                aux.bites = cuerpo;
                cuerpo = "";
                aux = aux.siguiente;
            }

            //imprimir
            /*
            Console.WriteLine("\t\t\t\t --Mutacion: " + mutacion + " | Mutaciones realizadas: " + total_m + " --");

            int num = 1;
            aux = inicio;

            while(aux != null)
            {
                Console.WriteLine("Individuo " + num + "° -> " + aux.bites);
                num++;
                aux = aux.siguiente;
            }
            */
        }

        public string imprimir_ganadores()
        {
            ElArca aux = mejores;

            if (aux != null)
            {
                double mejor = aux.aptitud;
                int m_x = 0;

                while (aux != null)
                {
                    if (aux.aptitud >= mejor)
                    {
                        mejor = aux.aptitud;
                        m_x = aux.x;
                    }

                    aux = aux.siguiente;
                }
                return m_x + "\nf(x)=" + mejor;
            }
            else
                return "";
        }

    }
}
