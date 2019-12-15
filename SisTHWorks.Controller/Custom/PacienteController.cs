using System;
using System.Data;
using System.Data.SqlClient;

namespace SisTHWorks.Controller
{
    public partial class PacienteController
    {
        public DataTable ReadByParametrs(String Nome, String Mae, DateTime Nascimento)
        {
            SqlDataAdapter adapterCidade;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_GetByParametrs";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));
            dbCommand.Parameters.Add(new SqlParameter("@mae", Mae));
            dbCommand.Parameters.Add(new SqlParameter("@nascimento", Nascimento));

            adapterCidade = new SqlDataAdapter(dbCommand);
            adapterCidade.Fill(table);

            dbConnection.Close();
            return table;
        }
        public DataTable ReadByParametrs(String Nome, String Mae)
        {
            SqlDataAdapter adapterCidade;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_GetByParametrs";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            dbCommand.Parameters.Add(new SqlParameter("@nome", Nome));
            dbCommand.Parameters.Add(new SqlParameter("@mae", Mae));


            adapterCidade = new SqlDataAdapter(dbCommand);
            adapterCidade.Fill(table);

            dbConnection.Close();
            return table;
        }
        public DataTable ReadByParametrs(Int32 Id)
        {
            SqlDataAdapter adapterCidade;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_GetByParametrs";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            dbCommand.Parameters.Add(new SqlParameter("@nome", ""));
            dbCommand.Parameters.Add(new SqlParameter("@mae", ""));
            dbCommand.Parameters.Add(new SqlParameter("@id", Id));
            

            adapterCidade = new SqlDataAdapter(dbCommand);
            adapterCidade.Fill(table);

            dbConnection.Close();
            return table;
        }
        public DataTable ReadUltimo()
        {
            SqlDataAdapter adapterCidade;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_GetUltimo";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adapterCidade = new SqlDataAdapter(dbCommand);
            adapterCidade.Fill(table);

            dbConnection.Close();
            return table;
        }
        public DataTable ReadRel()
        {
            SqlDataAdapter adapterCidade;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Paciente_GetRel";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adapterCidade = new SqlDataAdapter(dbCommand);
            adapterCidade.Fill(table);

            dbConnection.Close();
            return table;
        }
    }
}
