using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicios {
    public partial class VentanaEnunciadoDesafio : Form {
        List<EnunciadoBase> elegidos;
        public string resultadoC;
        public string resultadoI;
        EnunciadoBase enu;
        public Form1 FormPrincipal { get; set; }
        int tiempo, correctas, incorrectas, cantidad, seleccion, modo;
        double r;
        string enunciado;
        Random randy;
        public VentanaEnunciadoDesafio(List<EnunciadoBase> e, Form1 f) {
            resultadoC = "Correctas:";
            resultadoI = "\n\nIncorrectas:";
            modo = 0;
            FormPrincipal = f;
            elegidos = e;
            cantidad = elegidos.Count;
            randy = new Random();
            tiempo = f.tiempo;
            InitializeComponent();
        }

        private void Problema_1_Load(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Escalar y centrar la imagen
            botonP1.Text = "¡Empezar!";
            valorTiempo.Text = FormPrincipal.tiempo.ToString();
            timer1.Stop();
            tiempo = FormPrincipal.tiempo;
        }
        private void actualizar() {
            RespuestaP1.Text = "";
            seleccion = azar(randy, cantidad - 1);
            valorCorrectas.Text = correctas.ToString();
            valorIncorrectas.Text = incorrectas.ToString();

            enu = elegidos[seleccion];
            enunciado = enu.Enunciado;
            FormPrincipal.modificarVariables(enu);
            while (!FormPrincipal.IsResponseValid(enu)) {
                // La respuesta no es válida, volver a generar las variables
                FormPrincipal.modificarVariables(enu);
            }
            r = enu.Respuesta;
            Enunciado1.Text = enunciado;
            if (enu.Imagen != null) {
                using (MemoryStream ms = new MemoryStream(enu.Imagen)) {
                    pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            else {
                pictureBox1.Image = null;
            }
        }
        private void acciones() {
            if (modo == 0) {
                timer1.Start();
                botonP1.Text = "Enviar respuesta";
                modo = 1;
                RespuestaP1.Enabled = true;
                RespuestaP1.Focus();
                actualizar();
            }
            else if (modo == 1) {
                double input;
                bool valid = double.TryParse(RespuestaP1.Text, out double d1);
                if (valid) {
                    input = double.Parse(RespuestaP1.Text);
                    double valorAbsoluto = Math.Abs(input - r);
                    Math.Round(input, 1);
                    if (input == enu.Respuesta || valorAbsoluto < 0.3) {
                        resultadoC += "\n" + enunciado;
                        correctas++;
                    }
                    else {
                        resultadoI += "\n" + enunciado;
                        incorrectas++;
                    }
                    actualizar();
                    RespuestaP1.Focus();
                }
            }
            else if (modo == 2) {
                MessageBox.Show(resultadoC + resultadoI);
            }
        }
        private int azar(Random r, int largo) {
            return r.Next(0, largo + 1);
        }
        private void botonP1_Click(object sender, EventArgs e) {
            acciones();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (tiempo == 0) {
                if (correctas == 0) resultadoC = "";
                if (incorrectas == 0) resultadoI = "";
                modo = 2;
                botonP1.Text = "Resultados";
                timer1.Stop();
                RespuestaP1.Enabled = false;
            }
            else {
                tiempo--;
                valorTiempo.Text = tiempo.ToString();
            }
        }
        private void RespuestaP1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                // Llamar al método que deseas activar
                acciones();

                // Indicar que hemos manejado la tecla Enter para evitar que se inserte en el control
                e.Handled = true;
            }
        }
    }
}