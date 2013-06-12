using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_ISP20
{
    public class Juego
    {
        private Tablero tablero;
        private Jugador jugador1;
        private Jugador jugador2;

        public Juego()
        {
            tablero = new Tablero();
            jugador1 = new Jugador("X");
            jugador2 = new Jugador("0");
        }
        public void PintarTablero()
        {
            //limpia el tablero
            tablero.Limpiar();
            // estamos recorriendo las fichas del jugador1 y 
            //va gabrando las posiciones del tablero 
            foreach (DictionaryEntry ficha in jugador1.fichas)
            {
                //el tipo de ficha del jugador1
                tablero.posiciones[ficha.Value] = jugador1.tipo_ficha + ficha.Key.ToString();
            }
            // fichas es de tipo dictionary entry(entrada de diccionario)
            // usamos ficha para saber la posicion que tiene definida ese jugador en sus fichas
            foreach (DictionaryEntry ficha in jugador2.fichas)
            {
                tablero.posiciones[ficha.Value] = jugador2.tipo_ficha+ficha.Key.ToString();
            }
            //tablero.Marcar(jugador, pos_elegida)
            // llamamos al metodo pintar de la clase tablero. 
            tablero.Pintar();
        }
        public int SeleccionarFicha (int jugador_actual)
        {
            int ficha_a_mover = 0;
            Console.Write("Jugador {0}: Ingrese el nro de ficha a mover: ", jugador_actual);
            //obtenemos una variable llamada posicion elegida
            // toma esa posicion y la convierte en entera
            //intenta leer y convertir a int
            try
            {
                ficha_a_mover = Convert.ToInt32(Console.ReadLine());
            }
            //si esta mal da error y llama de nuevo al metodo
            catch
            {
                Console.WriteLine("Error, Valor Incorrecto, presione una tecla para continuar");
                Console.ReadKey();
                SeleccionarFicha(jugador_actual);
            }
            return ficha_a_mover;
        }
        public void Jugar(int jugador, int nroficha, int pos_elegida)
        {
            // almacenamos en cada uno de los jugadores las posiciones elegidas
            if ( jugador == 1)
                jugador1.fichas[nroficha] = pos_elegida ;
            else
                jugador2.fichas[nroficha] = pos_elegida;
            
        }
    }
}
