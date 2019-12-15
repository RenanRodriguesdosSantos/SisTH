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
    public partial class PadraoController{
        private String tabela;
        //Variaveis locais para string de conexão e acesso aos dados (command, connection);
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["SQLServerExpress"].ConnectionString;
        private SqlConnection dbConnection = null;
        private SqlCommand dbCommand = null;

        public PadraoController(String Tabela) {
            this.tabela = Tabela;
        }

        ~PadraoController()
        {
            dbConnection = null;
            dbCommand = null;
        }

        public int Save(System.String Nome)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_" + this.tabela + "_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Save(PadraoEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_" + this.tabela + "_Save";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@nome", Item.Nome));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Delete(PadraoEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_" + this.tabela + "_Delete";
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

            dbCommand.CommandText = "SP_" + this.tabela +  "_Delete";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@id"+this.tabela, Id));

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
        public int Update(PadraoEntity Item)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_" + this.tabela + "_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@id"+this.tabela, Item.Id));
            dbCommand.Parameters.Add(new SqlParameter("@nome", Item.Nome));

            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }

        public int Update(System.Int32 Id, System.String Nome)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_" + this.tabela + "_Update";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@id"+this.tabela, Id));
            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));


            int result = dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            return result;
        }
        public PadraoEntity Read(System.Int32 Id)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_" + this.tabela + "_GetUnique";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@id"+tabela, Id));

            SqlDataReader reader = null;
            PadraoEntity padraoEntity = new PadraoEntity();

            reader = dbCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    padraoEntity.Id = reader.GetInt32(0);
                    padraoEntity.Nome = reader.GetString(1);
                }
            }

            dbConnection.Close();
            return padraoEntity;
        }
        public DataTable ReadAll()
        {
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_" + this.tabela + "_GetAll";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(dbCommand);
            adapter.Fill(table);

            dbConnection.Close();
            return table;
        }
    }
}
