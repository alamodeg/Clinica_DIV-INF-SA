using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public abstract class Tipo_Consulta
    {
        private DateTime Fecha { get; set; }
        private string Descripcion { get; set; }
        private float Costo { get; set; }
        private Medico Profesional { get; set; }
        protected Tipo_Consulta(DateTime fecha, string descripcion, float costo, Medico profesional)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Costo = costo;
            Profesional = profesional;
        }
    }
}
