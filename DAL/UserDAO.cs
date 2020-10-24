using Cmm;
using DAL.Inf;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class UserDAO
    {
        public Response Insert(User user)
        {
            Response dbResponse = new Response();            
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();
            command.CommandText =
                "INSERT INTO Users (NOME,CPF,RG,EMAIL,TELFONE1,TELEFONE2,ENDERECOID,ISADMIN,SENHA) VALUES (NOME,CPF,RG,EMAIL,TELFONE1,TELEFONE2,ENDERECOID,ISADMIN,SENHA)";
            command.Parameters.AddWithValue("@NOME", user.Nome);
            command.Parameters.AddWithValue("@CPF", user.Cpf);
            command.Parameters.AddWithValue("@RG", user.Rg);
            command.Parameters.AddWithValue("@EMAIL", user.Email);
            command.Parameters.AddWithValue("@TELFONE1", user.Telefones[0]);
            command.Parameters.AddWithValue("@TELFONE2", user.Telefones[1]);
            command.Parameters.AddWithValue("@ENDERECOID", user.EnderecoId);
            command.Parameters.AddWithValue("@ISADMIN", user.IsAdmin);
            command.Parameters.AddWithValue("@SENHA", user.Senha);

            command.Connection = connection;

            try
            {

                connection.Open();
                command.ExecuteNonQuery();
                dbResponse.Success = true;
                dbResponse.Message = "User cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                dbResponse.Success = false;
                dbResponse.Message = "Erro no banco de dados, contate o administrador.";

                dbResponse.StackTrace = ex.StackTrace;
                dbResponse.ExceptionError = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return dbResponse;
        }
    }
}
