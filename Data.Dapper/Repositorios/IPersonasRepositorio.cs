using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dapper.Repositorios
{
    public interface IPersonasRepositorio
    {
        Task<IEnumerable<Personas>> GetAllPersonas();
    }
}
