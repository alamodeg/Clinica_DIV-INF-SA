using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public class Clinica
    {
        private List<Paciente> ListaPacientes { get; set; }
        private List<Medico> ListaMedicos { get; set; }
        public Clinica()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
        }
    }
}
