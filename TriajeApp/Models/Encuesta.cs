using System;

namespace TriajeApp.Models
{
    public class Encuesta
    {
        public int encuestaId { get; set; }
        public DateTime encuestaFecha { get; set; }
        public string encuestaTipo { get; set; }
        public string empleadoBarcode { get; set; }
        public string empleadoDNI { get; set; }
        public string empleadoNombre { get; set; }
        public string empleadoTelefono { get; set; }
        public string empleadoSexo { get; set; }
        public int empleadoEdad { get; set; }
        public string empresaNombre { get; set; }
        public string empresaEdificio { get; set; }
        public string empresaNivel { get; set; }
        public string kitBienvenida { get; set; }
        public int empleadoTemperatura { get; set; }
        public string haViajado { get; set; }
        public string cercaniaCovid { get; set; }
        public string empleadoSintomas { get; set; }
        public string alertaIncapacidad { get; set; }
        public string reintegroIncapacidad { get; set; }
        public string empleadoIncapacitado { get; set; }
        public string empleadoVacunado { get; set; }
    }
}
