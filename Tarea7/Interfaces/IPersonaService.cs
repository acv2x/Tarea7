using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea7.Interfaces
{
    public interface IPersonaService
    {
        Task<IEnumerable<Personas>> GetAllPersonas();
        Task<IEnumerable<Personas>> GetPersonasProvincias(string provincia);
        Task<IEnumerable<Personas>> GetPersonasSigno(string signo);
        Task<IEnumerable<Personas>> GetPersonasMarca(string marca);
    }
}
