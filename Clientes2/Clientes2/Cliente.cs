using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clientes2
{
    public class Cliente
    {
        public int ID_Cliente { get; set; }
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public int Activo { get; set; }
    }
}
