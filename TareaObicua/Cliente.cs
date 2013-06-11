using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    class Cliente
    {

        private string nombre, apellido, direccion, localidad, telefono;
        public int codigo;
        private DateTime FechaNac;

        private void CapturarNombre()
        {
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            if (nombre == "")
            {
                Console.WriteLine("Error al ingresar el nombre. Intente nuevamente");
                CapturarNombre();
            }
        }

        private void CapturarApellido()
        {
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            if (apellido == "")
            {
                Console.WriteLine("Error al ingresar apellido. Intente nuevamente");
                CapturarApellido();
            }
        }

        private void CapturarDireccion()
        {
            Console.Write("Ingrese su dirección: ");
            direccion = Console.ReadLine();
            if (direccion == "")
            {
                Console.WriteLine("Error al ingresar direccion. Intente nuevamente");
                CapturarDireccion();
            }
        }

        private void CapturarLocalidad()
        {
            Console.Write("Ingrese su localidad: ");
            localidad = Console.ReadLine();
            if (localidad == "")
            {
                Console.WriteLine("Error al ingresar localidad. Intente nuevamente");
                CapturarLocalidad();
            }
        }

        private void CapturarTelefono()
        {
            Console.Write("Ingrese su teléfono: ");
            telefono = Console.ReadLine();
            if (telefono == "") 
            {
                Console.WriteLine("Error al ingresar telefono. Intente nuevamente");
                CapturarTelefono();
            }
        }

        private void CapturarCodigo()
        {
            Console.Write("Ingrese su Codigo: ");
            try
            {
                codigo = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error al ingresar su codigo. Intente nuevamente");
                CapturarCodigo();
            }
        }

        private void CapturarFechaNac()
        {
            Console.Write("Ingrese su Fecha de Nacimiento: ");
            // intenta convertir a fecha lo que escribe el usuario
            try
            {
                FechaNac = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            //si la conversion fallo muestra en consola "" vuelve a llamar al metodo
            {
                Console.WriteLine("Error al ingresar la fecha de nacimiento. Intente nuevamente");
                CapturarFechaNac();
            }
        }

        public string ImprimirFicha()
        {
            string ficha = "FICHA PERSONAL CLIENTE";
            ficha += "\nNombre: " + nombre;
            ficha += "\nApellido: " + apellido;
            ficha += "\nDireccion: " + direccion;
            ficha += "\nLocalidad: " + localidad;
            ficha += "\nTelefono: " + telefono;
            ficha += "\nCodigo: " + codigo;
            ficha += "\nFechaNac:" + FechaNac.Date.ToShortDateString();
            return ficha;
        }

        public void CapturarDatos()
        {
            CapturarCodigo();
            CapturarNombre();
            CapturarApellido();
            CapturarDireccion();
            CapturarLocalidad();
            CapturarTelefono();
            CapturarFechaNac();
        }

        private string Presentarse()
        {
            string presentacion = ("Hola Soy: " + nombre + " " + apellido);
            return presentacion;
            //termina la ejecucion del metodo y devuelve el control al metodo que lo llamo.
        }

        public void Listar()
        {
            //imprimimos en un renglon los datos de un cliente
            Console.WriteLine("|{0}||{1}||{2}||{3}||{4}|",codigo, nombre, apellido, direccion,localidad);
        }

        private string AnunciarDomicilio()
        {
            string anunciar = ("Vivo en: " + direccion + " - " + localidad);
            return anunciar;
        }

        public string AnunciarEdad()
        {
            //Calculamos la edad y la mostramos en un string
            int edad;
            DateTime hoy = DateTime.Now;
            edad = hoy.DayOfYear - FechaNac.DayOfYear;
            string AnunciarEdad = ("Nací en el año " + FechaNac.Year + " y tengo " + edad + " años de edad");
            return AnunciarEdad;
        }

        public void Hablar()
        {
            Console.WriteLine(Presentarse());
            Console.WriteLine(AnunciarDomicilio());
            Console.WriteLine(AnunciarEdad());
        }
    }


}

