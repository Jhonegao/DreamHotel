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
    public class AddressDAO
    {
        public Response Insert(Address address)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();
            command.CommandText =
                "INSERT INTO ADDRESSES (NUMERO,RUA,BAIRRO,CIDADE,UF,CEP,PAIS) VALUES (@NUMERO, @RUA, @BAIRRO, @CIDADE, @UF, @CEP, @PAIS)";
            command.Parameters.AddWithValue("@NUMERO", address.Numero);
            command.Parameters.AddWithValue("@RUA", address.Rua);
            command.Parameters.AddWithValue("@BAIRRO", address.Bairro);
            command.Parameters.AddWithValue("@CIDADE", address.Cidade);
            command.Parameters.AddWithValue("@UF", address.UF);
            command.Parameters.AddWithValue("@CEP", address.CEP);
            command.Parameters.AddWithValue("@PAIS", address.Pais);
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                //int idGerado = Convert.ToInt32(command.ExecuteScalar());
                dbResponse.Success = true;
                dbResponse.Message = "Endereco cadastrado com sucesso!";
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
        public Response Update(Address address)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE Addresses SET NUMERO = @NUMERO, RUA = @RUA BAIRRO = @BAIRRO, CIDADE = @CIDADE, UF = UF, CEP = @CEP, PAIS = @PAIS WHERE ID = @ID";
            command.Parameters.AddWithValue("@NUMERO", address.Numero);
            command.Parameters.AddWithValue("@RUA", address.Rua);
            command.Parameters.AddWithValue("@BAIRRO", address.Bairro);
            command.Parameters.AddWithValue("@CIDADE", address.Cidade);
            command.Parameters.AddWithValue("@UF", address.UF);
            command.Parameters.AddWithValue("@CEP", address.CEP);
            command.Parameters.AddWithValue("@PAIS", address.Pais);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                //int idGerado = Convert.ToInt32(command.ExecuteScalar());
                dbResponse.Success = true;
                dbResponse.Message = "Endereco alterado com sucesso!";
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
        //public Response GetById(int id)
        //{
        //    SingleResponse response = new SingleResponse();

        //    Response dbResponse = new Response();
        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = ConnectionHelper.GetConnectionString();
        //    SqlCommand command = new SqlCommand();

        //    command.CommandText = "SELECT * FROM Addresses WHERE ATIVO = 1 AND ID = @ID";
        //    command.Parameters.AddWithValue("@ID", id);
        //    command.Connection = connection;

        //    try
        //    {
        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader();

        //        //Address enderecoSelecionado = new Address();

        //        while (reader.Read())
        //        {
        //            Address enderecoSelecionado = new Address();
        //            enderecoSelecionado.ID = (int)reader["ID"];
        //            enderecoSelecionado.Numero = (string)reader["NUMERO"];
        //            enderecoSelecionado.Rua = (string)reader["BAIRRO"];
        //            enderecoSelecionado.Bairro = (string)reader["CIDADE"];
        //            enderecoSelecionado.Cidade = (string)reader["CIDADE"];
        //            enderecoSelecionado.Pais = (string)reader["PAIS"];
        //        }
        //        response.Success = true;
        //        response.Message = "Dados selecionados com sucesso!";
        //        response.Data = enderecoSelecionado;
        //        return response;
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Success = false;
        //        response.Message = "Erro no Banco de Dados, contate um ADM!";
        //        response.StackTrace = ex.StackTrace;
        //        response.ExceptionError = ex.Message;
        //        return response;
        //    }
        //    finally
        //    {
        //        // finally sempre é executado, independente de exceções ou returns!
        //        connection.Close();
        //    }
        //}

    }
}

//public ClassNamePlaceholder()
//{
//    public ClassNamePlaceholder ()
//    {
//        //using(TransactionScope scope = new TransacionScope())
//        //{
//        //SingleResponse<int> responseEnd = enderecoDao.Inserir(endereco);
//        //if(responseEnd.Sucess && responseEnd.Data != 0)
//        //{
//        //usuario.EnderecoID = responseEnd.Data;
//        //Response response = usuarioDao.Inserir(usuario);
//        //if(response.Sucess){cope.Complete()};
//        //
//        //}
//        //}
//    }
//}

