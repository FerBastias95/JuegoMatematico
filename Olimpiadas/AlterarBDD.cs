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
        public AlterarBDD(BDD info)
        {
            update = false;
            BaseEnunciados = info;
            InitializeComponent();
            enunciados = new List<EnunciadoBase>(); // Inicializar la lista de enunciados
            listaEnunciados2.SelectedIndexChanged += ListaEnunciados2_SelectedIndexChanged;
            categoria.SelectedIndexChanged += categoria_SelectedIndexChanged; // Suscribir al evento SelectedIndexChanged de categoria
            cursoSeleccion.SelectedIndexChanged += cursoSeleccion_SelectedIndexChanged; // Suscribir al evento SelectedIndexChanged de cursoSeleccion

            // Cargar los enunciados desde la base de datos al iniciar el formulario
            CargarEnunciadosDesdeBaseDatos(BaseEnunciados);
        }

        // Método para cargar los enunciados desde la base de datos
        private void CargarEnunciadosDesdeBaseDatos(BDD info)
        {
            listBoxEnunciados.Items.Clear();
            listaEnunciados2.Items.Clear();
            // Obtener todos los enunciados de la base de datos
            enunciados = info.ObtenerTodosEnunciados();

            if (enunciados.Count > 0)
            {
                foreach (EnunciadoBase enunciado in enunciados)
                {
                    listaEnunciados2.Items.Add(enunciado.Nombre);
                }
                foreach (EnunciadoBase enunciado in enunciados)
                {
                    listBoxEnunciados.Items.Add(enunciado.Nombre);
                }
                ultimoId = enunciados.Max(enun => enun.Id);
                listaEnunciados2.SelectedIndex = 0;
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
        // Método para actualizar la vista de la lista de enunciados
        private void ActualizarListaEnunciados(int index)
        {
            listBoxEnunciados.Items.Clear();
            listaEnunciados2.Items.Clear();
            int lastIndex;
            foreach (EnunciadoBase enunciado in enunciados)
            {
                listBoxEnunciados.Items.Add(enunciado.Nombre);
                listaEnunciados2.Items.Add(enunciado.Nombre);
            }
            lastIndex = listBoxEnunciados.Items.Count - 1;
            if (index > lastIndex)
            {
                listBoxEnunciados.SelectedIndex = lastIndex;
                listaEnunciados2.SelectedIndex = lastIndex;
            }
            else
            {
                listBoxEnunciados.SelectedIndex = index;
                listaEnunciados2.SelectedIndex = index;
            }
        }
        private void ActualizarContenidoEnunciado(int indiceSeleccionado)
        {
            if (indiceSeleccionado >= 0 && indiceSeleccionado < enunciados.Count)
            {
                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];
                // Mostrar los detalles del enunciado seleccionado en los controles del formulario
                NombreEnunciado.Text = enunciadoSeleccionado.Nombre;
                idEnunciado.Text = enunciadoSeleccionado.Id.ToString();
                if (enunciadoSeleccionado.Curso.ToString() == "")
                {
                    cursoSeleccion.SelectedIndex = 0;
                }
                else
                {
                    cursoSeleccion.SelectedItem = enunciadoSeleccionado.Curso.ToString();
                }
                if (enunciadoSeleccionado.Categoria == "")
                {
                    categoria.SelectedIndex = 0;
                }
                else
                {
                    categoria.SelectedItem = enunciadoSeleccionado.Categoria;
                }
                textoEnunciado.Text = enunciadoSeleccionado.Enunciado;
                tipoEnunciado.SelectedIndex = enunciadoSeleccionado.Tipo;
                resultadoEnunciado.Text = enunciadoSeleccionado.Respuesta.ToString(); // Mostrar la respuesta
                // Mostrar la imagen si hay una
                if (enunciadoSeleccionado.Imagen != null)
                {
                    using (MemoryStream ms = new MemoryStream(enunciadoSeleccionado.Imagen))
                    {
                        imagenEnunciado.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    imagenEnunciado.Image = null;
                }
                // Mostrar la imagen si hay una
                if (enunciadoSeleccionado.Imagen != null)
                {
                    using (MemoryStream ms = new MemoryStream(enunciadoSeleccionado.Imagen))
                    {
                        imagenEnunciado.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    imagenEnunciado.Image = null;
                }
            }
        }
        private void actualizarEnunciadoBase()
        {
            string tipo = tipoEnunciado.Text;
            string curso = cursoSeleccion.SelectedIndex.ToString();
            string categoriatexto = categoria.SelectedIndex.ToString();
            if (listaEnunciados2.SelectedIndex >= 0 && curso != "" && categoriatexto != "")
            {
                // Obtener el índice del enunciado seleccionado
                int indiceSeleccionado = listaEnunciados2.SelectedIndex;
                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];
                switch (tipo)
                {
                    case "Texto":
                        textoEnunciado.Enabled = true;
                        resultadoEnunciado.Enabled = true;
                        abrirImagen.Enabled = false;
                        imagenTexto.Enabled = false;
                        resultadoImagen.Enabled = false;
                        imagenEnunciado.Enabled = false;
                        abrirAvanzado.Enabled = false;

                        enunciadoSeleccionado.Nombre = NombreEnunciado.Text;
                        enunciadoSeleccionado.Categoria = categoria.Text;
                        enunciadoSeleccionado.Tipo = 0;
                        enunciadoSeleccionado.Avanzado = false;
                        int test1;
                        bool esPosible1 = int.TryParse(cursoSeleccion.Text, out test1);
                        if (esPosible1)
                        {
                            enunciadoSeleccionado.Respuesta = int.Parse(cursoSeleccion.Text);
                        }
                        enunciadoSeleccionado.Curso = int.Parse(cursoSeleccion.Text);
                        enunciadoSeleccionado.Enunciado = textoEnunciado.Text;
                        double test2;
                        bool esPosible2 = double.TryParse(resultadoEnunciado.Text, out test2);
                        if (esPosible2)
                        {
                            enunciadoSeleccionado.Respuesta = double.Parse(resultadoEnunciado.Text);
                        }
                        break;

                    case "Texto e imágenes":
                        textoEnunciado.Enabled = false;
                        resultadoEnunciado.Enabled = false;
                        imagenEnunciado.Enabled = true;
                        imagenTexto.Enabled = true;
                        abrirImagen.Enabled = true;
                        resultadoImagen.Enabled = true;
                        abrirAvanzado.Enabled = false;

                        enunciadoSeleccionado.Nombre = NombreEnunciado.Text;
                        enunciadoSeleccionado.Categoria = categoria.Text;
                        enunciadoSeleccionado.Tipo = 1;
                        enunciadoSeleccionado.Avanzado = false;
                        int test3;
                        bool esPosible3 = int.TryParse(cursoSeleccion.Text, out test3);

                        if (esPosible3)
                        {
                            enunciadoSeleccionado.Respuesta = int.Parse(cursoSeleccion.Text);
                        }
                        enunciadoSeleccionado.Curso = int.Parse(cursoSeleccion.Text);
                        enunciadoSeleccionado.Enunciado = imagenTexto.Text;

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
                        bool esPosible4 = double.TryParse(resultadoImagen.Text, out test4);
                        if (esPosible4)
                        {
                            enunciadoSeleccionado.Respuesta = double.Parse(resultadoImagen.Text);
                        }
                        break;

                    case "Avanzado":
                        textoEnunciado.Enabled = false;
                        resultadoEnunciado.Enabled = false;
                        imagenEnunciado.Enabled = false;
                        imagenTexto.Enabled = false;
                        abrirImagen.Enabled = false;
                        resultadoImagen.Enabled = false;
                        abrirAvanzado.Enabled = true;

                        enunciadoSeleccionado.Nombre = NombreEnunciado.Text;
                        enunciadoSeleccionado.Categoria = categoria.Text;
                        enunciadoSeleccionado.Tipo = 2;
                        int test5;
                        bool esPosible5 = int.TryParse(cursoSeleccion.Text, out test5);

                        if (esPosible5)
                        {
                            enunciadoSeleccionado.Respuesta = int.Parse(cursoSeleccion.Text);
                        }
                        enunciadoSeleccionado.Curso = int.Parse(cursoSeleccion.Text);
                        break;

                    default:
                        break;
                }

                // Actualizar el enunciado en la base de datos
                BaseEnunciados.ActualizarEnunciado(enunciadoSeleccionado);
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
                Categoria = string.Empty, // Valor predeterminado para la categoría
                Avanzado = false,         // Valor predeterminado para Avanzado
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

            listaEnunciados2.Items.Add(nuevoEnunciado.Nombre);

            // Seleccionar el nuevo enunciado recién creado
            listaEnunciados2.SelectedIndex = listBoxEnunciados.Items.Count - 1;

            ActualizarContenidoEnunciado(ultimoId);
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
            int indiceSeleccionado = listaEnunciados2.SelectedIndex;
            actualizarEnunciadoBase();
            // Actualizar la vista de la lista de enunciados
            ActualizarListaEnunciados(indiceSeleccionado);
        }
        private void borrarEnunciado_Click(object sender, EventArgs e)
        {
            // Verificar si hay un enunciado seleccionado en la lista
            if (listaEnunciados2.SelectedIndex >= 0)
            {
                // Obtener el índice del enunciado seleccionado
                int indiceSeleccionado = listaEnunciados2.SelectedIndex;

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
                // Obtener la ruta completa del archivo seleccionado por el usuario
                databasePath = saveFileDialog.FileName;
                string nombreLista = databasePath;
                // Asignar el nombre al TextBox
                NombreLista.Text = nombreLista;
                BDD ejercicios = new BDD(databasePath);
                // Crear la tabla de enunciados si no existe
                ejercicios.CrearTablaEnunciados();
                CargarEnunciadosDesdeBaseDatos(ejercicios);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (listaEnunciados2.SelectedIndex >= 0)
            {
                // Obtener el índice del enunciado seleccionado
                int indiceSeleccionado = listaEnunciados2.SelectedIndex;

                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];
                EnunciadoAvanzado adv = new EnunciadoAvanzado(BaseEnunciados, enunciadoSeleccionado);
                adv.ShowDialog();
            }
        }
        private void nuevoEnunciado_Click(object sender, EventArgs e)
        {
            crearEnunciado();
        }
        private void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si el texto en el ComboBox categoria no está vacío
            if (!string.IsNullOrEmpty(categoria.Text) && !string.IsNullOrEmpty(cursoSeleccion.Text) && !string.IsNullOrEmpty(tipoEnunciado.Text))
            {
                actualizarEnunciadoBase();
            }
        }
        private void cursoSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si el texto en el ComboBox cursoSeleccion no está vacío
            if (!string.IsNullOrEmpty(categoria.Text) && !string.IsNullOrEmpty(cursoSeleccion.Text) && !string.IsNullOrEmpty(tipoEnunciado.Text))
            {
                actualizarEnunciadoBase();
            }
        }
        private void tipoEnunciado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(categoria.Text) && !string.IsNullOrEmpty(cursoSeleccion.Text) && !string.IsNullOrEmpty(tipoEnunciado.Text))
            {
                actualizarEnunciadoBase();
            }
        }
        private void listBoxEnunciados_SelectedValueChanged(object sender, EventArgs e)
        {
            // Obtener el índice del enunciado seleccionado
            int indiceSeleccionado = listBoxEnunciados.SelectedIndex;
            // Verificar si hay un índice seleccionado válido en el ListBox
            if (indiceSeleccionado >= 0 && indiceSeleccionado < listaEnunciados2.Items.Count)
            {
                // Seleccionar el mismo índice en el ComboBox
                listaEnunciados2.SelectedIndex = indiceSeleccionado;
                ActualizarContenidoEnunciado(indiceSeleccionado);
            }
        }
        private void ListaEnunciados2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice del enunciado seleccionado
            int indiceSeleccionado = listaEnunciados2.SelectedIndex;
            // Verificar si hay un índice seleccionado válido en el ListBox
            if (indiceSeleccionado >= 0 && indiceSeleccionado < listBoxEnunciados.Items.Count)
            {
                // Seleccionar el mismo índice en el ComboBox
                listBoxEnunciados.SelectedIndex = indiceSeleccionado;
                ActualizarContenidoEnunciado(indiceSeleccionado);
            }
        }
        private void AlterarBDD_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}