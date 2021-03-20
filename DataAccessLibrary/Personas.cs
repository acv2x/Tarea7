using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class Personas
    {
        public int ID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Signo_Zodiacal { get; set; }
        public string Vacuna_Recibida { get; set; }
        public string Provincia { get; set; }
        public string Primera_Dosis { get; set; }
        public string Segunda_Dosis { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
    }
}
