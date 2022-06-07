using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public abstract class Tipo_Consulta
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public Medico Profesional { get; set; }

        protected Tipo_Consulta(DateTime fecha, string descripcion, float costo, Medico profesional)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Costo = costo;
            Profesional = profesional;
        }
    }
}
