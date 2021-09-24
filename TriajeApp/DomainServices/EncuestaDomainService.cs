using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriajeApp.Models;

namespace TriajeApp.DomainServices
{
    public class EncuestaDomainService
    {
        public string GetEncuestaDomainService(int encuestaId, Encuesta encuesta)
        {
            if (encuesta == null)
            {
                return "Este registro no existe.";
            }
      
            return null;
        }
        public string PostEncuestaDomainService(Encuesta encuesta)
        {
            if (encuesta.encuestaTipo == "")
            {
                return "Especifique el tipo de visita.";
            }
            if (encuesta.empleadoBarcode == "")
            {
                return "Se necesita el barcode del empleado.";
            }
            if (encuesta.empleadoDNI == "")
            {
                return "Se necesita la identificación del empleado.";
            }
            if (encuesta.empleadoNombre == "")
            {
                return "Se necesita el nombre del empleado.";
            }
            if (encuesta.empleadoTelefono == "")
            {
                return "Se necesita el telefono del empleado.";
            }
            if (encuesta.empleadoSexo == "")
            {
                return "Se necesita el sexo del empleado.";
            }
            if (encuesta.empresaNombre == "")
            {
                return "Se necesita el nombre de la empresa.";
            }
            if (encuesta.empresaEdificio == "")
            {
                return "Se necesita el edificio donde se encuentra la empresa.";
            }
            if (encuesta.empresaNivel == "")
            {
                return "Se necesita el nivel en el que se encuentra la empresa.";
            }
            if (encuesta.kitBienvenida == "")
            {
                return "Se necesita una respuesta.";
            }
            if (encuesta.haViajado == "")
            {
                return "Se necesita una respuesta.";
            }
            if (encuesta.cercaniaCovid == "")
            {
                return "Se necesita una respuesta.";
            }
            if (encuesta.empleadoSintomas == "")
            {
                return "Se necesitan los síntomas del empleado.";
            }
            if (encuesta.alertaIncapacidad == "")
            {
                return "Se necesita una respuesta.";
            }
            if (encuesta.reintegroIncapacidad == "")
            {
                return "Se necesita una respuesta.";
            }
            if (encuesta.empleadoIncapacitado == "")
            {
                return "Se necesita una respuesta.";
            }
            if (encuesta.empleadoVacunado == "")
            {
                return "Se necesita una respuesta.";
            }

            return null;
        }
    }
}
