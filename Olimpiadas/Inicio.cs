using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpiadas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void crearLista()
        {
            string databasePath;
            // Crear un nuevo diálogo de Guardar Archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de base de datos SQLite (*.sqlite)|*.sqlite";
            saveFileDialog.Title = "Guardar base de datos";
            saveFileDialog.DefaultExt = "sqlite";
            saveFileDialog.AddExtension = true;

            // Mostrar el diálogo y verificar si el usuario hizo clic en Guardar
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta completa del archivo seleccionado por el usuario
                databasePath = saveFileDialog.FileName;
                string nombreLista = Path.GetFileNameWithoutExtension(databasePath);
                BDD ejercicios = new BDD(databasePath);
                // Crear la tabla de enunciados si no existe
                ejercicios.CrearTablaEnunciados();
                AlterarBDD ventanaAlterarBDD = new AlterarBDD(ejercicios);
                ventanaAlterarBDD.Show();
            }

            this.Hide();
        }
        private void modificarLista()
        {
            // Crear un OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer el filtro de archivos para mostrar solo archivos SQLite
            openFileDialog.Filter = "Archivos SQLite|*.sqlite|Todos los archivos|*.*";

            // Mostrar el diálogo de apertura de archivo
            DialogResult result = openFileDialog.ShowDialog();

            // Verificar si se seleccionó un archivo
            if (result == DialogResult.OK)
            {
                abrirArchivo(openFileDialog);
            }
        }

        private void abrirArchivo(OpenFileDialog openFileDialog)
        {
            BDD ejercicios;
            // Obtener la ruta del archivo seleccionado
            string archivoSeleccionado = openFileDialog.FileName;

            // Crear una instancia de BDD con el archivo seleccionado
            ejercicios = new BDD(archivoSeleccionado);

            // Abrir la ventana AlterarBDD y pasar la instancia de BDD como parámetro
            AlterarBDD ventanaAlterarBDD = new AlterarBDD(ejercicios);
            ventanaAlterarBDD.Show();
            this.Hide();
        }
        private void botonCrear_Click(object sender, EventArgs e)
        {
            crearLista();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            modificarLista();
        }
    }
}
