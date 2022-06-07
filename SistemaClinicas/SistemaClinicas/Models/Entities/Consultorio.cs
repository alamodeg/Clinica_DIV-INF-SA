using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public class Consultorio 
    {
        public float Costo_Descartables { get; set; }

        public Consultorio(float costo_Descartables)
        {
            Costo_Descartables = costo_Descartables;
        }
    }
}
