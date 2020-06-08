using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace CajeroAutomatico
{
   public class ElegirModo
    {
        enum Opciones
        {
            MODO_1 = 1,
            MODO_2,
            ATRAS
        }

        public void menuModos()
        {
            Console.Clear();
            Console.WriteLine("Elija el modo de dispensacion de billetes: \n\n1.Solo billetes de 100 y 500 \n2.Solo billetes de 200 y 1,000 \n3.Atras");
            int eleccionModo = Convert.ToInt32(Console.ReadLine());
            
            Repositorio.Instancia.eleccionModo = eleccionModo;
            try
            {
                switch (eleccionModo)
                {
                    case (int)Opciones.MODO_1:
                        EleccionModo1();
                        break;
                    case (int)Opciones.MODO_2:
                        EleccionModo2();
                        break;
                    case (int)Opciones.ATRAS:
                        // Al seleccionar la opcion 3 igualo nuevamente la  variable a 0 para evitar que la variable tome valor de 3
                        Repositorio.Instancia.eleccionModo = 0;
                        MenuPrincipal.Menu();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();
                        menuModos();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ingrese una opcion valida");
                Console.ReadKey();
                menuModos();
            }
        }

        public static void EleccionModo1()
        {
            Console.Clear();
            Console.WriteLine("***Ha elegido el modo de dispensasion de billetes de solo 100 y 500 pesos, puede proceder a retirar***");
            Console.ReadKey();  
            MenuPrincipal.Menu();
        }

        public static void EleccionModo2()
        {
            Console.Clear();
            Console.WriteLine("***Ha elegido el modo de dispensasion de billetes de solo 200 y 1,000 pesos, puede proceder a retirar***");
            Console.ReadKey();
            MenuPrincipal.Menu();
        }
    }
}
