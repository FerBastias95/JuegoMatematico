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
            connectionString = $"Data Source=\"miBaseDeDatos.sqlite\";Version=3;";
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
                    imagen BLOB
                )";

                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
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
                inicio3, final3, inicio4, final4, enunciado, imagen
            ) VALUES (
                @nombre, @categoria, @usarVariables, @avanzado, @curso, @inicio1, @final1, @inicio2, @final2,
                @inicio3, @final3, @inicio4, @final4, @enunciado, @imagen
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

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}