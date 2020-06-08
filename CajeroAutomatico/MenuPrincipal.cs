using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
   public class MenuPrincipal
    {
        enum Opciones
        {
            MODO =1,
            RETIRO,
            SALIR
        }
        public static void Menu()
        {
            var ModoDispensacion = new ElegirModo();
            var ServicioRetiro = new ServicioRetiro();          

            RetirarDinero RetirarDinero = new RetirarDinero();
            Console.Clear();
            Console.WriteLine("BIENVENIDO AL CAJERO AUTOMATICO ATM! \nSeleccione una opcion:");
            Console.WriteLine("\n1. Seleccionar modo de dispensacion de billetes \n2. Retirar dinero \n3. Salir");

            try
            {
                int opcionMenu = Convert.ToInt32(Console.ReadLine());

                switch (opcionMenu)
                {
                    case (int)Opciones.MODO:
                        ModoDispensacion.menuModos();
                        break;
                    case (int)Opciones.RETIRO:
                        RetirarDinero.Retiro();
                        break;
                    case (int)Opciones.SALIR:
                        Console.WriteLine("Pongame buena nota profe, bye :)");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();
                        Menu();
                        break;
                }
            }

            catch(Exception)
            {
                Console.WriteLine("Ingrese una opcion valida");
                Console.ReadKey();
                Menu();
            }
        }
    }
}







