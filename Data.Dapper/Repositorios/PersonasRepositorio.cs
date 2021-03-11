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
    }
}
