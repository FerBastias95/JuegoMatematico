using System;
using System.Data.SQLite;
using System.Reflection.Metadata;

namespace Olimpiadas
{
    public class BDD
    {
        private string connectionString;

        public BDD()
        {
            // Establecer la cadena de conexión utilizando la ruta del archivo de la base de datos
            connectionString = $"Data Source=\"Enunciados.sqlite\";Version=3;";
            // Crear la tabla de enunciados si no existe
            CrearTablaEnunciados();
        }

        // Método para crear la tabla de enunciados si no existe
        private void CrearTablaEnunciados()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS enunciados (
                    id INTEGER PRIMARY KEY,
                    nombre TEXT,
                    categoria TEXT,
                    usarVariables INTEGER,
                    avanzado INTEGER,
                    curso INTEGER,  
                    inicio1 INTEGER,
                    final1 INTEGER,
                    inicio2 INTEGER,
                    final2 INTEGER,
                    inicio3 INTEGER,
                    final3 INTEGER,
                    inicio4 INTEGER,
                    final4 INTEGER,
                    enunciado TEXT,
                    imagen BLOB,
                    respuesta REAL
                )";

                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<EnunciadoBase> ObtenerTodosEnunciados()
        {
            List<EnunciadoBase> enunciados = new List<EnunciadoBase>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM enunciados";

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imagen = null;
                            object imagenObj = reader["imagen"];
                            if (imagenObj != DBNull.Value)
                            {
                                imagen = (byte[])imagenObj;
                            }
                            EnunciadoBase enunciado = new EnunciadoBase
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = Convert.ToString(reader["nombre"]),
                                Categoria = Convert.ToString(reader["categoria"]),
                                UsarVariables = Convert.ToInt32(reader["usarVariables"]) == 1,
                                Avanzado = Convert.ToInt32(reader["avanzado"]) == 1,
                                Curso = Convert.ToInt32(reader["curso"]),
                                Inicio1 = Convert.ToInt32(reader["inicio1"]),
                                Final1 = Convert.ToInt32(reader["final1"]),
                                Inicio2 = Convert.ToInt32(reader["inicio2"]),
                                Final2 = Convert.ToInt32(reader["final2"]),
                                Inicio3 = Convert.ToInt32(reader["inicio3"]),
                                Final3 = Convert.ToInt32(reader["final3"]),
                                Inicio4 = Convert.ToInt32(reader["inicio4"]),
                                Final4 = Convert.ToInt32(reader["final4"]),
                                Enunciado = Convert.ToString(reader["enunciado"]),
                                Imagen = imagen,
                                Respuesta = Convert.ToDouble(reader["respuesta"])
                            };

                            enunciados.Add(enunciado);
                        }
                    }
                }
            }

            return enunciados;
        }

        // Método para insertar un enunciado en la base de datos
        public void InsertarEnunciado(EnunciadoBase enunciado)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
            INSERT INTO enunciados (
                nombre, categoria, usarVariables, avanzado, curso, inicio1, final1, inicio2, final2,
                inicio3, final3, inicio4, final4, enunciado, imagen, respuesta
            ) VALUES (
                @nombre, @categoria, @usarVariables, @avanzado, @curso, @inicio1, @final1, @inicio2, @final2,
                @inicio3, @final3, @inicio4, @final4, @enunciado, @imagen, @respuesta
            )";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Asignar parámetros
                    command.Parameters.AddWithValue("@nombre", enunciado.Nombre);
                    command.Parameters.AddWithValue("@categoria", enunciado.Categoria);
                    command.Parameters.AddWithValue("@usarVariables", enunciado.UsarVariables ? 1 : 0);
                    command.Parameters.AddWithValue("@avanzado", enunciado.Avanzado ? 1 : 0);
                    command.Parameters.AddWithValue("@curso", enunciado.Curso); // Nuevo parámetro para el campo "Curso"
                    command.Parameters.AddWithValue("@inicio1", enunciado.Inicio1);
                    command.Parameters.AddWithValue("@final1", enunciado.Final1);
                    command.Parameters.AddWithValue("@inicio2", enunciado.Inicio2);
                    command.Parameters.AddWithValue("@final2", enunciado.Final2);
                    command.Parameters.AddWithValue("@inicio3", enunciado.Inicio3);
                    command.Parameters.AddWithValue("@final3", enunciado.Final3);
                    command.Parameters.AddWithValue("@inicio4", enunciado.Inicio4);
                    command.Parameters.AddWithValue("@final4", enunciado.Final4);
                    command.Parameters.AddWithValue("@enunciado", enunciado.Enunciado);
                    command.Parameters.AddWithValue("@imagen", enunciado.Imagen);
                    command.Parameters.AddWithValue("@respuesta", enunciado.Respuesta);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarEnunciado(int idEnunciado)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM enunciados WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", idEnunciado);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}