using System;
using System.Collections.Generic;
using System.Text;

namespace BackendAcademico.Core.Entities
{
    public class Inscripcion
    {
        public int IdInscripcion { get; set; }
        public int IdMateria { get; set; }
        public int IdEstudiante { get; set; }
        public string Descripcion { get; set; }
    }
}
