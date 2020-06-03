using System;
using System.Collections.Generic;
using System.Text;

namespace Transacciones
{
    public class MenuPrincipal
    {
        enum opcionMenu
        {
            REG_TR = 1,
            MOD_TR,
            LIS_TR,
            SALIR
        }
        public static void Menu()
        {
            try
            {  
                Console.Clear();
                Console.WriteLine("1-Registrar transaccion\n2-Modificar transacciones\n3-Listar transacciones\n4-Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case (int)opcionMenu.REG_TR:
                        RegistroTransaccion.Registro();
                        break;
                    case (int)opcionMenu.MOD_TR:
                        ModificarTransacciones.Menu();
                        break;
                    case (int)opcionMenu.LIS_TR:
                        ListarTransacciones.Listar();
                      break;
                    case (int)opcionMenu.SALIR:
                        Console.WriteLine("Gracias por utilizar el sistema");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Debe introducir una opcion valida");
                        Console.ReadKey();
                        Menu();
                        break;
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Debe introducir una opcion valida");
                Console.ReadKey();
                Menu();
            }
        }
    }
}
