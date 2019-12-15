using SisTHWorks.Model;
using System;
using System.Data.SqlClient;

namespace SisTHWorks.Controller
{
    public partial class ClassificacaoController
    {
        public ClassificacaoEntity ReadClassificacao(Int32 Fluxograma, Int32 Discriminador)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dbCommand = new SqlCommand();
            dbCommand.Connection = dbConnection;

            dbCommand.CommandText = "SP_Classificacao_GetClassificacao";
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dbCommand.Parameters.Add(new SqlParameter("@fluxograma", Fluxograma));
            dbCommand.Parameters.Add(new SqlParameter("@discriminador", Discriminador));

            SqlDataReader reader = null;
            ClassificacaoEntity classificacaoEntity = new ClassificacaoEntity();

            reader = dbCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    classificacaoEntity.Id = reader.GetInt32(0);
                    classificacaoEntity.Fluxograma = reader.GetInt32(1);
                    classificacaoEntity.Discriminador = reader.GetInt32(2);
                    classificacaoEntity.Cor = reader.GetInt32(3);
                }
            }

            dbConnection.Close();
            return classificacaoEntity;
        }
    }
}
