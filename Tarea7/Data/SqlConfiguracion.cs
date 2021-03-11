using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea7.Data
{
    public class SqlConfiguracion
    {
        public SqlConfiguracion(string connectionstring) => ConnectionString = connectionstring;

        public string ConnectionString { get; }
    }
}
