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
            saveFileDialog.Title = "Crear lista de ejercicios";
            saveFileDialog.DefaultExt = "sqlite";
            saveFileDialog.AddExtension = true;

            // Mostrar el diálogo y verificar si el usuario hizo clic en Guardar
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                crearArchivo(saveFileDialog);
            }

            this.Hide();
        }
        private void modificarLista()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos SQLite|*.sqlite|Todos los archivos|*.*";
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
            string archivoSeleccionado = openFileDialog.FileName;

            // Crear una instancia de BDD con el archivo seleccionado
            ejercicios = new BDD(archivoSeleccionado);

            // Abrir la ventana AlterarBDD y pasar la instancia de BDD como parámetro
            AlterarBDD ventanaAlterarBDD = new AlterarBDD(ejercicios);
            ventanaAlterarBDD.Show();
            this.Hide();
        }

        private void crearArchivo(SaveFileDialog openFileDialog)
        {
            string archivoSeleccionado = openFileDialog.FileName;
            BDD ejercicios = new BDD(archivoSeleccionado);
            string nombreLista = Path.GetFileNameWithoutExtension(archivoSeleccionado);
            ejercicios.CrearTablaEnunciados();
            ejercicios.nombre = nombreLista;
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
