using System;
using System.Collections.Generic;
using System.Text;

namespace Transacciones
{
    public class ModificarTransacciones
    {
        enum Opciones
        {
            BORRAR = 1,
            MOD,
            ATRAS
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Que desea hacer?: \n1-Eliminar transaccion\n2-Modificar Transaccion\n3-atras");
            int opcion = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (opcion)
                {
                    case (int)Opciones.BORRAR:
                        Borrar();
                        break;
                    case (int)Opciones.MOD:
                        Modificar();
                        break;
                    case (int)Opciones.ATRAS:
                        MenuPrincipal.Menu();
                        break;
                    default:
                        Console.WriteLine("Debe introducir una opcion valida");
                        Console.ReadKey();
                        Menu();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Coloque una opcion valida");
                Menu();
            }
        }

        private static void Modificar()
        {

            Console.Clear();
            Console.WriteLine("Introduzca el ID de la transaccion que desea editar: ");
            int numeroID = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < Repositorio.Instancia.transaccionesAprobadas.Count; i++)
            {
                if (Repositorio.Instancia.transaccionesAprobadas[i].ID == (numeroID))
                {
                    Console.WriteLine("Transaccion de tipo aprobada encontrada.");
                    Console.WriteLine("Introduzca el nombre del nuevo cliente:");
                    string nuevoCliente = Console.ReadLine();
                    Console.WriteLine("Introduzca el nuevo montro:");
                    int nuevoMonto = Convert.ToInt32(Console.ReadLine());
     
             Transaccion transaccionEditada = new Transaccion(nuevoCliente, nuevoMonto);
                 Repositorio.Instancia.transaccionesAprobadas[numeroID - 1] = transaccionEditada;


                }
                else
                {
                    Console.WriteLine("seleccione una opcion valida");
                    Console.ReadKey();
                    Modificar();
                }

            }

        }
        private static void Borrar()
        {

        }


    }
}
