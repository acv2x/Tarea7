using Dapper;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dapper.Repositorios
{
    public class PersonasRepositorio : IPersonasRepositorio
    {
        private string ConnectionString;
        public PersonasRepositorio(string connectionstring)
        {
            ConnectionString = connectionstring;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public async Task<IEnumerable<Personas>> GetAllPersonas()
        {
            var db = dbConnection();
            var sql = @"SELECT * FROM Personas";

            return await db.QueryAsync<Personas>(sql.ToString(), new { });
        }


        public async Task<IEnumerable<Personas>> GetPersonasProvincias(string provincia)
        {
            var db = dbConnection();
            var sql = $@"SELECT * FROM Personas where Provincia = '{provincia}'";
            return await db.QueryAsync<Personas>(sql.ToString(), new { });
        }

        public async Task<IEnumerable<Personas>> GetPersonasSigno(string signo)
        {
            var db = dbConnection();
            var sql = $@"SELECT * FROM Personas where Signo_Zodiacal = '{signo}'";
            return await db.QueryAsync<Personas>(sql.ToString(), new { });
        }

        public async Task<IEnumerable<Personas>> GetPersonasMarca(string marca)
        {
            var db = dbConnection();
            var sql = $@"SELECT * FROM Personas where Vacuna_Recibida = '{marca}'";
            return await db.QueryAsync<Personas>(sql.ToString(), new { });
        }
    }
}
