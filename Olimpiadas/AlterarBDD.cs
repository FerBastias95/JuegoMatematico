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
        private int ultimoId = 0;
        BDD BaseEnunciados;
        public AlterarBDD(BDD info)
        {
            BaseEnunciados = info;
            InitializeComponent();
            enunciados = new List<EnunciadoBase>(); // Inicializar la lista de enunciados
            listaEnunciados2.SelectedIndexChanged += ListaEnunciados2_SelectedIndexChanged;

            // Cargar los enunciados desde la base de datos al iniciar el formulario
            CargarEnunciadosDesdeBaseDatos();
        }
        // Método para cargar los enunciados desde la base de datos
        private void CargarEnunciadosDesdeBaseDatos()
        {
            // Obtener todos los enunciados de la base de datos
            enunciados = BaseEnunciados.ObtenerTodosEnunciados();

            // Agregar los nombres de los enunciados a la lista de enunciados en el formulario
            foreach (EnunciadoBase enunciado in enunciados)
            {
                listaEnunciados2.Items.Add(enunciado.Nombre);
            }

            // Actualizar el último ID utilizado
            if (enunciados.Count > 0)
            {
                ultimoId = enunciados.Max(enun => enun.Id);
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
        private void ListaEnunciados2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice del enunciado seleccionado
            int indiceSeleccionado = listaEnunciados2.SelectedIndex;

            if (indiceSeleccionado >= 0)
            {
                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];

                // Mostrar los detalles del enunciado seleccionado en los controles del formulario
                NombreEnunciado.Text = enunciadoSeleccionado.Nombre;
                idEnunciado.Text = enunciadoSeleccionado.Id.ToString();
                categoria.SelectedItem = enunciadoSeleccionado.Categoria;
                textoEnunciado.Text = enunciadoSeleccionado.Enunciado;
                resultadoEnunciado.Text = enunciadoSeleccionado.Respuesta.ToString(); // Mostrar la respuesta
                cursoSeleccion.SelectedItem = enunciadoSeleccionado.Curso.ToString();

                if (enunciadoSeleccionado.Tipo == 2)
                {
                    opcionAvanzado.Checked = true;
                    opcionImagen.Checked = false;
                    opcionTexto.Checked = false;
                }
                else if (enunciadoSeleccionado.Tipo == 1)
                {
                    opcionAvanzado.Checked = false;
                    opcionImagen.Checked = true;
                    opcionTexto.Checked = false;
                }
                else
                {
                    opcionAvanzado.Checked = false;
                    opcionImagen.Checked = false;
                    opcionTexto.Checked = true;
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
        private void opcionTexto_CheckedChanged(object sender, EventArgs e)
        {
            if (opcionTexto.Checked == true)
            {
                textoEnunciado.Enabled = true;
                resultadoEnunciado.Enabled = true;
                abrirImagen.Enabled = false;
                imagenTexto.Enabled = false;
                resultadoImagen.Enabled = false;
                imagenEnunciado.Enabled = false;
                abrirAvanzado.Enabled = false;
            }
        }

        private void opcionImagen_CheckedChanged(object sender, EventArgs e)
        {
            if (opcionImagen.Checked == true)
            {
                textoEnunciado.Enabled = false;
                resultadoEnunciado.Enabled = false;
                imagenEnunciado.Enabled = true;
                imagenTexto.Enabled = true;
                abrirImagen.Enabled = true;
                resultadoImagen.Enabled = true;
                abrirAvanzado.Enabled = false;
            }
        }

        private void opcionAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            if (opcionAvanzado.Checked == true)
            {
                textoEnunciado.Enabled = false;
                resultadoEnunciado.Enabled = false;
                imagenEnunciado.Enabled = false;
                imagenTexto.Enabled = false;
                abrirImagen.Enabled = false;
                resultadoImagen.Enabled = false;
                abrirAvanzado.Enabled = true;
            }
        }

        private void nuevoEnunciado_Click(object sender, EventArgs e)
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
            listaEnunciados2.Items.Add(nuevoEnunciado.Nombre);
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
                ActualizarListaEnunciados2();
            }
        }
        // Método para eliminar un enunciado de la base de datos
        private void EliminarEnunciadoDeBaseDatos(EnunciadoBase enunciado)
        {
            BaseEnunciados.EliminarEnunciado(enunciado.Id);
        }

        // Método para actualizar la vista de la lista de enunciados
        private void ActualizarListaEnunciados2()
        {
            listaEnunciados2.Items.Clear();
            foreach (EnunciadoBase enunciado in enunciados)
            {
                listaEnunciados2.Items.Add(enunciado.Nombre);
            }

        }

        private void actualizarEnunciado_Click(object sender, EventArgs e)
        {
            // Verificar si hay un enunciado seleccionado en la lista
            if (listaEnunciados2.SelectedIndex >= 0)
            {
                // Obtener el índice del enunciado seleccionado
                int indiceSeleccionado = listaEnunciados2.SelectedIndex;

                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];
                if (opcionAvanzado.Checked)
                {
                    enunciadoSeleccionado.Tipo = 2;
                }
                else if (opcionImagen.Checked)
                {
                    enunciadoSeleccionado.Tipo = 1;
                }
                else
                {
                    enunciadoSeleccionado.Tipo = 0;
                }

                if (opcionTexto.Checked == true)
                {
                    enunciadoSeleccionado.Nombre = NombreEnunciado.Text;
                    enunciadoSeleccionado.Categoria = categoria.Text;
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
                }
                else if (opcionImagen.Checked)
                {
                    enunciadoSeleccionado.Nombre = NombreEnunciado.Text;
                    enunciadoSeleccionado.Categoria = categoria.Text;
                    enunciadoSeleccionado.Avanzado = false;
                    int test1;
                    bool esPosible1 = int.TryParse(cursoSeleccion.Text, out test1);
                    if (esPosible1)
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

                    double test2;
                    bool esPosible2 = double.TryParse(resultadoImagen.Text, out test2);
                    if (esPosible2)
                    {
                        enunciadoSeleccionado.Respuesta = double.Parse(resultadoImagen.Text);
                    }
                }

                else
                {
                    enunciadoSeleccionado.Nombre = NombreEnunciado.Text;
                    enunciadoSeleccionado.Categoria = categoria.Text;
                    int test1;
                    bool esPosible1 = int.TryParse(cursoSeleccion.Text, out test1);

                    if (esPosible1)
                    {
                        enunciadoSeleccionado.Respuesta = int.Parse(cursoSeleccion.Text);
                    }
                    enunciadoSeleccionado.Curso = int.Parse(cursoSeleccion.Text);
                }
                // Actualizar el enunciado en la base de datos
                BaseEnunciados.ActualizarEnunciado(enunciadoSeleccionado);

                // Actualizar la vista de la lista de enunciados
                ActualizarListaEnunciados2();
            }
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

    }
}
