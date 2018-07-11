using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace genetico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tipoAlgoritmo = 0; //Algoritmo genetico

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch(tipoAlgoritmo)
            {
                case 0:
                    genetico();
                    break;
                case 1:
                    mochila_1();
                    break;
                default:
                    break;
            }
        } 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Está seguro de salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGenetico_Click(object sender, EventArgs e)
        {
            gbxMochila.Visible = false;
            lblFunción.Visible = true;
            btnTitulo.Text = "ALGORITMO GENÉTICO PURO";
            tipoAlgoritmo = 0;
            btnCalcular.Visible = true;
            lblX.Text = "";
            Mochila.getInstante().reset_2();
        }

        private void btnMochila_Click(object sender, EventArgs e)
        {
            gbxMochila.Visible = true;
            lblFunción.Visible = false; 
            btnTitulo.Text = "PROBLEMA DE LA MOCHILA";
            tipoAlgoritmo = 1;
            btnCalcular.Visible = false;
            btnCapacidadMochila.Visible = true;
            lblX.Text = "";
            
        }

        private void btnResOpt_Click(object sender, EventArgs e)
        {
            if(ofdAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader sr = new StreamReader(ofdAbrirArchivo.FileName))
                {
                    Mochila mochila = Mochila.getInstante();
                    String opcion = sr.ReadLine();
                    
                    mochila.set_respuesta(opcion);

                    if(mochila.check_respuesta())
                    {
                        MessageBox.Show("Respuesta " + opcion + " cargada con exito!");
                        btnGanancias.Visible = true;
                        btnResOpt.Visible = false;
                    }
                    else
                        MessageBox.Show("Error, intente mas tarde");
                    
                }
            }
        }

        private void btnCapacidadMochila_Click(object sender, EventArgs e)
        {            
            if (ofdAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdAbrirArchivo.FileName))
                {
                    Mochila mochila = Mochila.getInstante();

                    Double capacidad = Double.Parse(sr.ReadLine());

                    mochila.set_capacidad(capacidad);

                    if (mochila.check_capacidad())
                    {
                        MessageBox.Show("Capacidad cargada con exito!");
                        btnCapacidadMochila.Visible = false;
                        btnResOpt.Visible = true;
                    }
                    else
                        MessageBox.Show("Error, intente mas tarde");

                }
            }
        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            if (ofdAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdAbrirArchivo.FileName))
                {
                    Mochila mochila = Mochila.getInstante();
                    String[] solution = sr.ReadToEnd().Split('\n');

                    for (int i = 0; i < solution.Length; i++)
                    {
                            mochila.set_peso(solution[i], i);                     
                    }

                    if (mochila.check_inicio())
                    {
                        MessageBox.Show("Pesos cargados con exito!");
                        btnPesos.Visible = false;
                        btnCalcular.Visible = true;
                    }
                    else
                        MessageBox.Show("Error, intente mas tarde");

                }
            }
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            if (ofdAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdAbrirArchivo.FileName))
                {
                    Mochila mochila = Mochila.getInstante();
                    String[] solution = sr.ReadToEnd().Split('\n');

                    for(int i = 0; i < solution.Length; i++)
                    {
                        if (solution[i] != String.Empty)
                        {
                            mochila.set_ganancias(solution[i]);
                        }

                    }


                    if(mochila.check_inicio())
                    {
                        MessageBox.Show("Ganancias cargadas con exito!");
                        btnGanancias.Visible = false;
                        btnPesos.Visible = true;
                        
                    }
                    else
                        MessageBox.Show("Error, intente mas tarde");
                }
            }
        }

        public void genetico()
        {
            String poblacion_s, //numero introducido por el usuario
                   probabilidad_cruce, //numero introducido por el usuario
                   probabilidad_mutacion, //numero introducido por el usuario
                   gen; //numero introducido por el usuario

            double numero_decimal = 0.0, //variable para comparar con digito decimal
                   probabilidad_c, //variable para almacenar la probabilidad de cruce
                   probabilidad_m; //variable para almacenar la probabilidad de mutacion

            int numero_entero = 0, //variable para compara con digito entero
                    poblacion_i, //numero de la poblacion en numero entero
                    generaciones, //numero de generaciones
                    con_gen = 0; //contador de generaciones


            //Validaciones
            if ((tbxCruce.Text != "" && tbxGeneraciones.Text != "") && tbxPoblacion.Text != "")
            {
                poblacion_s = tbxPoblacion.Text;//Console.ReadLine();
                poblacion_i = Int32.Parse(poblacion_s); //convertir String a int base 32
                if (Int32.TryParse(poblacion_s, out numero_entero) && poblacion_i % 2 == 0) //validar población
                {
                    probabilidad_cruce = tbxCruce.Text;
                    probabilidad_c = Double.Parse(probabilidad_cruce);
                    if (Double.TryParse(probabilidad_cruce, out numero_decimal) && (probabilidad_c <= 0.80 && probabilidad_c >= 0.65)) //validar cruce
                    {
                        probabilidad_mutacion = tbxMutacion.Text;
                        probabilidad_m = Double.Parse(probabilidad_mutacion);
                        if (Double.TryParse(probabilidad_mutacion, out numero_decimal) && (probabilidad_m <= 0.01 && probabilidad_m >= 0.001)) //validar cruce
                        {
                            gen = tbxGeneraciones.Text;
                            generaciones = Int32.Parse(gen);
                            if (Int32.TryParse(gen, out numero_entero) && (generaciones > 0)) //validar las generaciones
                            {
                                Operaciones accion = new Operaciones();

                                accion.iniciar_poblacion(poblacion_i); //generar poblacion

                                do
                                {
                                    con_gen++;

                                    accion.calcular_inicio();

                                    accion.cal_final();

                                    accion.generarLosNuevosPadresDeLaPatria(poblacion_i);

                                    accion.cruze(probabilidad_c, poblacion_i);

                                    accion.mute(probabilidad_m);

                                } while (con_gen <= generaciones);

                                lblX.Text = "";

                                string aux = accion.imprimir_ganadores();

                                if (aux != "")
                                {
                                    lblX.Text = "x = " + aux;
                                }
                                else
                                {
                                    MessageBox.Show("No hay resultados optimos en todas las generaciones");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Se debe introducir un numero entero positivo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se debe introducir un numero entre esos rangos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se debe introducir un numero entre esos rangos");
                    }
                }
                else
                {
                    MessageBox.Show("El tamaño debe ser un número entero y par");
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos con la información necesaria");
            }
        }

        public void mochila_1()
        {
            String poblacion_s, //numero introducido por el usuario
                   probabilidad_cruce, //numero introducido por el usuario
                   probabilidad_mutacion, //numero introducido por el usuario
                   gen; //numero introducido por el usuario

            double numero_decimal = 0.0, //variable para comparar con digito decimal
                   probabilidad_c, //variable para almacenar la probabilidad de cruce
                   probabilidad_m; //variable para almacenar la probabilidad de mutacion

            int numero_entero = 0, //variable para compara con digito entero
                poblacion_i, //numero de la poblacion en numero entero
                generaciones, //numero de generaciones
                con_gen = 1; //contador de generaciones

            if ((tbxCruce.Text != "" && tbxGeneraciones.Text != "") && tbxPoblacion.Text != "")
            {
                poblacion_s = tbxPoblacion.Text;//Console.ReadLine();
                if (Int32.TryParse(poblacion_s, out numero_entero)) //validar población
                {
                    poblacion_i = Int32.Parse(poblacion_s); //convertir String a int base 32

                    if(poblacion_i % 2 == 0)
                    {
                        probabilidad_cruce = tbxCruce.Text;
                        if (Double.TryParse(probabilidad_cruce, out numero_decimal)) //validar cruce
                        {
                            probabilidad_c = Double.Parse(probabilidad_cruce);

                            if(probabilidad_c <= 0.80 && probabilidad_c >= 0.65)
                            {
                                probabilidad_mutacion = tbxMutacion.Text;
                                if (Double.TryParse(probabilidad_mutacion, out numero_decimal)) //validar cruce
                                {
                                    probabilidad_m = Double.Parse(probabilidad_mutacion);

                                    if(probabilidad_m <= 0.01 && probabilidad_m >= 0.001)
                                    {
                                        gen = tbxGeneraciones.Text;
                                        if (Int32.TryParse(gen, out numero_entero)) //validar las generaciones
                                        {
                                            generaciones = Int32.Parse(gen);

                                            if(generaciones > 0)
                                            {
                                                Mochila mochila = Mochila.getInstante();

                                                mochila.iniciar_poblacion(poblacion_i);

                                                do
                                                {
                                                    con_gen++;

                                                    mochila.calculo_inicial();

                                                    mochila.cal_final();

                                                    switch(cbOpciones.SelectedIndex)
                                                    {
                                                        case 0:
                                                            mochila.validar_ceros();
                                                            break;
                                                        case 1:
                                                            mochila.validar_uno();
                                                            break;
                                                        case 2:
                                                            mochila.reparacion_aleatoria();
                                                            break;
                                                        case 3:
                                                            mochila.reparacion_ordenada();
                                                            break;
                                                        case 4:
                                                            mochila.reparacion_ordenada_recargado();
                                                            break;
                                                        default:
                                                            break;
                                                    }

                                                    mochila.generarLosNuevosPadresDeLaPatria(poblacion_i);

                                                    mochila.cruze(probabilidad_c, poblacion_i);

                                                    mochila.mute(probabilidad_m);

                                                } while (con_gen <= generaciones);

                                                lblX.Text = "";
                                                //richTextBox1.Text = "";

                                                string aux = mochila.imprimir_ganadores();

                                                if (aux != "")
                                                {
                                                    lblX.Text = aux;
                                                    //richTextBox1.Text = aux;
                                                }

                                                mochila.reset_1();

                                            }
                                            else
                                            {
                                                MessageBox.Show("Se debe introducir un numero entero positivo");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Se debe introducir un numero entero positivo");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Se debe introducir un numero entero positivo");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Se debe introducir un numero entre esos rangos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se debe introducir un numero entre esos rangos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El tamaño de la poblacion debe ser par");
                    }
                }
                else
                {
                    MessageBox.Show("El tamaño de la poblacion debe ser un número entero y par");
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos con la información necesaria");
            }

        }
    }
}
