using System;
using System.Collections.Generic;
using System.Text;

namespace Transacciones
{
        public sealed class Repositorio
        {

            public List<Transaccion> TransaccionesCanceladas { get; set; } = new List<Transaccion>();
            public List<Transaccion> TransaccionesBorradas { get; set; } = new List<Transaccion>();
            public List<Transaccion> transaccionesAprobadas { get; set; } = new List<Transaccion>();
            public List<Transaccion> TransaccionesRechazadas{ get; set; } = new List<Transaccion>();






        public static Repositorio Instancia { get; } = new Repositorio();

            private Repositorio()
            {

            }



        }
    
}
