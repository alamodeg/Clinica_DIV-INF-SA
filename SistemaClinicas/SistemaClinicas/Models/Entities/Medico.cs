using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public class Medico : Persona
    {
        private int Matricula { get; set; }
        private string Especialidad { get; set; }

        public Medico(string nameMedico, int matricula, string especialidad) : base(nameMedico)
        {
            Matricula = matricula;
            Especialidad = especialidad;
        }
    }
}
