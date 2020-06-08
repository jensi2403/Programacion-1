using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CajeroAutomatico
{
    public class RetirarDinero   
    {
        public void Retiro()
        {
            ServicioRetiro ServicioDispensacion = new ServicioRetiro();

            if (Repositorio.Instancia.eleccionModo == 0)
            {
                ServicioDispensacion.Eficiente();
            }

            Console.Clear();
            Console.WriteLine("Ingrese el monto a retirar");
            int Monto = Convert.ToInt32(Console.ReadLine());

            Repositorio.Instancia.Monto = Monto;
         

            if (Repositorio.Instancia.eleccionModo == 1)
            {
                ServicioDispensacion.Modo_1();
            }
            if (Repositorio.Instancia.eleccionModo == 2)
            {         
                ServicioDispensacion.Modo_2();
            }                 
        }
    }
}
