using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logica
{
    public class Cliente
    {
        public string? Clientes;

        public int Celular;

        public string? Correo;

        public int Huespedes;

        public string? Pago;

        public Dates? Reserva;

        public Destino? Paiss;
        public Destino? Ciudadd;

        public Cliente()
        {
            Clientes = null;
            Celular = 0;
            Correo = null;
            Huespedes = 0;
            Pago = null;
            Reserva = null;
        }

        public override string ToString()
        {
            return
                $"Fecha de reserva........:{Reserva,20}\n" +
                $"Cliente.................:{Clientes,20}\n" +
                $"Celular.................:{Celular,20}\n" +
                $"Correo..................:{Correo,20}\n" +
                $"Cantidad de huespedes...:{Huespedes,20}\n" +
                $"Pago....................:{Pago,20}\n";

        }

    }
}
