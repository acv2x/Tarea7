using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea7.Interfaces;
using Data.Dapper.Repositorios;
using Tarea7.Data;

namespace Tarea7.Servicios
{
    public class PersonaService : IPersonaService
    {
        private readonly SqlConfiguracion _configuracion;
        private IPersonasRepositorio _personaRepositorio;
        public PersonaService(SqlConfiguracion configuracion)
        {
            _configuracion = configuracion;
            _personaRepositorio = new PersonasRepositorio(configuracion.ConnectionString);
        }
        public Task<IEnumerable<Personas>> GetAllPersonas()
        {
            return _personaRepositorio.GetAllPersonas();
        }
    }
}
