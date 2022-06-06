using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public class Medico : Persona
    {
        public int Matricula { get; set; }
        public string Especialidad { get; set; }
    }
}
