using SisTHWorks.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SisTHWorks.Controller
{
    public partial class CidadeController
    {
        //Variaveis locais para string de conexão e acesso aos dados (command, connection);
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["SQLServerExpress"].ConnectionString;
        private SqlConnection dbConnection = null;
        private SqlCommand dbCommand = null;

        //Construtor da classe
        public CidadeController()
        {

        }

        //Destrututor da classe
        ~CidadeController()
        {
            dbConnection = null;
            dbCommand = null;
        }

        public int Save(CidadeEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Cidade_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@nome", Item.Nome));
            dbCommand.Parameters.Add(new SqlParameter("@uf", Item.Uf));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Save(System.String Nome, System.String Uf)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Cidade_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));
            dbCommand.Parameters.Add(new SqlParameter("@uf", Uf));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Delete(CidadeEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Cidade_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idCidade", Item.Id));

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

            dbCommand.CommandText = "SP_Cidade_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idCidade", Id));

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

        public int Update(CidadeEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Cidade_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idCidade", Item.Id));
            dbCommand.Parameters.Add(new SqlParameter("@nome", Item.Nome));
            dbCommand.Parameters.Add(new SqlParameter("@uf", Item.Uf));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }
        public int Update(System.Int32 Id, System.String Nome, System.String Uf)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Cidade_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idCidade", Id));
            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));
            dbCommand.Parameters.Add(new SqlParameter("@uf", Uf));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public CidadeEntity Read(System.Int32 Id)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Cidade_GetUnique";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idCidade", Id));

            SqlDataReader reader = null;
            CidadeEntity CidadeEnty = new CidadeEntity();

            reader = dbCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CidadeEnty.Id = reader.GetInt32(0);
                    CidadeEnty.Nome = reader.GetString(1);
                    CidadeEnty.Uf = reader.GetString(2);
                }
            }

            dbConnection.Close();
            return CidadeEnty;
        }

        public DataTable ReadAll()
        {
            SqlDataAdapter adapterCidade;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Cidade_GetAll";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adapterCidade = new SqlDataAdapter(dbCommand);
            adapterCidade.Fill(table);

            dbConnection.Close();
            return table;
        }
    }
}
