using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1_1.Interfaces
{
    internal interface IColleccion
    {
        /// <summary>
        /// devuelve true si la colección está vacía y false en caso contrario.
        /// </summary>
        /// <returns></returns>
        bool estaVacia();
        /// <summary>
        /// devuelve y elimina el primer elemento de la colección.
        /// </summary>
        /// <returns></returns>
        object extraer();
        /// <summary>
        /// devuelve el primer elemento de la colección
        /// </summary>
        /// <returns></returns>
        object primero();
        /// <summary>
        /// añade un objeto por el extremo que corresponda, y devuelve true si se ha añadido y false en caso contrario.
        /// </summary>
        /// <returns></returns>
        bool añadir(object elemento);
    }
}
