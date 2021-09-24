using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TriajeApp.Models;
using TriajeApp.ApplicationServices;
using TriajeApp.DataContext;

namespace TriajeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncuestaController : Controller
    {
        private readonly EncuestaDataContext _encuestaDataContext;
        private readonly EncuestaApplicationService _encuestaApplicationService;
        public EncuestaController(EncuestaDataContext encuestaDataContext, EncuestaApplicationService encuestaApplicationService)
        {
            _encuestaDataContext = encuestaDataContext;
            _encuestaApplicationService = encuestaApplicationService;
        }

        [HttpGet("{encuestaId}")]
        public async Task<ActionResult<Encuesta>> GetEncuesta(int encuestaId)
        {
            var respuestaEncuestaApplicationService = await _encuestaApplicationService.GetEncuestaApplicationService(encuestaId);
            bool noHayErroresEnValidaciones = respuestaEncuestaApplicationService == null;

            if (noHayErroresEnValidaciones)
            {
                return await _encuestaDataContext.Encuestas.FirstOrDefaultAsync(q => q.encuestaId == encuestaId);
            }
            return BadRequest(respuestaEncuestaApplicationService);
        }

        [HttpPost]
        public async Task<ActionResult<Encuesta>> PostEncuesta(Encuesta encuesta)
        {
            var respuestaEncuestaApplicationService = await _encuestaApplicationService.PostEncuestaApplicationService(encuesta);

            bool noHayErroresEnValidaciones = respuestaEncuestaApplicationService == null;

            if (noHayErroresEnValidaciones)
            {
                return CreatedAtAction(nameof(GetEncuesta), new { id = encuesta.encuestaId }, encuesta);
            }
            return BadRequest(respuestaEncuestaApplicationService);
        }
    }
}
