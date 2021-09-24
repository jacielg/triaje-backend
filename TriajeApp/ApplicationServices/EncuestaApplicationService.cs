using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TriajeApp.Models;
using TriajeApp.DomainServices;
using TriajeApp.DataContext;

namespace TriajeApp.ApplicationServices
{
    public class EncuestaApplicationService
    {
        private readonly EncuestaDataContext _encuestaDataContext;
        private readonly EncuestaDomainService _encuestaDomainService;
        public EncuestaApplicationService(EncuestaDataContext encuestaDataContext, EncuestaDomainService encuestaDomainService)
        {
            _encuestaDataContext = encuestaDataContext;
            _encuestaDomainService = encuestaDomainService;
        }
        public async Task<string> GetEncuestaApplicationService(int encuestaId)
        {
            var encuesta = await _encuestaDataContext.Encuestas.FirstOrDefaultAsync(q => q.encuestaId == encuestaId);

            var respuestaEncuestaDomainService = _encuestaDomainService.GetEncuestaDomainService(encuestaId, encuesta);

            bool hayErrorDomainService = respuestaEncuestaDomainService != null;

            if (hayErrorDomainService)
            {
                return respuestaEncuestaDomainService;
            }

            return null;
        }
        public async Task<string> PostEncuestaApplicationService(Encuesta encuesta)
        {
            var respuestaEncuestaDomainService = _encuestaDomainService.PostEncuestaDomainService(encuesta);

            bool hayErrorDomainService = respuestaEncuestaDomainService != null;

            if (hayErrorDomainService)
            {
                return respuestaEncuestaDomainService;
            }

            encuesta.encuestaFecha = DateTime.Now;
            _encuestaDataContext.Encuestas.Add(encuesta);
            await _encuestaDataContext.SaveChangesAsync();

            return null;
        }
    }
}
