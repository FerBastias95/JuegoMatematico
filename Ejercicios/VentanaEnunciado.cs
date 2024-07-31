using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios{
    public partial class VentanaEnunciado : Form {
        EnunciadoBase enu;
        public Form1 FormPrincipal { get; set; }
        string en;
        double r;
        int i;
        int v;
        int c;
        CustomBox cb;
        public VentanaEnunciado(EnunciadoBase e, Form1 forma, int indice) {
            enu = e;
            en = enu.Enunciado;
            r = enu.Respuesta;
            v = forma.vidas;
            c = forma.correctas;
            i = indice;
            InitializeComponent();
        }

        private void Problema_1_Load(object sender, EventArgs e) {
            Enunciado1.Text = en;
        }
        private void acciones() {
            double input;
            bool valid = double.TryParse(RespuestaP1.Text, out double d1);
            if (valid) {
                input = double.Parse(RespuestaP1.Text);
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
                    //MessageBox.Show($"Error, intente nuevamente.");
                    cb = new CustomBox(false);
                    cb.ShowDialog();
                    v--;
                    FormPrincipal.actualizarVidas(v);
                    FormPrincipal.modificarVariables(enu);
                    while (!FormPrincipal.IsResponseValid(enu)) {
                        // La respuesta no es válida, volver a generar las variables
                        FormPrincipal.modificarVariables(enu);
                    }
                    FormPrincipal.CalcularRespuesta(enu);
                    r = enu.Respuesta;
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