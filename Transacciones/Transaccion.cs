using System;
using System.Collections.Generic;
using System.Text;

namespace Transacciones
{
    public class Transaccion
    {
      
        public string nuevoCliente;

        public int nuevoMonto;

        public string Cliente { get; set; }

        public int Monto { get; set; }

        public int Tipo { get; set; }

        public int ID { get; set; }


        public Transaccion(string Cliente, int Monto, int Tipo, int ID)
        {
            this.Cliente = Cliente;
            this.Monto = Monto;
            this.Tipo = Tipo;
            this.ID = ID;
        }

        public Transaccion(string nuevoCliente, int nuevoMonto)
        {
            this.nuevoCliente = nuevoCliente;
            this.nuevoMonto = nuevoMonto;
        }
    }
}
