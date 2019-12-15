using SisTHWorks.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SisTHWorks.Controller
{
    public partial class ClassificacaoController
    {
        //Variaveis locais para string de conexão e acesso aos dados (command, connection);
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["SQLServerExpress"].ConnectionString;
        private SqlConnection dbConnection = null;
        private SqlCommand dbCommand = null;

        public ClassificacaoController() { }

        ~ClassificacaoController()
        {
            dbConnection = null;
            dbCommand = null;
        }

        public int Save(ClassificacaoEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Classificao_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@fluxograma", Item.Fluxograma));
            dbCommand.Parameters.Add(new SqlParameter("@discriminador", Item.Discriminador));
            dbCommand.Parameters.Add(new SqlParameter("@cor", Item.Cor));


            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }
        public int Save(System.Int32 Fluxograma, System.Int32 Discriminador, System.Int32 Cor)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Classificacao_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@fluxograma", Fluxograma));
            dbCommand.Parameters.Add(new SqlParameter("@discriminador", Discriminador));
            dbCommand.Parameters.Add(new SqlParameter("@cor", Cor));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Delete(ClassificacaoEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Classificacao_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idClassificacao", Item.Id));

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

            dbCommand.CommandText = "SP_Classificacao_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idClassificacao", Id));

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
        public int Update(ClassificacaoEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Classificacao_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@id", Item.Id));
            dbCommand.Parameters.Add(new SqlParameter("@fluxograma", Item.Fluxograma));
            dbCommand.Parameters.Add(new SqlParameter("@discriminador", Item.Discriminador));
            dbCommand.Parameters.Add(new SqlParameter("@cor", Item.Cor));

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

        public int Update(System.Int32 Id, System.Int32 Fluxograma, System.Int32 Discriminador, System.Int32 Cor)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Classificacao_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idClassificacao", Id));
            dbCommand.Parameters.Add(new SqlParameter("@fluxograma", Fluxograma));
            dbCommand.Parameters.Add(new SqlParameter("@discriminador", Discriminador));
            dbCommand.Parameters.Add(new SqlParameter("@cor", Cor));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }
        public ClassificacaoEntity Read(System.Int32 Id)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Classificacao_GetUnique";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idClassificacao", Id));

            SqlDataReader reader = null;
            ClassificacaoEntity classificacaoEntity = new ClassificacaoEntity();

            reader = dbCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    classificacaoEntity.Id = reader.GetInt32(0);
                    classificacaoEntity.Cor = reader.GetInt32(1);
                    classificacaoEntity.Fluxograma = reader.GetInt32(2);
                    classificacaoEntity.Discriminador = reader.GetInt32(3);
                }
            }

            dbConnection.Close();
            return classificacaoEntity;
        }
        public DataTable ReadAll()
        {
            SqlDataAdapter adapterCidade;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Classificacao_GetAll";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adapterCidade = new SqlDataAdapter(dbCommand);
            adapterCidade.Fill(table);

            dbConnection.Close();
            return table;
        }
    }
}
