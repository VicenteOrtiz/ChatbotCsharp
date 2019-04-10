using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



///<summary>
///La clase usuario es la que contiene la información relevante de la persona que utiliza el programa
/// </summary>
/// <remarks>
/// Setea el ID del usuario
/// </remarks>

namespace BackEnd
{
    public class Usuario
    {
        private String iD;

        /// <summary>
        /// este metodo setea el id privado de la clase usuario
        /// </summary>
        /// <param name="id">
        /// String que se asignara como ID</param>

        public void set_ID(String id)
        {
            iD = id;
        }

        /**
         * 
         * 
         * @return este método retorna el ID como tipo de dato String.
         */

        
        ///<summary>
        ///este metodo hace publico el atributo iD
        /// </summary>
        /// <returns>
        /// devuelve el atributo iD
        /// </returns>
        public String get_ID()
        {
            return iD;
        }
    }
}
