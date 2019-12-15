
using System.Data;
using System.Data.SqlClient;

namespace SisTHWorks.Controller
{
    public partial class AtendimentoController
    {
        public DataTable ReadRel()
        {
            SqlDataAdapter adapterCidade;
            DataTable table = new DataTable();

            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Atendimento_GetRel";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            adapterCidade = new SqlDataAdapter(dbCommand);
            adapterCidade.Fill(table);

            dbConnection.Close();
            return table;
        }
    }
}
