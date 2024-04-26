using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Reflection.Metadata;

namespace Ejercicios
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
        public List<EnunciadoBase> ObtenerTodosEnunciadosAvanzados() {
            List<EnunciadoBase> enunciados = new List<EnunciadoBase>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                connection.Open();

                string selectQuery = "SELECT * FROM enunciados where avanzado = 1";

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection)) {
                    using (SQLiteDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            byte[] imagen = null;
                            object imagenObj = reader["imagen"];
                            if (imagenObj != DBNull.Value) {
                                imagen = (byte[])imagenObj;
                            }
                            EnunciadoBase enunciado = new EnunciadoBase {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = Convert.ToString(reader["nombre"]),
                                Categoria = Convert.ToInt32(reader["categoria"]),
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
    }
}
