using DesktopAppGimnasio.Models;
using System.Data;
using System.Data.SqlClient;

namespace DesktopAppGimnasio._Repositories
{
    public class SocioRepository : BaseRepository, ISocioRepository
    {

        // Constructor
        public SocioRepository(String connectionString) 
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(SocioModel socioModel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO socios (DNI, nombre, apellido, esta_activo)
                                            VALUES (@DNI_nuevo, @nombre_nuevo, @apellido_nuevo, 1);";
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "DNI_nuevo",
                        SqlDbType = SqlDbType.VarChar,
                        Value = socioModel.DNI
                    }) ;
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "nombre_nuevo",
                        SqlDbType = SqlDbType.VarChar,
                        Value = socioModel.Nombre
                    });
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "apellido_nuevo",
                        SqlDbType = SqlDbType.VarChar,
                        Value = socioModel.Apellido
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit(SocioModel socioModel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE socios SET DNI = @DNI_nuevo, nombre = @nombre_nuevo, apellido = @apellido_nuevo, esta_activo = @estado_nuevo
                                           WHERE codigo_socio = @codigoSocio;";
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "codigoSocio",
                        SqlDbType = SqlDbType.Int,
                        Value = socioModel.CodigoSocio
                    });
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "DNI_nuevo",
                        SqlDbType = SqlDbType.VarChar,
                        Value = socioModel.DNI
                    });
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "nombre_nuevo",
                        SqlDbType = SqlDbType.VarChar,
                        Value = socioModel.Nombre
                    });
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "apellido_nuevo",
                        SqlDbType = SqlDbType.VarChar,
                        Value = socioModel.Apellido
                    });
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "estado_nuevo",
                        SqlDbType = SqlDbType.Bit,
                        Value = socioModel.EstaActivo
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int codigoSocio)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"DELETE FROM socios
                                            WHERE codigo_socio = @codigoSocio;";
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "codigoSocio",
                        SqlDbType = SqlDbType.Int,
                        Value = codigoSocio
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool IsActive(int codigoSocio) 
        {
            bool state;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using(SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT esta_activo
                                            FROM socios
                                            WHERE codigo_socio = @codigoSocio";
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "codigoSocio",
                        SqlDbType = SqlDbType.Int,
                        Value = codigoSocio
                    });

                    state = (bool) command.ExecuteScalar();
                }
            }

            return state;
        }

        public void ReactivateSocio(int codigoSocio) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE socios SET esta_activo = true
                                            WHERE codigo_socio = @codigoSocio";
                    command.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "codigoSocio",
                        SqlDbType = SqlDbType.Int,
                        Value = codigoSocio
                    });

                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<SocioModel> GetAll()
        {
            List<SocioModel> sociosList = new List<SocioModel>();

            using(SqlConnection connection = new SqlConnection(connectionString)) 
            {

                using (SqlCommand command = connection.CreateCommand()) 
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT codigo_socio, DNI, nombre, apellido, esta_activo
                                            FROM socios
                                            ORDER BY codigo_socio DESC;";

                    using (SqlDataReader reader = command.ExecuteReader()) 
                    {
                    
                        while (reader.Read()) 
                        {
                            SocioModel socio = new SocioModel();

                            socio.CodigoSocio = (int) reader[0];
                            socio.DNI = (String) reader[1];
                            socio.Nombre = (String) reader[2];
                            socio.Apellido = (String) reader[3];
                            socio.EstaActivo = (bool) reader[4];

                            sociosList.Add(socio);
                        }
                    }
                }
            }

            return sociosList;
        }

        public IEnumerable<SocioModel> GetByValue(string value)
        {
            List<SocioModel> sociosList = new List<SocioModel>();
            int codigoSocio = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            String nombreYApellidoSocio = "%" + value + "%";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM socios
                                            WHERE codigo_socio = @numero_socio OR nombre LIKE @nombre_y_apellido OR apellido like @nombre_y_apellido OR
                                                  CONCAT(nombre, ' ', apellido) LIKE @nombre_y_apellido
                                            ORDER BY codigo_socio DESC;";
                    command.Parameters.Add(new SqlParameter(){
                        ParameterName = "@numero_socio",
                        SqlDbType = SqlDbType.Int,
                        Value = codigoSocio
                    });
                    command.Parameters.Add(new SqlParameter() {
                        ParameterName = "@nombre_y_apellido",
                        SqlDbType = SqlDbType.VarChar,
                        Value = nombreYApellidoSocio
                    });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            SocioModel socio = new SocioModel();

                            socio.CodigoSocio = (int) reader[0];
                            socio.DNI = (String) reader[1];
                            socio.Nombre = (String) reader[2];
                            socio.Apellido = (String) reader[3];
                            socio.EstaActivo = (bool) reader[4];

                            sociosList.Add(socio);
                        }
                    }
                }
            }

            return sociosList;
        }
    }
}
