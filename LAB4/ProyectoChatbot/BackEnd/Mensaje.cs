using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace BackEnd
{

    /// <summary>
    /// Esta clase es la que se encarga de crear la estructura log que almacena automaticamente el historial de conversacion, además de
    ///tener las notas de un chatbot especifico y poder sacar estadísticas con la lista de notas obtenida.
    /// </summary>
    public class Mensaje
    {
        public String log;
        public List<int> notasChatbot = new List<int>();

        ///<summary>
        ///Este método saca el promedio dentro de una lista de enteros
        ///</summary>
        ///<returns>
        ///Devuelve un double
        ///</returns>
        public double promedio(List<int> listaPromedio)
        {
            double auxSuma = 0;
            double promedio;
            for (int i = 0; i < listaPromedio.Count; i++)
            {
                auxSuma = auxSuma + listaPromedio[i];
            }
            promedio = auxSuma / listaPromedio.Count;
            return promedio;
        }


        ///<summary>
        ///Este método saca la desviacion estandar dentro de una lista de enteros
        ///</summary>
        ///<returns>
        ///Devuelve un double
        ///</returns>
        public double desviacionEstandar(List<int> listaDesviacion)
        {
            double varianza = 0.0;
            double desviacion = 0.0;

            for (int i = 0; i < listaDesviacion.Count; i++)
            {
                double rango;
                rango = Math.Pow(listaDesviacion[i] - promedio(listaDesviacion), 2);
                varianza = varianza + rango;
            }

            varianza = varianza / listaDesviacion.Count;
            desviacion = Math.Sqrt(varianza);
            return desviacion;

        }
    }
}
