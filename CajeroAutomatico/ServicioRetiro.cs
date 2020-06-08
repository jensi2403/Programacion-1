using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class ServicioRetiro 
    {
        
        ElegirModo ElegirModo = new ElegirModo();
        MenuPrincipal MenuPrincipal = new MenuPrincipal();
        RetirarDinero RetirarDinero = new RetirarDinero();

        public void Modo_1()
        {          
            int b100;
            int b500;

            b500 = Repositorio.Instancia.Monto / 500;
            b100 = Repositorio.Instancia.Monto / 100;

            int Diferencia = Repositorio.Instancia.Monto % 500;
            int Diferencia2 = Diferencia % 100;

            

            if (Diferencia2 != 0)
            {
                Console.WriteLine("Recuerde que solo se puede imprimir billetes de 100 y 500");
                Console.ReadKey();
                RetirarDinero.Retiro();
            }

            Console.WriteLine("Se dispensara:");
            if (Repositorio.Instancia.Monto % 500 >= 0 && Repositorio.Instancia.Monto >= 500)
            {
                Console.WriteLine(b500 + " billetes de 500 "); 
           
                if (Diferencia >= 100)
                {
                    b100 = Diferencia / 100;
                    Console.WriteLine(b100 + " billetes de 100");
                    Console.ReadKey();
                    MenuPrincipal.Menu();
                }
                Console.ReadKey();
                MenuPrincipal.Menu();
            }
            if (Repositorio.Instancia.Monto % 100 > 0 && Repositorio.Instancia.Monto >= 100 )
            {
                Console.WriteLine(b100 + " billetes de 100 ");
                Console.ReadKey();
                MenuPrincipal.Menu();
            }
            if (Repositorio.Instancia.Monto < 500)
            {
                Console.WriteLine(b100 + " billetes de 100 ");
                Console.ReadKey();
                MenuPrincipal.Menu();
            }
        }
        public void Modo_2()
        {
            int b200;
            int b1000;

            b1000 = Repositorio.Instancia.Monto / 1000;
            b200 = Repositorio.Instancia.Monto / 200;

            int Diferencia = Repositorio.Instancia.Monto % 1000;
            int Diferencia2 = Diferencia % 200;

            if (Diferencia2 != 0)
            {
                Console.WriteLine("Recuerde que solo se puede imprimir billetes de 200 y 1000");
                Console.ReadKey();
                RetirarDinero.Retiro();
            }

            Console.WriteLine("Se dispensara:");
            if (Repositorio.Instancia.Monto % 1000 >= 0 && Repositorio.Instancia.Monto >= 1000)
            {
                Console.WriteLine(b1000 + " billetes de 1000");

                if (Diferencia >= 200)
                {
                    b200 = Diferencia / 200;
                    Console.WriteLine(b200 + " billetes de 200");
                    Console.ReadKey();
                    MenuPrincipal.Menu();
                }
                Console.ReadKey();
                MenuPrincipal.Menu();
            }
            if (Repositorio.Instancia.Monto % 200 > 0 && Repositorio.Instancia.Monto >= 200)
            {
                Console.WriteLine(b200 + " billetes de 200");
                Console.ReadKey();
                MenuPrincipal.Menu();
            }
            if (Repositorio.Instancia.Monto < 1000)
            {
                Console.WriteLine(b200 + " billetes de 200");
                Console.ReadKey();
                MenuPrincipal.Menu();
            }        
        }

        public void Eficiente()
        {
            Console.Clear();
            Console.WriteLine("***Modo de retiro eficiente por defecto***");
            Console.WriteLine("\nIngrese el monto a retirar");
            int Monto = Convert.ToInt32(Console.ReadLine());
            Repositorio.Instancia.Monto = Monto;

            int b1000;
            int b500;
            int b200;
            int b100;

            b1000 = Repositorio.Instancia.Monto / 1000;
            b500 = Repositorio.Instancia.Monto / 500;
            b200 = Repositorio.Instancia.Monto / 200;
            b100 = Repositorio.Instancia.Monto / 100;

            int Diferencia = Repositorio.Instancia.Monto % 1000;
            int Diferencia2 = Diferencia % 500;
            int Diferencia3 = Diferencia2 % 200;
            int Diferencia4 = Diferencia3 % 100;

            if (Diferencia4 != 0)
            {
                Console.WriteLine("Recuerde que solo se puede imprimir billetes de 100, 200, 500 y 1000 pesos");
                Console.ReadKey();
                Eficiente();
            }

            Console.WriteLine("Se dispensara:");
          
            if (Repositorio.Instancia.Monto % 1000 >= 0 && Repositorio.Instancia.Monto >= 1000)
            {
                Console.WriteLine(b1000 + " billetes de 1000");

                if (Diferencia >= 500)
                {
                    b500 = Diferencia / 500;
                    Console.WriteLine(b500 + " billetes de 500");                
                }
                if (Diferencia2 >= 200)
                {
                    b200 = Diferencia2 / 200;
                    Console.WriteLine(b200 + " billetes de 200");
                   
                }
                if (Diferencia3 >= 100)
                {
                    b100 = Diferencia3 / 100;
                    Console.WriteLine(b100 + " billetes de 100");                    
                }
                Console.ReadKey();
                MenuPrincipal.Menu();
            }
           
            if (Repositorio.Instancia.Monto % 500 >= 0 && Repositorio.Instancia.Monto >= 500)
            {
                Console.WriteLine(b500 + " billetes de 500");

                if (Diferencia2 >= 200)
                {
                    b200 = Diferencia2 / 200;
                    Console.WriteLine(b200 + " billetes de 200");
                }
                if (Diferencia3 >= 100)
                {
                    b100 = Diferencia3 / 100;
                    Console.WriteLine(b100 + " billetes de 100");
                }
                Console.ReadKey();
                MenuPrincipal.Menu();
            }

            if (Repositorio.Instancia.Monto % 200 >= 0 && Repositorio.Instancia.Monto >= 200)
            {
                Console.WriteLine(b200 + " billetes de 200");
               
                if (Diferencia3 >= 100)
                {
                    b100 = Diferencia3 / 100;
                    Console.WriteLine(b100 + " billetes de 100");
                }
                Console.ReadKey();
                MenuPrincipal.Menu();
            }

            if (Repositorio.Instancia.Monto % 100 >= 0 && Repositorio.Instancia.Monto >= 100)
            {
                Console.WriteLine(b100 + " billetes de 100");
                Console.ReadKey();
                MenuPrincipal.Menu();
            }
        }       
    }
}
