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
        public int ID_Provincia { get; set; }
    }
}
