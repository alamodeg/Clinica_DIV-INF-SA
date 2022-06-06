using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public class Persona
    {
        private string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }
}
