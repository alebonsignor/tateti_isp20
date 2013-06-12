using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_ISP20
{
    //metodo constructor
    public class Tablero
    {
        //hashtable es una clase que nos permite manejar diccionario de datos//
        public Hashtable posiciones;
        public Tablero()
        {
            posiciones = new Hashtable();
            // incializamos las 9 posiciones con el valor vacio
            for (int i = 1; i < 10; i++)
                posiciones.Add(i, "  ");

        }
        public void Marcar(int jugador, int pos_elegida)
        { 

        }
        public void Limpiar()
        {
            for (int i = 1; i < 10; i++)
                posiciones[i]= "";
        }
        public void Pintar()
        {
            // borra la consola
            Console.Clear();
            // limpio el tablero a cada una de las posiciones con sus respectivos valor
            for (int i = 1; i < 10; i++)
            {

                Console.Write("[{0}]", posiciones[i]);
                //si el modulo i3 es igual a 0 hace eso
                // imprime 3 casilleros y generamos un salto en linea
                if (i%3 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
    }

}
