using System;
using System.Collections.Generic;
using System.Text;

namespace BackendAcademico.Core.Entities
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public string Ci { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
