using DesktopAppGimnasio.Models;
using System.Data;
using System.Data.SqlClient;

namespace DesktopAppGimnasio._Repositories
{
    internal class TipoCuotaRepository : BaseRepository, ITipoCuotaRepository
    {
        // Constructor
        public TipoCuotaRepository(String conecctionString) 
        {
            this.connectionString = conecctionString;
        }

        // Methods
        public void Edit(TipoCuotaModel tipoCuotaModel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                using (SqlCommand command = connection.CreateCommand()) 
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE tipos SET monto = @monto_nuevo
                                            WHERE id_tipo = @id_tipo_edit;";
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "id_tipo_edit",
                        SqlDbType = SqlDbType.Int,
                        Value = tipoCuotaModel.IdTipoCuota
                    });
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "monto_nuevo",
                        SqlDbType = SqlDbType.Float,
                        Value = tipoCuotaModel.Monto
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<TipoCuotaModel> GetAll()
        {
            List<TipoCuotaModel> tiposCuotaList = new List<TipoCuotaModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand()) 
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT id_tipo, descripcion, monto
                                            FROM tipos;";

                    using(SqlDataReader reader = command.ExecuteReader()) 
                    {
                        
                        while (reader.Read())
                        {
                            TipoCuotaModel tipoCuotaModel = new TipoCuotaModel();

                            tipoCuotaModel.IdTipoCuota = (int) reader[0];
                            tipoCuotaModel.Descripcion = (String) reader[1];
                            tipoCuotaModel.Monto = (float)(double) reader[2];

                            tiposCuotaList.Add(tipoCuotaModel);
                        }
                    }
                }
            }

            return tiposCuotaList;
        }

        public IEnumerable<float> GetAllAmounts() 
        {
            List<float> amounts = new List<float>();

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                using (SqlCommand command = connection.CreateCommand()) 
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT monto
                                            FROM tipos;";

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read()) 
                        {
                            amounts.Add((float)(double) reader[0]);
                        }
                    }
                }
            }

            return amounts;
        }
    }
}
