using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLineasTelefonicasPOO
{
    class Empresa
    {
        //-----------------------------------------------------------------
        // Atributos
        //-----------------------------------------------------------------

        /**
         * Línea telefónica número 1.
         */
        private LineaTelefonica linea1;

        /**
         * Línea telefónica número 2.
         */
        private LineaTelefonica linea2;

        /**
         * Línea telefónica número 3.
         */
        private LineaTelefonica linea3;


        public Empresa()
        {
            linea1 = new LineaTelefonica( );
            linea2 = new LineaTelefonica( );
            linea3 = new LineaTelefonica( );

        }

        /**
         * Retorna la línea 1.
         * @return Línea 1.
         */
        public LineaTelefonica darLinea1()
        {
            return linea1;
        }

        /**
         * Retorna la línea 2.
         * @return Línea 2.
         */
        public LineaTelefonica darLinea2()
        {
            return linea2;
        }

        /**
         * Retorna la línea 3.
         * @return Línea 3.
         */
        public LineaTelefonica darLinea3()
        {
            return linea3;
        }

        public int darTotalNumeroLlamadas()
        {
            return linea1.darNumeroLlamadas() + linea2.darNumeroLlamadas() + linea3.darNumeroLlamadas();
        }

        /**
         * Retorna el total de minutos consumidos.
         * @return Total de minutos de las tres líneas.
         */
        public int darTotalMinutos()
        {
            return linea1.darTotalMinutos() + linea2.darTotalMinutos() + linea3.darTotalMinutos();
        }

        /**
         * Retorna el costo total de las llamadas realizadas.
         * @return Costo total de las tres líneas.
         */
        public double darTotalCostoLlamadas()
        {
            return linea1.darTotalCostoLlamadas() + linea2.darTotalCostoLlamadas() + linea3.darTotalCostoLlamadas();
        }

        /**
         * Retorna el costo promedio de un minuto, según los minutos consumidos. <br>
         * @return Costo promedio por minuto.
         */
        public double darCostoPromedioMinuto()
        {
            return darTotalCostoLlamadas() / darTotalMinutos();
        }

        /**
         * Agrega una llamada local a la línea telefónica 1 <br>
         * <b>post: </b> Se agregó la llamada a la línea 1.
         * @param pMinutos Número de minutos de la llamada. pMinutos > 0.
         */
        public void agregarLlamadaLocalLinea1(int pMinutos)
        {
            linea1.agregarLlamadaLocal(pMinutos);
        }

        /**
         * Agrega una llamada local a la línea telefónica 2. <br>
         * <b>post: </b> Se agregó la llamada a la línea 2.
         * @param pMinutos Número de minutos de la llamada. pMinutos > 0.
         */
        public void agregarLlamadaLocalLinea2(int pMinutos)
        {
            linea2.agregarLlamadaLocal(pMinutos);
        }

        /**
         * Agrega una llamada local a la línea telefónica 3. <br>
         * <b>post: </b> Se agrega la llamada a la línea 3.
         * @param pMinutos Número de minutos de la llamada. pMinutos > 0.
         */
        public void agregarLlamadaLocalLinea3(int pMinutos)
        {
            linea3.agregarLlamadaLocal(pMinutos);
        }

        /**
         * Agrega una llamada de larga distancia a la línea telefónica 1. <br>
         * <b>post: </b> Se agrega la llamada a la línea 1.
         * @param pMinutos Número de minutos de la llamada. pMinutos > 0.
         */
        public void agregarLlamadaLargaDistanciaLinea1(int pMinutos)
        {
            linea1.agregarLlamadaLargaDistancia(pMinutos);
        }

        /**
         * Agrega una llamada de larga distancia a la línea telefónica 2. <br>
         * <b>post: </b> Se agrega la llamada a la línea 2.
         * @param pMinutos Número de minutos de la llamada. pMinutos > 0.
         */
        public void agregarLlamadaLargaDistanciaLinea2(int pMinutos)
        {
            linea2.agregarLlamadaLargaDistancia(pMinutos);
        }

        /**
         * Agrega una llamada de larga distancia a la línea telefónica 3. <br>
         * <b>post: </b> Se agrega la llamada a la línea 3.
         * @param pMinutos Número de minutos de la llamada. pMinutos > 0.
         */
        public void agregarLlamadaLargaDistanciaLinea3(int pMinutos)
        {
            linea3.agregarLlamadaLargaDistancia(pMinutos);
        }

        /**
         * Agrega una llamada a celular a la línea telefónica 1. <br>
         * <b>post: </b> Se agrega la llamada a la línea 1.
         * @param pMinutos Número de minutos de la llamada. pMinutos > 0.
         */
        public void agregarLlamadaCelularLinea1(int pMinutos)
        {
            linea1.agregarLlamadaCelular(pMinutos);

        }

        /**
         * Agrega una llamada a celular a la línea telefónica 2. <br>
         * <b>post: </b> Se agrega la llamada a la línea 2.
         * @param pMinutos Número de minutos de la llamada. pMinutos > 0.
         */
        public void agregarLlamadaCelularLinea2(int pMinutos)
        {
            linea2.agregarLlamadaCelular(pMinutos);
        }

        /**
         * Agrega una llamada a celular a la línea telefónica 3. <br>
         * <b>post: </b> Se agrega la llamada a la línea 3.
         * @param pMinutos Número de minutos de la llamada. pMinutos > 0.
         */
        public void agregarLlamadaCelularLinea3(int pMinutos)
        {
            linea3.agregarLlamadaCelular(pMinutos);
        }

        /**
         * Reinicia todas las líneas telefónicas.
         * <b>post: </b> Se reinició la llamada a la línea 1, 2 y 3.
         */
        public void reiniciar()
        {
            linea1.reiniciar();
            linea2.reiniciar();
            linea3.reiniciar();
        }

        //-----------------------------------------------------------------
        // Puntos de Extensión
        //-----------------------------------------------------------------

        /**
         * Método para la extensión 1.
         * @return Respuesta 1.
         */
        public String metodo1()
        {
            return "Respuesta 1";
        }

        /**
         * Método para la extensión 2.
         * @return Respuesta 2.
         */
        public String metodo2()
        {
            return "Respuesta 2";
        }
    }
}
