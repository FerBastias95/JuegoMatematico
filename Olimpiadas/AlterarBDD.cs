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
    public partial class AlterarBDD : Form
    {
        private List<EnunciadoBase> enunciados;
        BDD BaseEnunciados;
        private int ultimoId = 0;
        bool update;
        private bool actualizarCategoria = true; // Bandera para controlar la actualización de la categoría
        public AlterarBDD(BDD info)
        {
            update = false;
            BaseEnunciados = info;
            InitializeComponent();
            enunciados = new List<EnunciadoBase>(); // Inicializar la lista de enunciados

            // Cargar los enunciados desde la base de datos al iniciar el formulario
            CargarEnunciadosDesdeBaseDatos(BaseEnunciados);
        }
        private void CargarEnunciadosDesdeBaseDatos(BDD info)
        {
            listBoxEnunciados.Items.Clear();
            // Obtener todos los enunciados de la base de datos
            enunciados = info.ObtenerTodosEnunciados();

            if (enunciados.Count > 0)
            {
                foreach (EnunciadoBase enunciado in enunciados)
                {
                    listBoxEnunciados.Items.Add(enunciado.Nombre);
                }
                ultimoId = enunciados.Max(enun => enun.Id);
                listBoxEnunciados.SelectedIndex = 0;
            }
            else
            {
                NombreEnunciado.Text = "";
                cursoSeleccion.Text = "";
                categoria.Text = "";
                idEnunciado.Text = "";
            }
        }
        private void EliminarEnunciadoDeBaseDatos(EnunciadoBase enunciado)
        {
            BaseEnunciados.EliminarEnunciado(enunciado.Id);
        }
        private void ActualizarListaEnunciados(int index)
        {
            listBoxEnunciados.Items.Clear();
            int lastIndex;
            foreach (EnunciadoBase enunciado in enunciados)
            {
                listBoxEnunciados.Items.Add(enunciado.Nombre);
            }
            lastIndex = listBoxEnunciados.Items.Count - 1;
            if (index > lastIndex)
            {
                listBoxEnunciados.SelectedIndex = lastIndex;
            }
            else
            {
                listBoxEnunciados.SelectedIndex = index;
            }
        }
        private void ActualizarBaseDeDatos()
        {
            int seleccion = listBoxEnunciados.SelectedIndex;
            BaseEnunciados.ActualizarEnunciado(enunciados[seleccion]);
        }
        public void CargarDatos(EnunciadoBase e)
        {
            if (listBoxEnunciados.SelectedIndex >= 0 && listBoxEnunciados.SelectedIndex < enunciados.Count)
            {
                NombreEnunciado.Text = e.Nombre;
                cursoSeleccion.SelectedItem = e.Curso.ToString(); // Seleccionar el curso en el ComboBox
                categoria.SelectedIndex = e.Categoria;
                idEnunciado.Text = e.Id.ToString();
                tipoEnunciado.SelectedIndex = e.Tipo;
                textoEnunciado.Text = e.Enunciado;
                resultadoEnunciado.Text = e.Respuesta.ToString();
                if (e.Tipo == 1 || e.Tipo == 3)
                {
                    if (e.Imagen != null)
                    {
                        using (MemoryStream ms = new MemoryStream(e.Imagen))
                        {
                            imagenEnunciado.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        imagenEnunciado.Image = null;
                    }
                }

                ActualizarBaseDeDatos();
            }
        }
        private void habilitarFunciones()
        {
            if (listBoxEnunciados.Items.Count > 0)
            {
                NombreEnunciado.Enabled = true;
                cursoSeleccion.Enabled = true;
                categoria.Enabled = true;
                tipoEnunciado.Enabled = true;
                idEnunciado.Enabled = true;
                string curso = cursoSeleccion.SelectedIndex.ToString();
                string categoriatexto = categoria.SelectedIndex.ToString();
                // Obtener el índice del enunciado seleccionado
                int indiceSeleccionado = listBoxEnunciados.SelectedIndex;
                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];
                int tipo = enunciadoSeleccionado.Tipo;
                switch (tipo)
                {
                    case 0:
                        textoEnunciado.Enabled = true;
                        resultadoEnunciado.Enabled = true;
                        abrirImagen.Enabled = false;
                        imagenEnunciado.Enabled = false;
                        abrirAvanzado.Enabled = false;
                        textoEnunciado.Text = enunciadoSeleccionado.Enunciado; // Actualizar solo en este caso
                        NombreEnunciado.Text = enunciadoSeleccionado.Nombre;
                        enunciadoSeleccionado.Avanzado = false;
                        int test1;
                        bool esPosible1 = int.TryParse(cursoSeleccion.Text, out test1);
                        if (esPosible1)
                        {
                            enunciadoSeleccionado.Curso = int.Parse(cursoSeleccion.Text);
                        }
                        double test2;
                        bool esPosible2 = double.TryParse(resultadoEnunciado.Text, out test2);
                        if (esPosible2)
                        {
                            enunciadoSeleccionado.Respuesta = double.Parse(resultadoEnunciado.Text);
                        }
                        break;
                    case 1:
                        textoEnunciado.Enabled = false;
                        resultadoEnunciado.Enabled = false;
                        imagenEnunciado.Enabled = true;
                        abrirImagen.Enabled = true;
                        abrirAvanzado.Enabled = false;
                        textoEnunciado.Text = enunciadoSeleccionado.Enunciado; // Actualizar solo en este caso
                        NombreEnunciado.Text = enunciadoSeleccionado.Nombre;
                        enunciadoSeleccionado.Tipo = 1;
                        enunciadoSeleccionado.Avanzado = false;
                        int test3;
                        bool esPosible3 = int.TryParse(cursoSeleccion.Text, out test3);

                        if (esPosible3)
                        {
                            enunciadoSeleccionado.Respuesta = int.Parse(cursoSeleccion.Text);
                        }
                        enunciadoSeleccionado.Curso = int.Parse(cursoSeleccion.Text);

                        if (imagenEnunciado.Image != null) // Verificar si hay una imagen asignada
                        {
                            byte[] imagenBytes = null;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                imagenEnunciado.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                imagenBytes = ms.ToArray();
                            }
                            enunciadoSeleccionado.Imagen = imagenBytes;
                        }
                        else
                        {
                            // Si no hay imagen asignada, simplemente dejamos en null la propiedad Imagen
                            enunciadoSeleccionado.Imagen = null;
                        }

                        double test4;
                        bool esPosible4 = double.TryParse(resultadoEnunciado.Text, out test4);
                        if (esPosible4)
                        {
                            enunciadoSeleccionado.Respuesta = double.Parse(resultadoEnunciado.Text);
                        }
                        break;
                    case 2:
                        textoEnunciado.Enabled = false;
                        resultadoEnunciado.Enabled = false;
                        imagenEnunciado.Enabled = false;
                        abrirImagen.Enabled = false;
                        abrirAvanzado.Enabled = true;
                        NombreEnunciado.Text = enunciadoSeleccionado.Nombre;
                        enunciadoSeleccionado.Tipo = 2;
                        bool esPosible5 = int.TryParse(cursoSeleccion.Text, out int test5);

                        if (esPosible5)
                        {
                            enunciadoSeleccionado.Respuesta = int.Parse(cursoSeleccion.Text);
                        }
                        enunciadoSeleccionado.Curso = int.Parse(cursoSeleccion.Text);
                        break;
                    case 3:
                        textoEnunciado.Enabled = false;
                        resultadoEnunciado.Enabled = false;
                        imagenEnunciado.Enabled = false;
                        abrirImagen.Enabled = true;
                        abrirAvanzado.Enabled = true;
                        NombreEnunciado.Text = enunciadoSeleccionado.Nombre;
                        enunciadoSeleccionado.Tipo = 3;
                        bool esPosible6 = int.TryParse(cursoSeleccion.Text, out int test);

                        if (esPosible6)
                        {
                            enunciadoSeleccionado.Respuesta = int.Parse(cursoSeleccion.Text);
                        }
                        enunciadoSeleccionado.Curso = int.Parse(cursoSeleccion.Text);
                        break;
                    default:
                        textoEnunciado.Enabled = false;
                        resultadoEnunciado.Enabled = false;
                        imagenEnunciado.Enabled = false;
                        abrirImagen.Enabled = false;
                        abrirAvanzado.Enabled = false;
                        break;
                }
            }
            else
            {
                NombreEnunciado.Enabled = false;
                cursoSeleccion.Enabled = false;
                categoria.Enabled = false;
                tipoEnunciado.Enabled = false;
                idEnunciado.Enabled = false;
                textoEnunciado.Enabled = false;
                resultadoEnunciado.Enabled = false;
                imagenEnunciado.Enabled = false;
                abrirImagen.Enabled = false;
                abrirAvanzado.Enabled = false;
            }
        }
        private void crearEnunciado()
        {
            // Incrementar el último ID utilizado
            ultimoId++;

            // Generar un nombre predeterminado para el nuevo enunciado
            string nuevoNombre = "Enunciado " + ultimoId;

            // Crear un nuevo enunciado con valores predeterminados
            EnunciadoBase nuevoEnunciado = new EnunciadoBase
            {
                Id = ultimoId,
                Nombre = nuevoNombre,
                Categoria = 0, // Valor predeterminado para la categoría
                Avanzado = false,         // Valor predeterminado para Avanzado
                Curso = 1,                // Valor predeterminado para Curso
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
                Tipo = 0
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
        private void abrirImagen_Click(object sender, EventArgs e)
        {
            // Crear un nuevo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer el filtro de archivos para mostrar solo imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Mostrar el diálogo
            DialogResult result = openFileDialog.ShowDialog();

            // Verificar si se seleccionó un archivo de imagen
            if (result == DialogResult.OK)
            {
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
                else
                {
                    // Definir la carpeta de destino para guardar la imagen
                    string folderPath = "Imagenes";

                    // Crear la carpeta si no existe
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    try
                    {
                        // Generar un nombre único para el archivo de imagen
                        string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(filePath);

                        // Construir la ruta completa del archivo de imagen en la carpeta de destino
                        string destinationFilePath = Path.Combine(folderPath, uniqueFileName);

                        // Copiar el archivo de la ubicación original a la carpeta de destino
                        File.Copy(filePath, destinationFilePath);

                        // Mostrar la imagen en el PictureBox
                        imagenEnunciado.SizeMode = PictureBoxSizeMode.Zoom; // Escalar y centrar la imagen
                        imagenEnunciado.Image = System.Drawing.Image.FromFile(destinationFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Se produjo un error al intentar guardar la imagen:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void actualizarEnunciado_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = listBoxEnunciados.SelectedIndex;
            enunciados[indiceSeleccionado].Enunciado = textoEnunciado.ToString();
            BaseEnunciados.ActualizarEnunciado(enunciados[indiceSeleccionado]);
        }
        private void borrarEnunciado_Click(object sender, EventArgs e)
        {
            // Verificar si hay un enunciado seleccionado en la lista
            if (listBoxEnunciados.SelectedIndex >= 0)
            {
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
            }
        }
        private void cambiarBDD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer el filtro de archivos para mostrar solo archivos SQLite
            openFileDialog.Filter = "Archivos SQLite|*.sqlite|Todos los archivos|*.*";

            // Mostrar el diálogo de apertura de archivo
            DialogResult result = openFileDialog.ShowDialog();

            // Verificar si se seleccionó un archivo
            if (result == DialogResult.OK)
            {
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
                ultimoId = enunciados.Count();
                CargarEnunciadosDesdeBaseDatos(BaseEnunciados);
                habilitarFunciones();
            }
        }
        private void crearLista_Click(object sender, EventArgs e)
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
                string archivoSeleccionado = saveFileDialog.FileName;
                string nombreLista = Path.GetFileNameWithoutExtension(archivoSeleccionado);
                // Obtener la ruta completa del archivo seleccionado por el usuario
                databasePath = saveFileDialog.FileName;
                // Asignar el nombre al TextBox
                NombreLista.Text = nombreLista;
                BDD ejercicios = new BDD(databasePath);
                // Crear la tabla de enunciados si no existe
                ejercicios.CrearTablaEnunciados();
                CargarEnunciadosDesdeBaseDatos(ejercicios);
                habilitarFunciones();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBoxEnunciados.SelectedIndex >= 0)
            {
                // Obtener el índice del enunciado seleccionado
                int indiceSeleccionado = listBoxEnunciados.SelectedIndex;

                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];
                //EnunciadoAvanzado adv = new EnunciadoAvanzado(BaseEnunciados, enunciadoSeleccionado);
                //adv.ShowDialog();
                MainView mv = new MainView(BaseEnunciados, enunciadoSeleccionado);
                mv.Show();
            }
        }
        private void nuevoEnunciado_Click(object sender, EventArgs e)
        {
            crearEnunciado();
            habilitarFunciones();
        }
        private void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = listBoxEnunciados.SelectedIndex;
            enunciados[indiceSeleccionado].Categoria = categoria.SelectedIndex;
            ActualizarBaseDeDatos();
            habilitarFunciones();
        }
        private void cursoSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = listBoxEnunciados.SelectedIndex;
            enunciados[indiceSeleccionado].Curso = cursoSeleccion.SelectedIndex;
            ActualizarBaseDeDatos();
            habilitarFunciones();
        }
        private void tipoEnunciado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = listBoxEnunciados.SelectedIndex;
            enunciados[indiceSeleccionado].Tipo = tipoEnunciado.SelectedIndex;
            ActualizarBaseDeDatos();
            habilitarFunciones();
        }
        private void listBoxEnunciados_SelectedValueChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = listBoxEnunciados.SelectedIndex;
            if (indiceSeleccionado >= 0 && indiceSeleccionado < listBoxEnunciados.Items.Count)
            {
                listBoxEnunciados.SelectedIndex = indiceSeleccionado;
                CargarDatos(enunciados[indiceSeleccionado]);
            }
        }
        private void AlterarBDD_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void AlterarBDD_Load(object sender, EventArgs e)
        {
            NombreLista.Text = BaseEnunciados.nombre;
            if (enunciados.Count > 0)
            {
                CargarDatos(enunciados[0]);
            }
            habilitarFunciones();
        }

        private void listBoxEnunciados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = listBoxEnunciados.SelectedIndex;
            if (indiceSeleccionado >= 0 && indiceSeleccionado < listBoxEnunciados.Items.Count)
            {
                listBoxEnunciados.SelectedIndex = indiceSeleccionado;
                CargarDatos(enunciados[indiceSeleccionado]);
            }
            habilitarFunciones();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}