using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Olimpiadas
{
    public partial class AlterarBDD : Form {
        private List<EnunciadoBase> enunciados;
        BDD BaseEnunciados;
        private int ultimoId = 0;
        bool loaded = false;

        public AlterarBDD(BDD info) {
            // Opcional: Habilitar doble búfer para reducir parpadeo
            this.DoubleBuffered = true;

            // Establecer un color de fondo que no interfiera (aunque no será visible)
            this.BackColor = Color.White;
            BaseEnunciados = info;
            InitializeComponent();
            enunciados = new List<EnunciadoBase>(); // Inicializar la lista de enunciados

            // Cargar los enunciados desde la base de datos al iniciar el formulario
            CargarEnunciadosDesdeBaseDatos(BaseEnunciados);
        }

        public void HabilitarFunciones() {
            if (enunciados.Count > 0) {
                NombreEnunciado.Enabled = true;
                textoEnunciado.Enabled = true;
                resultadoEnunciado.Enabled = true;
                abrirAvanzado.Enabled = true;
                abrirImagen.Enabled = true;
                NombreEnunciado.Enabled = true;
                listBoxEnunciados.Enabled = true;
                if (enunciados[listBoxEnunciados.SelectedIndex].Avanzado == true) {
                    textoEnunciado.Enabled = false;
                    textoEnunciado.BackColor = Color.MistyRose;
                    resultadoEnunciado.Enabled = false;
                }
                else {
                    textoEnunciado.Enabled = true;
                    textoEnunciado.BackColor = Color.White;
                    resultadoEnunciado.Enabled = true;
                    VistaPrevia.Enabled = true;
                }
            }
            else {
                NombreEnunciado.Enabled = false;
                NombreEnunciado.Text = "";
                textoEnunciado.Enabled = false;
                textoEnunciado.Text = "";
                resultadoEnunciado.Enabled = false;
                resultadoEnunciado.Text = "";
                abrirAvanzado.Enabled = false;
                abrirImagen.Enabled = false;
                VistaPrevia.Enabled = false;
            }
        }
        private void CargarEnunciadosDesdeBaseDatos(BDD info) {
            loaded = false;
            listBoxEnunciados.Items.Clear();
            // Obtener todos los enunciados de la base de datos
            enunciados = info.ObtenerTodosEnunciados();
            if (enunciados.Count > 0) {
                foreach (EnunciadoBase enunciado in enunciados) {
                    listBoxEnunciados.Items.Add(enunciado.Nombre);
                }
                ultimoId = info.ObtenerIdMasAlto();
                VistaPrevia.Enabled = true;
                listBoxEnunciados.SelectedIndex = 0;
                HabilitarFunciones();
            }
            loaded = true;
        }
        private void EliminarEnunciadoDeBaseDatos(EnunciadoBase enunciado) {
            loaded = false;
            BaseEnunciados.EliminarEnunciado(enunciado.Id);
            loaded = true;
        }
        private void ActualizarListaEnunciados(int index) {
            loaded = false;
            listBoxEnunciados.Items.Clear();
            int lastIndex;
            foreach (EnunciadoBase enunciado in enunciados) {
                listBoxEnunciados.Items.Add(enunciado.Nombre);
            }
            lastIndex = listBoxEnunciados.Items.Count - 1;
            if (index > lastIndex) {
                listBoxEnunciados.SelectedIndex = lastIndex;
            }
            else {
                listBoxEnunciados.SelectedIndex = index;
            }
            loaded = true;
        }
        private void ActualizarBaseDeDatos() {
            if (loaded) {
                int seleccion = listBoxEnunciados.SelectedIndex;
                enunciados[seleccion].Enunciado = textoEnunciado.Text.ToString();
                enunciados[seleccion].Nombre = NombreEnunciado.Text;
                bool esPosible = double.TryParse(resultadoEnunciado.Text, out double test);
                if (esPosible) {
                    enunciados[seleccion].Respuesta = double.Parse(resultadoEnunciado.Text);
                }
                listBoxEnunciados.Items[seleccion] = NombreEnunciado.Text;
                BaseEnunciados.ActualizarEnunciado(enunciados[seleccion]);
            }
        }
        public void CargarDatos(EnunciadoBase e) {
            loaded = false;
            NombreLista.Text = BaseEnunciados.nombre;
            HabilitarFunciones();
            if (listBoxEnunciados.SelectedIndex >= 0 && listBoxEnunciados.SelectedIndex < enunciados.Count) {
                NombreEnunciado.Text = e.Nombre;
                textoEnunciado.Text = e.Enunciado;
                resultadoEnunciado.Text = e.Respuesta.ToString();
                if (e.Avanzado == true) {
                    resultadoEnunciado.Text = e.Formula;
                }
                if (e.Imagen != null) {
                    using (MemoryStream ms = new MemoryStream(e.Imagen)) {
                        imagenEnunciado.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else {
                    imagenEnunciado.Image = null;
                }
            }
            loaded = true;
        }
        public void ActualizarAvanzado(string enunciado, string resultado) {
            textoEnunciado.Text = enunciado;
            resultadoEnunciado.Text = resultado;
        }
        private void crearEnunciado() {
            // Incrementar el último ID utilizado
            ultimoId++;

            // Generar un nombre predeterminado para el nuevo enunciado
            string nuevoNombre = "Enunciado " + ultimoId;

            // Crear un nuevo enunciado con valores predeterminados
            EnunciadoBase nuevoEnunciado = new EnunciadoBase {
                Id = ultimoId,
                Nombre = nuevoNombre,
                Categoria = 0, // Valor predeterminado para la categoría
                Avanzado = false,         // Valor predeterminado para Avanzado
                Decimal1 = false,
                Decimal2 = false,
                Decimal3 = false,
                Decimal4 = false,
                Curso = 0,                // Valor predeterminado para Curso
                Inicio1 = 0,              // Valor predeterminado para Inicio1
                Final1 = 0,               // Valor predeterminado para Final1
                Inicio2 = 0,              // Valor predeterminado para Inicio2
                Final2 = 0,               // Valor predeterminado para Final2
                Inicio3 = 0,              // Valor predeterminado para Inicio3
                Final3 = 0,               // Valor predeterminado para Final3
                Inicio4 = 0,              // Valor predeterminado para Inicio4
                Final4 = 0,               // Valor predeterminado para Final4
                Enunciado = string.Empty, // Valor predeterminado para el enunciado
                Imagen = null,            // Valor predeterminado para la imagen
                Respuesta = 0,            // Valor predeterminado para la respuesta
                Formula = string.Empty
            };

            // Insertar el nuevo enunciado en la base de datos
            BaseEnunciados.InsertarEnunciado(nuevoEnunciado);

            // Agregar el nuevo enunciado a la lista de enunciados
            enunciados.Add(nuevoEnunciado);

            // Agregar el nombre del nuevo enunciado al ListBox
            listBoxEnunciados.Items.Add(nuevoEnunciado.Nombre);

            // Seleccionar el nuevo enunciado recién creado
            listBoxEnunciados.SelectedIndex = listBoxEnunciados.Items.Count - 1;

            CargarDatos(enunciados[listBoxEnunciados.SelectedIndex]);
        }
        private void abrirImagen_Click(object sender, EventArgs e) {
            // Crear un nuevo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer el filtro de archivos para mostrar solo imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Mostrar el diálogo
            DialogResult result = openFileDialog.ShowDialog();

            // Verificar si se seleccionó un archivo de imagen
            if (result == DialogResult.OK) {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Verificar el tamaño del archivo (en bytes)
                FileInfo fileInfo = new FileInfo(filePath);
                long fileSize = fileInfo.Length;

                // Verificar si el tamaño del archivo excede 1 MB (en bytes)
                if (fileSize > 1024 * 1024) // 1 MB = 1024 * 1024 bytes
                {
                    MessageBox.Show("La imagen seleccionada excede el tamaño máximo permitido (1 MB). Por favor, selecciona una imagen más pequeña.", "Tamaño de imagen excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    try {
                        // Leer la imagen como un arreglo de bytes
                        byte[] imageBytes = File.ReadAllBytes(filePath);

                        // Mostrar la imagen en el PictureBox
                        imagenEnunciado.SizeMode = PictureBoxSizeMode.Zoom; // Escalar y centrar la imagen
                        using (MemoryStream ms = new MemoryStream(imageBytes)) {
                            imagenEnunciado.Image = System.Drawing.Image.FromStream(ms); // Especificar System.Drawing.Image aquí
                        }

                        // Guardar los bytes de la imagen en la propiedad Imagen del enunciado (asumiendo que es un arreglo de bytes en la base de datos)
                        enunciados[listBoxEnunciados.SelectedIndex].Imagen = imageBytes;

                        ActualizarBaseDeDatos();
                    }
                    catch (Exception ex) {
                        MessageBox.Show($"Se produjo un error al intentar abrir la imagen:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void actualizarEnunciado_Click(object sender, EventArgs e) {

        }
        private void borrarEnunciado_Click(object sender, EventArgs e) {
            // Verificar si hay un enunciado seleccionado en la lista
            if (listBoxEnunciados.SelectedIndex >= 0) {
                // Obtener el índice del enunciado seleccionado
                int indiceSeleccionado = listBoxEnunciados.SelectedIndex;

                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];

                // Eliminar el enunciado de la lista
                enunciados.RemoveAt(indiceSeleccionado);

                // Eliminar el enunciado de la base de datos
                EliminarEnunciadoDeBaseDatos(enunciadoSeleccionado);

                // Actualizar la vista de la lista
                ActualizarListaEnunciados(indiceSeleccionado);
                HabilitarFunciones();
            }
        }

        private void nuevoEnunciado_Click(object sender, EventArgs e) {
            crearEnunciado();
        }
        private void AlterarBDD_FormClosed(object sender, FormClosedEventArgs e) {
            System.Windows.Forms.Application.Exit();
        }
        private void AlterarBDD_Load(object sender, EventArgs e) {
            NombreLista.Text = BaseEnunciados.nombre;
            imagenEnunciado.SizeMode = PictureBoxSizeMode.Zoom; // Escalar y centrar la imagen
            if (enunciados.Count > 0) {
                HabilitarFunciones();
                CargarDatos(enunciados[0]);
            }
        }

        private void listBoxEnunciados_SelectedIndexChanged(object sender, EventArgs e) {
            int indiceSeleccionado = listBoxEnunciados.SelectedIndex;
            if (indiceSeleccionado >= 0 && indiceSeleccionado < listBoxEnunciados.Items.Count) {
                CargarDatos(enunciados[indiceSeleccionado]);
            }
        }

        private void textoEnunciado_TextChanged(object sender, EventArgs e) {
            ActualizarBaseDeDatos();
        }

        private void resultadoEnunciado_TextChanged(object sender, EventArgs e) {
            ActualizarBaseDeDatos();
        }

        private void VistaPrevia_Click(object sender, EventArgs e) {
            VentanaEnunciadoImagen v = new VentanaEnunciadoImagen(enunciados[listBoxEnunciados.SelectedIndex]);
            v.ShowDialog();
        }

        private void abrirAvanzado_Click(object sender, EventArgs e) {
            if (listBoxEnunciados.SelectedIndex >= 0) {
                // Obtener el índice del enunciado seleccionado
                int indiceSeleccionado = listBoxEnunciados.SelectedIndex;

                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];
                //EnunciadoAvanzado adv = new EnunciadoAvanzado(BaseEnunciados, enunciadoSeleccionado);
                //adv.ShowDialog();
                EnunciadoAvanzado mv = new EnunciadoAvanzado(BaseEnunciados, enunciadoSeleccionado, this);
                mv.Show();
            }
        }

        private void NombreEnunciado_TextChanged(object sender, EventArgs e) {
            ActualizarBaseDeDatos();
        }

        private void cambiarBDD_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer el filtro de archivos para mostrar solo archivos SQLite
            openFileDialog.Filter = "Archivos SQLite|*.sqlite|Todos los archivos|*.*";

            // Mostrar el diálogo de apertura de archivo
            DialogResult result = openFileDialog.ShowDialog();

            // Verificar si se seleccionó un archivo
            if (result == DialogResult.OK) {
                // Obtener la ruta del archivo seleccionado
                string archivoSeleccionado = openFileDialog.FileName;
                string nombreLista = Path.GetFileNameWithoutExtension(archivoSeleccionado);
                // Asignar el nombre al TextBox
                NombreLista.Text = nombreLista;
                // Crear una instancia de BDD con el archivo seleccionado
                BDD BaseEnunciados2 = new BDD(archivoSeleccionado);
                BaseEnunciados = BaseEnunciados2;
                enunciados.Clear();
                enunciados = BaseEnunciados.ObtenerTodosEnunciados();
                ultimoId = BaseEnunciados.ObtenerIdMasAlto();
                CargarEnunciadosDesdeBaseDatos(BaseEnunciados);
            }
        }

        private void crearLista_Click(object sender, EventArgs e) {
            string databasePath;
            // Crear un nuevo diálogo de Guardar Archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de base de datos SQLite (*.sqlite)|*.sqlite";
            saveFileDialog.Title = "Guardar base de datos";
            saveFileDialog.DefaultExt = "sqlite";
            saveFileDialog.AddExtension = true;

            // Mostrar el diálogo y verificar si el usuario hizo clic en Guardar
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string archivoSeleccionado = saveFileDialog.FileName;
                string nombreLista = Path.GetFileNameWithoutExtension(archivoSeleccionado);
                // Asignar el nombre al TextBox
                NombreLista.Text = nombreLista;
                BDD BaseEnunciados2 = new BDD(archivoSeleccionado);
                BaseEnunciados = BaseEnunciados2;
                // Crear la tabla de enunciados si no existe
                BaseEnunciados.CrearTablaEnunciados();
                CargarEnunciadosDesdeBaseDatos(BaseEnunciados);
                HabilitarFunciones();
                ultimoId = 0;
            }
        }
    }
}