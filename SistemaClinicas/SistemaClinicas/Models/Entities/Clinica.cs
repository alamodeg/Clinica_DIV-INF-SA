using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public class Clinica
    {
        public List<Paciente> listaPacientes { get; set; }
        public List<Medico> listaMedicos { get; set; }
    }
}
