using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public class Consultorio : Tipo_Consulta
    {
        public float Costo_Descartables { get; set; }
    }
}
