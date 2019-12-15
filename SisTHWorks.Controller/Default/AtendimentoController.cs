using SisTHWorks.Model;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SisTHWorks.Controller
{
    public partial class AtendimentoController
    {
     
        //Variaveis locais para string de conexão e acesso aos dados (command, connection);
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["SQLServerExpress"].ConnectionString;
        private SqlConnection dbConnection = null;
        private SqlCommand dbCommand = null;

        public AtendimentoController(){}

        ~AtendimentoController()
        {
            dbConnection = null;
            dbCommand = null;
        }

        public int Save(Int32 Registro, Decimal? Saturacao, Decimal? Glasgow, Decimal? Tax, Decimal? Hgt, String Pa, Decimal? Fc, String Descricao, Int32 IdClassificacao, Int32 IdPaciente, Int32 IdEnfermeiro)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Atendimento_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@registro", Registro));
            dbCommand.Parameters.Add(new SqlParameter("@saturacao", Saturacao));
            dbCommand.Parameters.Add(new SqlParameter("@glasgow", Glasgow));
            dbCommand.Parameters.Add(new SqlParameter("@hgt", Hgt));
            dbCommand.Parameters.Add(new SqlParameter("@pa", Pa));
            dbCommand.Parameters.Add(new SqlParameter("@tax", Tax));
            dbCommand.Parameters.Add(new SqlParameter("@fc", Fc));
            dbCommand.Parameters.Add(new SqlParameter("@discricao", Descricao));
            dbCommand.Parameters.Add(new SqlParameter("@idClassificacao", IdClassificacao));
            dbCommand.Parameters.Add(new SqlParameter("@idPaciente", IdPaciente));
            dbCommand.Parameters.Add(new SqlParameter("@idEnfermeiro", IdEnfermeiro));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Save(AtendimentoEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Atendimento_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@registro", Item.Registro));
            dbCommand.Parameters.Add(new SqlParameter("@saturacao", Item.Saturacao));
            dbCommand.Parameters.Add(new SqlParameter("@glasgow", Item.Glasgow));
            dbCommand.Parameters.Add(new SqlParameter("@hgt", Item.Hgt));
            dbCommand.Parameters.Add(new SqlParameter("@pa", Item.Pa));
            dbCommand.Parameters.Add(new SqlParameter("@tax", Item.Tax));
            dbCommand.Parameters.Add(new SqlParameter("@fc", Item.Fc));
            dbCommand.Parameters.Add(new SqlParameter("@discricao", Item.Descricao));
            dbCommand.Parameters.Add(new SqlParameter("@idClassificacao", Item.IdClassificacao));
            dbCommand.Parameters.Add(new SqlParameter("@idPaciente", Item.IdPaciente));
            dbCommand.Parameters.Add(new SqlParameter("@idEnfermeiro", Item.IdEnfermeiro));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Delete(AtendimentoEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Atendimento_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idAtendimento", Item.Id));
            int result;
            try
            {
                 result = dbCommand.ExecuteNonQuery();
            }
            catch
            {
                result = 0;
            }
            dbConnection.Close();

            return result;
        }

        public int Delete(System.Int32 Id)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Atendimento_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idAtendimento", Id));
            int result;
            try
            {
                result = dbCommand.ExecuteNonQuery();
            }
            catch
            {
                result = 0;
            }
            dbConnection.Close();
            return result;
        }
        public int Update(AtendimentoEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Atendimento_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idAtendimento", Item.Id));
            dbCommand.Parameters.Add(new SqlParameter("@registro", Item.Registro));
            dbCommand.Parameters.Add(new SqlParameter("@saturacao", Item.Saturacao));
            dbCommand.Parameters.Add(new SqlParameter("@glasgow", Item.Glasgow));
            dbCommand.Parameters.Add(new SqlParameter("@hgt", Item.Hgt));
            dbCommand.Parameters.Add(new SqlParameter("@pa", Item.Pa));
            dbCommand.Parameters.Add(new SqlParameter("@tax", Item.Tax));
            dbCommand.Parameters.Add(new SqlParameter("@fc", Item.Fc));
            dbCommand.Parameters.Add(new SqlParameter("@discricao", Item.Descricao));
            dbCommand.Parameters.Add(new SqlParameter("@idClassificacao", Item.IdClassificacao));
            dbCommand.Parameters.Add(new SqlParameter("@idPaciente", Item.IdPaciente));
            dbCommand.Parameters.Add(new SqlParameter("@idEnfermeiro", Item.IdEnfermeiro));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Update(Int32 Id, Int32 Registro, Decimal? Saturacao, Decimal? Glasgow, Decimal? Tax, Decimal? Hgt, String Pa, Decimal? Fc, String Descricao, Int32 IdClassificacao, Int32 IdPaciente, Int32 IdEnfermeiro)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Atendimento_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idAtendimento", Id));
            dbCommand.Parameters.Add(new SqlParameter("@registro", Registro));
            dbCommand.Parameters.Add(new SqlParameter("@saturacao", Saturacao));
            dbCommand.Parameters.Add(new SqlParameter("@glasgow", Glasgow));
            dbCommand.Parameters.Add(new SqlParameter("@hgt", Hgt));
            dbCommand.Parameters.Add(new SqlParameter("@pa", Pa));
            dbCommand.Parameters.Add(new SqlParameter("@tax", Tax));
            dbCommand.Parameters.Add(new SqlParameter("@fc", Fc));
            dbCommand.Parameters.Add(new SqlParameter("@discricao", Descricao));
            dbCommand.Parameters.Add(new SqlParameter("@idClassificacao", IdClassificacao));
            dbCommand.Parameters.Add(new SqlParameter("@idPaciente", IdPaciente));
            dbCommand.Parameters.Add(new SqlParameter("@idEnfermeiro", IdEnfermeiro));


            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }
        public AtendimentoEntity Read(System.Int32 Id)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Atendimento_GetUnique";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idAtendimento", Id));

            SqlDataReader reader = null;
            AtendimentoEntity atendimentoEnty = new AtendimentoEntity();

            reader = dbCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    atendimentoEnty.Id = reader.GetInt32(0);
                    atendimentoEnty.Registro = reader.GetInt32(1);
                    atendimentoEnty.DataHora = reader.GetDateTime(2);
                    try
                    {
                        atendimentoEnty.Saturacao =  reader.GetDecimal(3);
                    }
                    catch
                    {
                        atendimentoEnty.Saturacao = null;
                    }
                    try
                    {
                        atendimentoEnty.Glasgow = reader.GetDecimal(4);
                    }
                    catch
                    {
                        atendimentoEnty.Glasgow = null;
                    }
                    try
                    {
                        atendimentoEnty.Tax =  reader.GetDecimal(5);
                    }
                    catch
                    {
                        atendimentoEnty.Tax = null;
                    }
                    try
                    {
                        atendimentoEnty.Hgt =  reader.GetDecimal(6);
                    }
                    catch
                    {
                        atendimentoEnty.Hgt = null;
                    }
                    try
                    {
                        atendimentoEnty.Pa =  reader.GetString(7);
                    }
                    catch
                    {
                        atendimentoEnty.Pa = null;
                    }
                    try
                    {
                        atendimentoEnty.Fc =  reader.GetDecimal(8);
                    }
                    catch
                    {
                        atendimentoEnty.Fc = null;
                    }
                    atendimentoEnty.Descricao = reader.GetString(9);
                    atendimentoEnty.IdPaciente = reader.GetInt32(10);
                    atendimentoEnty.IdClassificacao = reader.GetInt32(12);

                }
            }

            dbConnection.Close();
            return atendimentoEnty;
        }
        public DataTable ReadAll()
        {
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Atendimento_GetAll";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(dbCommand);
            adapter.Fill(table);

            dbConnection.Close();
            return table;
        }
    }
}
