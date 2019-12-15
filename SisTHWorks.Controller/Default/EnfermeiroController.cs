using SisTHWorks.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SisTHWorks.Controller
{
    public partial class EnfermeiroController
    {
        //Variaveis locais para string de conexão e acesso aos dados (command, connection);
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["SQLServerExpress"].ConnectionString;
        private SqlConnection dbConnection = null;
        private SqlCommand dbCommand = null;

        public EnfermeiroController() { }

        ~EnfermeiroController()
        {
            dbConnection = null;
            dbCommand = null;
        }

        public int Save(EnfermeiroEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Enfermeiro_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@nome", Item.Nome));
            dbCommand.Parameters.Add(new SqlParameter("@coren", Item.Coren));
            dbCommand.Parameters.Add(new SqlParameter("@login", Item.Login));
            dbCommand.Parameters.Add(new SqlParameter("@senha", Item.Senha));


            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }
        public int Save(System.String Nome, System.Int32 Coren, System.String Login, System.String Senha)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Enfermeiro_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));
            dbCommand.Parameters.Add(new SqlParameter("@coren", Coren));
            dbCommand.Parameters.Add(new SqlParameter("@login", Login));
            dbCommand.Parameters.Add(new SqlParameter("@senha", Senha));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Delete(EnfermeiroEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Enfermeiro_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@id", Item.Id));

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

            dbCommand.CommandText = "SP_Enfermeiro_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@id", Id));

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
        public int Update(EnfermeiroEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Enfermeiro_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idEnfermeiro", Item.Id));
            dbCommand.Parameters.Add(new SqlParameter("@nome", Item.Nome));
            dbCommand.Parameters.Add(new SqlParameter("@coren", Item.Coren));
            dbCommand.Parameters.Add(new SqlParameter("@login", Item.Login));
            dbCommand.Parameters.Add(new SqlParameter("@senha", Item.Senha));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Update(System.Int32 Id, System.String Nome, System.Int32 Coren, System.String Login, System.String Senha)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Enfermeiro_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idEnfermeiro", Id));
            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));
            dbCommand.Parameters.Add(new SqlParameter("@coren", Coren));
            dbCommand.Parameters.Add(new SqlParameter("@login", Login));
            dbCommand.Parameters.Add(new SqlParameter("@senha", Senha));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }
        public EnfermeiroEntity Read(System.Int32 Id)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Enfermeiro_GetUnique";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@idEnfermeiro", Id));

            SqlDataReader reader = null;
            EnfermeiroEntity enfermeiroEntity = new EnfermeiroEntity();

            reader = dbCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    enfermeiroEntity.Id = reader.GetInt32(0);
                    enfermeiroEntity.Nome = reader.GetString(1);
                    enfermeiroEntity.Coren = reader.GetInt32(2);
                    enfermeiroEntity.Login = reader.GetString(3);
                }
            }

            dbConnection.Close();
            return enfermeiroEntity;
        }
        public DataTable ReadAll()
        {
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Enfermeiro_GetAll";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(dbCommand);
            adapter.Fill(table);

            dbConnection.Close();
            return table;
        }

    }
}
