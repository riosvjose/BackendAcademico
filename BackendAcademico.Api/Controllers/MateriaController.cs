using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendAcademico.Core.Entities;
using BackendAcademico.Core.Interfaces;

namespace BackendAcademico.Api.Controllers
{
    [Route("api/Materia")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        readonly IMateriaRepository _materiaRepository;
        //readonly ILogger<PersonaDapperAsyncController> _logger;
        public MateriaController(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [HttpGet]
        [Route("GetMaterias")]
        public IActionResult GetMaterias()
        {
            var per = _materiaRepository.GetMaterias();
            return Ok(per);
        }
     
        
    }
}
