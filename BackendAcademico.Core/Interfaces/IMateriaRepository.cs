using System;
using System.Collections.Generic;
using System.Text;
using BackendAcademico.Core.Entities;

namespace BackendAcademico.Core.Interfaces
{
    public interface IMateriaRepository
    {
        IEnumerable<Materia> GetMaterias();
    }
}
