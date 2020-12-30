using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Habilidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdEmpleado { get; set; }        
    }
}
