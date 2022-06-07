using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaClinicas.Models.Entities
{
    public class Medico : Persona
    {
        [Required(ErrorMessage ="Este campo es obligatorio!")]
        public int Matricula { get; set; }
        public string Especialidad { get; set; }
        /*
        public Medico(string nameMedico, int matricula, string especialidad) : base(nameMedico)
        {
            Matricula = matricula;
            Especialidad = especialidad;
        }
        */
    }
}
