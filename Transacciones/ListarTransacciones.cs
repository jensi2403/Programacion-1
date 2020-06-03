using System;
using System.Collections.Generic;
using System.Text;

namespace Transacciones
{
    class ListarTransacciones
    {
        public static void Listar()
        {

            Console.WriteLine("\nTransacciones Aprobadas");
            foreach (Transaccion elemento in Repositorio.Instancia.transaccionesAprobadas)  
            {

                Console.WriteLine("cliente: " + elemento.Cliente + " /monto: " + elemento.Monto + " /numero de identificacion (ID): " + elemento.ID );
            }

            Console.WriteLine("\nTransacciones Rechazadas");
            foreach (Transaccion elemento in Repositorio.Instancia.TransaccionesRechazadas)
            {
              
                Console.WriteLine("cliente: " + elemento.Cliente + " /monto: " + elemento.Monto + " /numero de identificacion (ID): " + elemento.ID);

            }

            Console.WriteLine("\nTransacciones Canceladas");
            foreach (Transaccion elemento in Repositorio.Instancia.TransaccionesCanceladas)
            {
            
                Console.WriteLine("cliente: " + elemento.Cliente + " /monto: " + elemento.Monto + " /numero de identificacion (ID): " + elemento.ID);

            }

            Console.WriteLine("\nTransacciones Borradas");
            foreach (Transaccion elemento in Repositorio.Instancia.TransaccionesBorradas)
            {
              
                Console.WriteLine("cliente: " + elemento.Cliente + " /monto: " + elemento.Monto + " /numero de identificacion (ID): " + elemento.ID);
                
            }
            Console.ReadKey();
            MenuPrincipal.Menu();

        }
    }
}
