using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using problema1_1.Interfaces;

namespace problema1_1.Implementaciones;

internal class Pila : IColleccion
{
    object[] lista;
    int cantidad_elementos = 100;
    public Pila()
    {
        
        lista = new object[cantidad_elementos];
    }
    public bool añadir(object elemento)
    {
        bool flag = false;
        for (int i = 0; i < cantidad_elementos; i++) {
            if (lista[i]==null)
            {
                lista[i] = elemento;
                flag = true;
                break;
            }
        }
        return flag;
    }

    public bool estaVacia()
    {
        bool flag = true;
        for (int i = 0; i < cantidad_elementos; i++)
        {
            if (lista[i] != null)
            {
                flag = false;
                break;
            }
        }
        return flag;
    }

    public object extraer()
    {
        object ultimo_elemento = null;
        for (int i = 0; i < cantidad_elementos; i++)
        {

            if (lista[i] != null)
            {
                lista[i - 1] = null;
                break;
            }
            if (lista[i] != null)
            {
                ultimo_elemento = lista[i];
                lista[i] = null;
                break;
            }
        }


        for (int i = 0; i < cantidad_elementos; i++)
        {
            if (lista[i] != null)
            {
                lista[i - 1] = null;
                break;
            }
            if (lista[i] != null)
            {
                ultimo_elemento = lista[i];
                lista[i] = null;
                break;
            }
        }
        return ultimo_elemento;
    }

    public object primero()
    {
        object ultimo_elemento = null;
        for (int i = 0; i < cantidad_elementos; i++)
        {
            if (lista[0]==null)
            {
                ultimo_elemento = null;
                break;
            }
            else
            {
                if (lista[i] == null)
                {
                    ultimo_elemento = lista[i - 1];
                    break;
                }
            }
        }
    }
}
