using System;
using System.Data.SQLite;
using System.Reflection.Metadata;

namespace Olimpiadas
{
    public class BDD
    {
        private string connectionString;
        public string nombre;

        public BDD(string databasePath)
        {
            nombre = Path.GetFileNameWithoutExtension(databasePath);
            connectionString = $"Data Source=\"{databasePath}\";Version=3;";
        }

        // Método para crear la tabla de enunciados si no existe
        public void CrearTablaEnunciados()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS enunciados (
                    id INTEGER PRIMARY KEY,
                    nombre TEXT,
                    categoria INTEGER,
                    avanzado INTEGER,
                    decimal1 INTEGER,
                    decimal2 INTEGER,
                    decimal3 INTEGER,
                    decimal4 INTEGER,
                    curso INTEGER,
                    inicio1 REAL,
                    final1 REAL,
                    inicio2 REAL,
                    final2 REAL,
                    inicio3 REAL,
                    final3 REAL,
                    inicio4 REAL,
                    final4 REAL,
                    enunciado TEXT,
                    imagen BLOB,
                    respuesta REAL,
                    variable1 REAL,
                    variable2 REAL,
                    variable3 REAL,
                    variable4 REAL,
                    tipo TEXT
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
                                Categoria = Convert.ToInt32(reader["categoria"]),
                                Avanzado = Convert.ToInt32(reader["avanzado"]) == 1,
                                Decimal1 = Convert.ToInt32(reader["decimal1"]) == 1,
                                Decimal2 = Convert.ToInt32(reader["decimal2"]) == 1,
                                Decimal3 = Convert.ToInt32(reader["decimal3"]) == 1,
                                Decimal4 = Convert.ToInt32(reader["decimal4"]) == 1,
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
                                Respuesta = Convert.ToDouble(reader["respuesta"]),
                                Variable1 = Convert.ToDouble(reader["variable1"]),
                                Variable2 = Convert.ToDouble(reader["variable2"]),
                                Variable3 = Convert.ToDouble(reader["variable3"]),
                                Variable4 = Convert.ToDouble(reader["variable4"]),
                                Formula = Convert.ToString(reader["tipo"])
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
                nombre, categoria, avanzado, decimal1, decimal2, decimal3, decimal4, curso, inicio1, final1, inicio2, final2,
                inicio3, final3, inicio4, final4, enunciado, imagen, respuesta, variable1, variable2, variable3, variable4, tipo
            ) VALUES (
                @nombre, @categoria, @avanzado, @decimal1, @decimal2, @decimal3, @decimal4, @curso, @inicio1, @final1, @inicio2, @final2,
                @inicio3, @final3, @inicio4, @final4, @enunciado, @imagen, @respuesta, @variable1, @variable2, @variable3, @variable4, @tipo
            )";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@nombre", enunciado.Nombre);
                    command.Parameters.AddWithValue("@categoria", enunciado.Categoria);
                    command.Parameters.AddWithValue("@avanzado", enunciado.Avanzado ? 1 : 0);
                    command.Parameters.AddWithValue("@decimal1", enunciado.Decimal1 ? 1 : 0);
                    command.Parameters.AddWithValue("@decimal2", enunciado.Decimal2 ? 1 : 0);
                    command.Parameters.AddWithValue("@decimal3", enunciado.Decimal3 ? 1 : 0);
                    command.Parameters.AddWithValue("@decimal4", enunciado.Decimal4 ? 1 : 0);
                    command.Parameters.AddWithValue("@curso", enunciado.Curso);
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
                    command.Parameters.AddWithValue("@variable1", enunciado.Variable1);
                    command.Parameters.AddWithValue("@variable2", enunciado.Variable2);
                    command.Parameters.AddWithValue("@variable3", enunciado.Variable3);
                    command.Parameters.AddWithValue("@variable4", enunciado.Variable4);
                    command.Parameters.AddWithValue("@tipo", enunciado.Formula); // Nuevo parámetro para el campo "tipo"

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
        public int ObtenerIdMasAlto() {
            int idMasAlto = 0;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                connection.Open();
                string selectQuery = "SELECT MAX(id) FROM enunciados"; // Consulta SQL para obtener el máximo id

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection)) {
                    object resultado = command.ExecuteScalar(); // Ejecutar la consulta y obtener el resultado

                    if (resultado != null && resultado != DBNull.Value) {
                        idMasAlto = Convert.ToInt32(resultado); // Convertir a entero
                    }
                }
            }
            return idMasAlto;
        }
        public void ActualizarEnunciado(EnunciadoBase enunciado)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string updateQuery = @"
            UPDATE enunciados
            SET nombre = @nombre,
                categoria = @categoria,
                avanzado = @avanzado,
                decimal1 = @decimal1,
                decimal2 = @decimal2,
                decimal3 = @decimal3,
                decimal4 = @decimal4,
                curso = @curso,
                inicio1 = @inicio1,
                final1 = @final1,
                inicio2 = @inicio2,
                final2 = @final2,
                inicio3 = @inicio3,
                final3 = @final3,
                inicio4 = @inicio4,
                final4 = @final4,
                enunciado = @enunciado,
                imagen = @imagen,
                respuesta = @respuesta,
                variable1 = @variable1,
                variable2 = @variable2,
                variable3 = @variable3,
                variable4 = @variable4,
                tipo = @tipo
            WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@nombre", enunciado.Nombre);
                    command.Parameters.AddWithValue("@categoria", enunciado.Categoria);
                    command.Parameters.AddWithValue("@avanzado", enunciado.Avanzado ? 1 : 0);
                    command.Parameters.AddWithValue("@decimal1", enunciado.Decimal1 ? 1 : 0);
                    command.Parameters.AddWithValue("@decimal2", enunciado.Decimal2 ? 1 : 0);
                    command.Parameters.AddWithValue("@decimal3", enunciado.Decimal3 ? 1 : 0);
                    command.Parameters.AddWithValue("@decimal4", enunciado.Decimal4 ? 1 : 0);
                    command.Parameters.AddWithValue("@curso", enunciado.Curso);
                    command.Parameters.AddWithValue("@inicio1", enunciado.Inicio1);
                    command.Parameters.AddWithValue("@final1", enunciado.Final1);
                    command.Parameters.AddWithValue("@inicio2", enunciado.Inicio2);
                    command.Parameters.AddWithValue("@final2", enunciado.Final2);
                    command.Parameters.AddWithValue("@inicio3", enunciado.Inicio3);
                    command.Parameters.AddWithValue("@final3", enunciado.Final3);
                    command.Parameters.AddWithValue("@inicio4", enunciado.Inicio4);
                    command.Parameters.AddWithValue("@final4", enunciado.Final4);
                    command.Parameters.AddWithValue("@enunciado", enunciado.Enunciado);
                    command.Parameters.AddWithValue("@imagen", enunciado.Imagen ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@respuesta", enunciado.Respuesta);
                    command.Parameters.AddWithValue("@variable1", enunciado.Variable1);
                    command.Parameters.AddWithValue("@variable2", enunciado.Variable2);
                    command.Parameters.AddWithValue("@variable3", enunciado.Variable3);
                    command.Parameters.AddWithValue("@variable4", enunciado.Variable4);
                    command.Parameters.AddWithValue("@tipo", enunciado.Formula);
                    command.Parameters.AddWithValue("@id", enunciado.Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}