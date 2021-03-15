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
        Task<IEnumerable<Personas>> GetPersonasProvincias(string provincia);
        Task<IEnumerable<Personas>> GetPersonasSigno(string signo);
        Task<IEnumerable<Personas>> GetPersonasMarca(string marca);
    }
}
