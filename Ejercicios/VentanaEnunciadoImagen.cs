using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios {
    public partial class VentanaEnunciadoImagen : Form {
        EnunciadoBase enu;
        private Image cachedImage = null;
        public Form1 FormPrincipal { get; set; }
        string en;
        double r;
        int i;
        int c;
        int v;
        CustomBox cb;

        public VentanaEnunciadoImagen(EnunciadoBase e, Form1 forma, int indice) {
            enu = e;
            en = enu.Enunciado;
            r = enu.Respuesta;
            v = forma.vidas;
            c = forma.correctas;
            i = indice;
            InitializeComponent();
        }

        private void Problema_1_Load(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Escalar y centrar la imagen
            Enunciado1.Text = en;
            if (en.Length < 1) {
                Enunciado1.Visible = false;
                pictureBox1.Size = new Size(1240, 559);
                pictureBox1.Location = new Point(12, 12);
            }
            if (enu.Imagen != null) {
                if (cachedImage == null) { // Load only if not cached
                    using (MemoryStream ms = new MemoryStream(enu.Imagen)) {
                        cachedImage = System.Drawing.Image.FromStream(ms);
                    }
                }
                pictureBox1.Image = cachedImage;
            }
            else {
                pictureBox1.Image = null;
            }
        }
        private void acciones() {
            double input;
            string ans = RespuestaP1.Text;
            if (ans.Length > 0) {
                ans = ans.Replace('.', ',');
            }
            bool valid = double.TryParse(ans, out double d1);
            if (valid) {
                input = double.Parse(ans);
                double valorAbsoluto = Math.Abs(input - r);
                Math.Round(input, 1);
                if (input == FormPrincipal.elegidos[i].Respuesta || valorAbsoluto < 0.3) {
                    cb = new CustomBox(true);
                    cb.ShowDialog();
                    //MessageBox.Show("¡Respuesta correcta!");
                    FormPrincipal.resueltos[i] = true; // Modificar el booleano del formulario principal
                    FormPrincipal.labels[i].Text = "¡OK!";
                    FormPrincipal.labels[i].ForeColor = Color.Green;
                    c++;
                    FormPrincipal.actualizarCorrectas(c);
                    this.Close();
                }
                else {
                    cb = new CustomBox(false);
                    cb.ShowDialog();
                    //MessageBox.Show($"Error, intente nuevamente.{enu.Respuesta}");
                    v--;
                    FormPrincipal.actualizarVidas(v);
                    if(enu.Avanzado == true) {
                        FormPrincipal.modificarVariables(enu);
                        while (!FormPrincipal.IsResponseValid(enu)) {
                            // La respuesta no es válida, volver a generar las variables
                            FormPrincipal.modificarVariables(enu);
                        }
                        FormPrincipal.CalcularRespuesta(enu);
                        r = enu.Respuesta;
                    }
                    this.Close();
                }
            }
        }

        private void botonP1_Click(object sender, EventArgs e) {
            acciones();
        }
        private void RespuestaP1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                acciones();
                e.Handled = true;
            }
        }
    }
}