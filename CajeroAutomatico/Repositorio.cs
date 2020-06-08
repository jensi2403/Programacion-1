using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public sealed class Repositorio
    {
        //Declaracion de variable
        public int eleccionModo { get; set; }
        public int Monto { get; set; }

        //Asignacion de metodo a la variable
        public Repositorio(int eleccionModo, int Monto)
        {
            this.eleccionModo = eleccionModo;
            this.Monto = Monto;
        }
        //Declaracion de instancia para su acceso
        public static Repositorio Instancia { get; } = new Repositorio();
        private Repositorio()
        { }
       

    }
}