using SisTHWorks.Model;
using System;
using System.Data.SqlClient;

namespace SisTHWorks.Controller
{
    public partial class EnfermeiroController
    {
        public EnfermeiroEntity Login(String Usuario, String Senha)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Enfermeiro_Login";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@usuario", Usuario));
            dbCommand.Parameters.Add(new SqlParameter("@senha", Senha));

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
    }
}
