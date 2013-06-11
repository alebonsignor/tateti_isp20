using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea un objeto llamado sistema de tipo SistemaClientes
            SistemaClientes sistema = new SistemaClientes();
            sistema.Iniciar();
        }
    }
}
