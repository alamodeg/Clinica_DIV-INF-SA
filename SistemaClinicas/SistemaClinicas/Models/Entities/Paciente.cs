using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public class Paciente : Persona
    {
        public string Historia_Clinica { get; set; }
        public List<int> Consultas { get; set; }
    }
}
