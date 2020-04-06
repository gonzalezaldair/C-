using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace appLineasTelefonicasPOO
{
    public partial class Form1 : Form
    {
        private Empresa empresa;
        public Form1()
        {
            empresa = new Empresa();
            InitializeComponent();
        }


        private void btnLinea1_Click(object sender, EventArgs e)
        {
            agregarLlamada(1);
        }

        

        private void btnLinea2_Click(object sender, EventArgs e)
        {
            agregarLlamada(2);
        }

        private void btnLinea3_Click(object sender, EventArgs e)
        {
            agregarLlamada(3);
        }

        private void actualizar(int linea,double pCostoLlamadas, int pTotalLLamadas, int pTotalMinutos)
        {
            if(linea == 1)
            {
                labbelLinea1.Text = pCostoLlamadas.ToString();
                cajaLlamadasLinea1.Text = pTotalLLamadas.ToString();
                cajaMinutosLinea1.Text = pTotalMinutos.ToString();
            }
            else if(linea == 2)
            {
                labelLinea2.Text = pCostoLlamadas.ToString();
                cajaLlamadasLinea2.Text = pTotalLLamadas.ToString();
                cajaMinutosLinea2.Text = pTotalMinutos.ToString();

            }
            else if(linea == 3)
            {
                labelLinea3.Text = pCostoLlamadas.ToString();
                cajaLlamadasLinea3.Text = pTotalLLamadas.ToString();
                cajaMinutosLinea3.Text = pTotalMinutos.ToString();
            }else if(linea == 0)
            {
                labbelLinea1.Text = "0";
                cajaLlamadasLinea1.Text = "0";
                cajaMinutosLinea1.Text = "0";
                labelLinea2.Text = "0";
                cajaLlamadasLinea2.Text = "0";
                cajaMinutosLinea2.Text = "0";
                labelLinea3.Text = "0";
                cajaLlamadasLinea3.Text = "0";
                cajaMinutosLinea3.Text = "0";
                cajaCostoTotal.Text = "0";
                cajaLlamadasTotal.Text = "0";
                cajaMinutosTotal.Text = "0";
                cajaCostoPromedio.Text = "0";
            }

            cajaCostoTotal.Text = empresa.darTotalCostoLlamadas().ToString();
            cajaLlamadasTotal.Text = empresa.darTotalNumeroLlamadas().ToString();
            cajaMinutosTotal.Text = empresa.darTotalMinutos().ToString();
            cajaCostoPromedio.Text = empresa.darCostoPromedioMinuto().ToString();


        }


        /**
     * Reinicia las líneas telefónicas. <b>post: </b> Se reinició las líneas telefónicas.
     */
        public void reiniciar()
        {
            empresa.reiniciar();
            actualizar(0 ,0.0 ,0 ,0 );
        }


        public void agregarLlamada(int pNumeroLinea)
        {
            string mensaje, titulo;
            int defaultvalue=0;
            object mivalor,valor2;
            mensaje = "Número de minutos hablados: ";
            titulo = "Total Minutos";
            mivalor = Interaction.InputBox(mensaje, titulo, defaultvalue.ToString());

            if ((string)mivalor == "0")
            {
                MessageBox.Show("El valor debe ser mayor a cero", "Advertencia !", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int minutos = int.Parse(mivalor.ToString());
                if(minutos <= 0)
                {
                    MessageBox.Show("El valor debe ser mayor a cero", "Advertencia !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    switch (pNumeroLinea)
                    {
                        case 1:
                            valor2 = Interaction.InputBox("Ingresar :\n Local \n Larga Distancia \n Celular", "Tipo de Llamada", defaultvalue.ToString());
                            if ("Local".Equals(valor2.ToString()))
                            {
                                empresa.agregarLlamadaLocalLinea1(minutos);
                            }
                            else if("Larga Distancia".Equals(valor2.ToString()))
                            {
                                empresa.agregarLlamadaLargaDistanciaLinea1(minutos);
                            }else if("Celular".Equals(valor2.ToString()))
                            {
                                empresa.agregarLlamadaCelularLinea1(minutos);
                            }
                            actualizar(1,empresa.darLinea1().darCostoLlamadas(),empresa.darLinea1().darNumeroLlamadas(),empresa.darLinea1().darNumeroMinutos());
                            break;
                        case 2:
                            valor2 = Interaction.InputBox("Ingresar :\n  Local \n Larga Distancia \n Celular", "Tipo de Llamada", defaultvalue.ToString());
                            if ("Local".Equals(valor2.ToString()))
                            {
                                empresa.agregarLlamadaLocalLinea2(minutos);
                            }
                            else if ("Larga Distancia".Equals(valor2.ToString()))
                            {
                                empresa.agregarLlamadaLargaDistanciaLinea2(minutos);
                            }
                            else if ("Celular".Equals(valor2.ToString()))
                            {
                                empresa.agregarLlamadaCelularLinea2(minutos);
                            }
                            actualizar(2,empresa.darLinea2().darCostoLlamadas(), empresa.darLinea2().darNumeroLlamadas(), empresa.darLinea2().darNumeroMinutos());
                            break;
                        case 3:
                            valor2 = Interaction.InputBox("Ingresar :\n  Local \n Larga Distancia \n Celular", "Tipo de Llamada", defaultvalue.ToString());
                            if ("Local".Equals(valor2.ToString()))
                            {
                                empresa.agregarLlamadaLocalLinea3(minutos);
                            }
                            else if ("Larga Distancia".Equals(valor2.ToString()))
                            {
                                empresa.agregarLlamadaLargaDistanciaLinea3(minutos);
                            }
                            else if ("Celular".Equals(valor2.ToString()))
                            {
                                empresa.agregarLlamadaCelularLinea3(minutos);
                            }
                            actualizar(3,empresa.darLinea3().darCostoLlamadas(), empresa.darLinea3().darNumeroLlamadas(), empresa.darLinea3().darNumeroMinutos());
                            break;
                    }
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }
    }
}
