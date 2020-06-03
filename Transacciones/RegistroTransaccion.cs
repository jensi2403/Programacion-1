using System;
using System.Collections.Generic;
using System.Text;

namespace Transacciones
{
    public class RegistroTransaccion
    {
        
        public static void Registro()
        {



            int ID = 756369;
                
            Console.Clear();
            Console.WriteLine("REGISTRO DE TRANSACCION NUMERO: " + ID);

           
            Console.WriteLine("Escriba el nombre del cliente:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite el monto de transaccion:");
            int monto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que tipo de transaccion es?: \n1 = aprobada \n2 = rechazada");
            int tipo = Convert.ToInt32(Console.ReadLine());
            
            Transaccion nuevaTransaccion = new Transaccion(nombre, monto, tipo, ID);
         

            if (tipo == 1)
            {
                Repositorio.Instancia.transaccionesAprobadas.Add(nuevaTransaccion);
                Console.WriteLine("Su transaccion es de tipo 'aprobada' y ha sido guardada");
                Console.ReadKey();
                DobleVia();
                
            }
            if (tipo == 2)
            {
                Repositorio.Instancia.TransaccionesRechazadas.Add(nuevaTransaccion);
                Console.WriteLine("Su transaccion es de tipo 'rechazada' y ha sido guardada");
                Console.ReadKey();
                DobleVia();
            }
            else
            {
                Console.WriteLine("Seleccione una opcion valida");
                Console.ReadKey();
                MenuPrincipal.Menu();

            }
            
                                           
        }

        private static void DobleVia()
        {
            Console.WriteLine("Presione '1' para registrar otra transaccion o '2' para volver al menu principal");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if(opcion == 1)
            {
                Registro();
            }
            if(opcion == 2)
            {
                MenuPrincipal.Menu();
            }
            else
            {
                Console.WriteLine("seleccione una opcion");
                Console.WriteLine();
                DobleVia();
            }
        }
    }
}
