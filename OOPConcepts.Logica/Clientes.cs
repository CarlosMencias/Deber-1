using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logica
{
    public class Clientes
    {
        public string? Cliente;

        public int Celular;

        public string? Correo;

        public int Huespedes;

        public string? Pago;

        public Date? Reserva;

        public override string ToString()
        {
            return
                $"Fecha de reserva........:{Reserva, 20}\n" +
                $"Cliente.................:{Cliente, 20}\n" +
                $"Celular.................:{Celular, 20}\n" +
                $"Correo..................:{Correo, 20}\n" +
                $"Cantidad de huespedes...:{Huespedes, 20}\n" +
                $"Pago....................:{Pago, 20}\n";
                
        }
    }
}
