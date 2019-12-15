using SisTHWorks.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisTHWorks.Controller
{
    public partial class PacienteController
    {
        //Variaveis locais para string de conexão e acesso aos dados (command, connection);
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["SQLServerExpress"].ConnectionString;
        private SqlConnection dbConnection = null;
        private SqlCommand dbCommand = null;

        //Construtor da classe
        public PacienteController(){}

        //Destrututor da classe
        ~PacienteController()
        {
            dbConnection = null;
            dbCommand = null;
        }

        public int Save(PacienteEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@nome", Item.Nome));
            dbCommand.Parameters.Add(new SqlParameter("@nomeMae", Item.NomeMae));
            dbCommand.Parameters.Add(new SqlParameter("@cpf", Item.Cpf));
            dbCommand.Parameters.Add(new SqlParameter("@nascimento", Item.Nascimento));
            dbCommand.Parameters.Add(new SqlParameter("@logradouro", Item.Logradouro));
            dbCommand.Parameters.Add(new SqlParameter("@complemento", Item.Complemento));
            dbCommand.Parameters.Add(new SqlParameter("@numero", Item.Numero));
            dbCommand.Parameters.Add(new SqlParameter("@idBairro", Item.IdBairro));
            dbCommand.Parameters.Add(new SqlParameter("@idCidade", Item.IdBairro));
            dbCommand.Parameters.Add(new SqlParameter("@idNaturalidade", Item.IdNaturalidade));
            dbCommand.Parameters.Add(new SqlParameter("@idEtnia", Item.IdEtnia));
            dbCommand.Parameters.Add(new SqlParameter("@idProfissao", Item.IdProfissao));
            dbCommand.Parameters.Add(new SqlParameter("@idTipoLogradouro", Item.IdTipoLogradouro));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Save(String Nome, String NomeMae, String Cpf, DateTime Nascimento, String Logradouro, Int32 Numero, String Complemento, Int32 IdBairro, Int32 IdCidade, Int32 IdNaturalidade, Int32 IdTipoLogradouro, Int32 IdEtnia, Int32 IdProfissao)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));
            dbCommand.Parameters.Add(new SqlParameter("@nomeMae", NomeMae));
            dbCommand.Parameters.Add(new SqlParameter("@cpf", Cpf));
            dbCommand.Parameters.Add(new SqlParameter("@nascimento", Nascimento));
            dbCommand.Parameters.Add(new SqlParameter("@logradouro", Logradouro));
            dbCommand.Parameters.Add(new SqlParameter("@complemento", Complemento));
            dbCommand.Parameters.Add(new SqlParameter("@numero", Numero));
            dbCommand.Parameters.Add(new SqlParameter("@idBairro", IdBairro));
            dbCommand.Parameters.Add(new SqlParameter("@idCidade", IdCidade));
            dbCommand.Parameters.Add(new SqlParameter("@idNaturalidade", IdNaturalidade));
            dbCommand.Parameters.Add(new SqlParameter("@idEtnia", IdEtnia));
            dbCommand.Parameters.Add(new SqlParameter("@idProfissao", IdProfissao));
            dbCommand.Parameters.Add(new SqlParameter("@idTipoLogradouro", IdTipoLogradouro));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Delete(PacienteEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idPaciente", Item.Id));

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

            dbCommand.CommandText = "SP_Paciente_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idPaciente", Id));

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

        public int Update(PacienteEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idPaciente", Item.Id));
            dbCommand.Parameters.Add(new SqlParameter("@nome", Item.Nome));
            dbCommand.Parameters.Add(new SqlParameter("@nomeMae", Item.NomeMae));
            dbCommand.Parameters.Add(new SqlParameter("@cpf", Item.Cpf));
            dbCommand.Parameters.Add(new SqlParameter("@nascimento", Item.Nascimento));
            dbCommand.Parameters.Add(new SqlParameter("@logradouro", Item.Logradouro));
            dbCommand.Parameters.Add(new SqlParameter("@complemento", Item.Complemento));
            dbCommand.Parameters.Add(new SqlParameter("@numero", Item.Numero));
            dbCommand.Parameters.Add(new SqlParameter("@idBairro", Item.IdBairro));
            dbCommand.Parameters.Add(new SqlParameter("@idCidade", Item.IdBairro));
            dbCommand.Parameters.Add(new SqlParameter("@idNaturalidade", Item.IdNaturalidade));
            dbCommand.Parameters.Add(new SqlParameter("@idEtnia", Item.IdEtnia));
            dbCommand.Parameters.Add(new SqlParameter("@idProfissao", Item.IdProfissao));
            dbCommand.Parameters.Add(new SqlParameter("@idTipoLogradouro", Item.IdTipoLogradouro));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }
        public int Update(Int32 Id, String Nome, String NomeMae, String Cpf, DateTime Nascimento, String Logradouro, Int32 Numero, String Complemento, Int32 IdBairro, Int32 IdCidade, Int32 IdNaturalidade, Int32 IdTipoLogradouro, Int32 IdEtnia, Int32 IdProfissao)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idPaciente", Id));
            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));
            dbCommand.Parameters.Add(new SqlParameter("@nomeMae", NomeMae));
            dbCommand.Parameters.Add(new SqlParameter("@cpf", Cpf));
            dbCommand.Parameters.Add(new SqlParameter("@nascimento", Nascimento));
            dbCommand.Parameters.Add(new SqlParameter("@logradouro", Logradouro));
            dbCommand.Parameters.Add(new SqlParameter("@complemento", Complemento));
            dbCommand.Parameters.Add(new SqlParameter("@numero", Numero));
            dbCommand.Parameters.Add(new SqlParameter("@idBairro", IdBairro));
            dbCommand.Parameters.Add(new SqlParameter("@idCidade", IdCidade));
            dbCommand.Parameters.Add(new SqlParameter("@idNaturalidade", IdNaturalidade));
            dbCommand.Parameters.Add(new SqlParameter("@idEtnia", IdEtnia));
            dbCommand.Parameters.Add(new SqlParameter("@idProfissao", IdProfissao));
            dbCommand.Parameters.Add(new SqlParameter("@idTipoLogradouro", IdTipoLogradouro));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public PacienteEntity Read(System.Int32 Id)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_GetUnique";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idPaciente", Id));

            SqlDataReader reader = null;
            PacienteEntity pacienteEnty = new PacienteEntity();

            reader = dbCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pacienteEnty.Id = reader.GetInt32(0);
                    pacienteEnty.Nome = reader.GetString(1);
                    pacienteEnty.NomeMae = reader.GetString(2);
                    pacienteEnty.Cpf = reader.GetString(3);
                    pacienteEnty.Nascimento = reader.GetDateTime(4);
                    pacienteEnty.Logradouro = reader.GetString(5);
                    pacienteEnty.Numero = reader.GetInt32(6);
                    pacienteEnty.Complemento = reader.GetString(7);
                    pacienteEnty.IdBairro = reader.GetInt32(8);
                    pacienteEnty.IdCidade = reader.GetInt32(9);
                    pacienteEnty.IdNaturalidade = reader.GetInt32(10);
                    pacienteEnty.IdTipoLogradouro = reader.GetInt32(11);
                    pacienteEnty.IdEtnia = reader.GetInt32(12);
                    pacienteEnty.IdProfissao = reader.GetInt32(13);
                }
            }

            dbConnection.Close();
            return pacienteEnty;
        }

        public DataTable ReadAll()
        {
            SqlDataAdapter adapterCidade;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_GetAll";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adapterCidade = new SqlDataAdapter(dbCommand);
            adapterCidade.Fill(table);

            dbConnection.Close();
            return table;
        }
    }
}
