using DAL.Inf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DbAcess
    {
        static SqlConnection connection = new SqlConnection();
        public static SqlConnection Conexao
        {
            get { return connection; }
        }
        public static void OpenConnection()
        {
            //pegando connection string pelo metodo static.
            string ConnectionSring = ConnectionHelper.GetConnectionString();
            connection.ConnectionString = ConnectionSring;
            connection.Open();
        }
        public static void CloseConnection()
        {
            connection.Close();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

