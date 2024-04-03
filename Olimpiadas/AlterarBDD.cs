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
    public partial class AlterarBDD : Form
    {
        private List<EnunciadoBase> enunciados;
        private int ultimoId = 0;
        BDD BaseEnunciados;
        public AlterarBDD(BDD info)
        {
            BaseEnunciados = info;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            enunciados = new List<EnunciadoBase>(); // Inicializar la lista de enunciados
            listaEnunciados.SelectedIndexChanged += ListaEnunciados_SelectedIndexChanged;

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
                listaEnunciados.Items.Add(enunciado.Nombre);
            }

            // Actualizar el último ID utilizado
            if (enunciados.Count > 0)
            {
                ultimoId = enunciados.Max(enun => enun.Id);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            EnunciadoAvanzado adv = new EnunciadoAvanzado();
            adv.ShowDialog();
        }
        private void ListaEnunciados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice del enunciado seleccionado
            int indiceSeleccionado = listaEnunciados.SelectedIndex;

            if (indiceSeleccionado >= 0)
            {
                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];

                // Mostrar los detalles del enunciado seleccionado en los controles del formulario
                NombreEnunciado.Text = enunciadoSeleccionado.Nombre;
                idEnunciado.Text = enunciadoSeleccionado.Id.ToString();
                categoria.SelectedItem = enunciadoSeleccionado.Categoria;
                opcionTexto.Checked = !enunciadoSeleccionado.UsarVariables; // Si no usa variables, seleccionar texto
                opcionImagen.Checked = enunciadoSeleccionado.UsarVariables; // Si usa variables, seleccionar imagen
                textoEnunciado.Text = enunciadoSeleccionado.Enunciado;
                resultadoEnunciado.Text = enunciadoSeleccionado.Respuesta.ToString(); // Mostrar la respuesta
                curso.SelectedItem = enunciadoSeleccionado.Curso.ToString();
                permitirAvanzado.Checked = enunciadoSeleccionado.Avanzado;
                // Mostrar la imagen si hay una
                if (enunciadoSeleccionado.Imagen != null)
                {
                    using (MemoryStream ms = new MemoryStream(enunciadoSeleccionado.Imagen))
                    {
                        imagenEnunciado.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    imagenEnunciado.Image = null;
                }
            }
        }
        private void permitirAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            if (permitirAvanzado.Checked == true)
            {
                abrirAvanzado.Enabled = true;
            }
            else
            {
                abrirAvanzado.Enabled = false;
            }
        }

        private void opcionTexto_CheckedChanged(object sender, EventArgs e)
        {
            if (opcionTexto.Checked == true)
            {
                textoEnunciado.Enabled = true;
                resultadoEnunciado.Enabled = true;
                imagenEnunciado.Enabled = false;
                abrirImagen.Enabled = false;
                resultadoImagen.Enabled = false;
            }
        }

        private void opcionImagen_CheckedChanged(object sender, EventArgs e)
        {
            if (opcionImagen.Checked == true)
            {
                textoEnunciado.Enabled = false;
                resultadoEnunciado.Enabled = false;
                imagenEnunciado.Enabled = true;
                abrirImagen.Enabled = true;
                resultadoImagen.Enabled = true;
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
                UsarVariables = false,    // Valor predeterminado para UsarVariables
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
                Respuesta = 0             // Valor predeterminado para la respuesta
            };

            // Insertar el nuevo enunciado en la base de datos

            BaseEnunciados.InsertarEnunciado(nuevoEnunciado);

            // Agregar el nuevo enunciado a la lista de enunciados
            enunciados.Add(nuevoEnunciado);
            listaEnunciados.Items.Add(nuevoEnunciado.Nombre);
        }

        private void borrarEnunciado_Click(object sender, EventArgs e)
        {
            // Verificar si hay un enunciado seleccionado en la lista
            if (listaEnunciados.SelectedIndex >= 0)
            {
                // Obtener el índice del enunciado seleccionado
                int indiceSeleccionado = listaEnunciados.SelectedIndex;

                // Obtener el enunciado seleccionado
                EnunciadoBase enunciadoSeleccionado = enunciados[indiceSeleccionado];

                // Eliminar el enunciado de la lista
                enunciados.RemoveAt(indiceSeleccionado);

                // Eliminar el enunciado de la base de datos
                EliminarEnunciadoDeBaseDatos(enunciadoSeleccionado);

                // Actualizar la vista de la lista
                ActualizarListaEnunciados();
            }
        }
        // Método para eliminar un enunciado de la base de datos
        private void EliminarEnunciadoDeBaseDatos(EnunciadoBase enunciado)
        {
                BaseEnunciados.EliminarEnunciado(enunciado.Id);
        }

        // Método para actualizar la vista de la lista de enunciados
        private void ActualizarListaEnunciados()
        {
            listaEnunciados.Items.Clear();
            foreach (EnunciadoBase enunciado in enunciados)
            {
                listaEnunciados.Items.Add(enunciado.Nombre);
            }
        }
    }
}
