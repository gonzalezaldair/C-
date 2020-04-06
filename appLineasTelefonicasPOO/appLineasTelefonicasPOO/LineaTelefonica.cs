using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLineasTelefonicasPOO
{
    class LineaTelefonica
    {
        private int numeroLlamadas;
        private int numeroMinutos;
        private double costoLlamadas;

        public LineaTelefonica()
        {
            numeroLlamadas = 0;
            numeroMinutos = 0;
            costoLlamadas = 0;
        }

        public LineaTelefonica(int numeroLlamadas, int numeroMinutos, double costoLlamadas)
        {
            this.numeroLlamadas = numeroLlamadas;
            this.numeroMinutos = numeroMinutos;
            this.costoLlamadas = costoLlamadas;
        }
        /*
        public int NumeroLlamadas
        {
            get { return numeroLlamadas; }
            set { numeroLlamadas = value; }
        }

        public int NumeroMinutos
        {
            get { return numeroMinutos; }
            set { numeroMinutos = value; }
        }

        public double CostoLlamadas
        {
            get { return costoLlamadas; }
            set { costoLlamadas = value; }
        }*/


        public double darCostoLlamadas()
        {
            return costoLlamadas;
        }

        public int darNumeroLlamadas()
        {
            return numeroLlamadas;
        }

        public int darNumeroMinutos()
        {
            return numeroMinutos;
        }


        public void reiniciar()
        {
            numeroLlamadas = 0;
            numeroMinutos = 0;
            costoLlamadas = 0;
        }

        public void agregarLlamadaLocal(int pMinutos)
        {
            //Una llamada más
            numeroLlamadas += 1;
            //
            //Suma los minutos consumidos
            numeroMinutos += pMinutos;
            //
            //Suma el costo (costo por minuto: 35 pesos)
            costoLlamadas += (pMinutos * 35);
        }

        public void agregarLlamadaLargaDistancia(int pMinutos)
        {
            //Una llamada más
            numeroLlamadas += 1;
            //
            //Suma los minutos consumidos
            numeroMinutos += pMinutos;
            //
            //Suma el costo (costo por minuto: 35 pesos)
            costoLlamadas += (pMinutos * 380);
        }

        public void agregarLlamadaCelular(int pMinutos)
        {
            //Una llamada más
            numeroLlamadas += 1;
            //
            //Suma los minutos consumidos
            numeroMinutos += pMinutos;
            //
            //Suma el costo (costo por minuto: 35 pesos)
            costoLlamadas += (pMinutos * 999);
        }

        public int darTotalNumeroLlamadas()
        {
            return numeroLlamadas;
        }

        public int darTotalMinutos()
        {
            return numeroMinutos;
        }

        public double darTotalCostoLlamadas()
        {
            return costoLlamadas;
        }

        public double darCostoPromedioMinuto()
        {
            return costoLlamadas;
        }

        /*
        public void actualizar(double pCostoLlamadas, int pTotalLLamadas, int pTotalMinutos)
        {
            etiquetaCosto.setText(formatearValor(pCostoLlamadas));
            txtNumeroLlamadas.setText(formatearValorEntero(pTotalLLamadas));
            txtMinutos.setText(formatearValorEntero(pTotalMinutos));
        }*/
    }
}
