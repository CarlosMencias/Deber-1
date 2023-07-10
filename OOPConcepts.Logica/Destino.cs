using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logica
{
        public class Destino
        {
            public string? Pais;

            public string? Ciudad;

            public Destino()
            {
                Pais = null;
                Ciudad = null;
            }

            public override string ToString()
            {
                return

                    $"Pais de reserva........:{Pais,20}\n" +
                    $"Ciudad.................:{Ciudad,20}\n";

            }

        }
 }

