using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_ISP20
{
    public class Jugador
    {
        // declaracion de las propiedades 
        public Hashtable fichas;
        public string tipo_ficha;
       // metodo constructor de la clase Jugador
        public Jugador(string tipoficha)
        {
            //inicializamos la propiedad fichas
            fichas = new Hashtable();
            fichas.Add(1,0);
            fichas.Add(2,0);
            fichas.Add(3,0);
            // definimos que el jugador tiene tres fichas y las fichas tiene posicion 0
            tipo_ficha = tipoficha;
        }
    }
}
