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
    public partial class Resultados : Form {
        String correcta = "";
        String incorrecta = "";
        public Resultados(String c, String i) {
            correcta = c;
            incorrecta = i;
            InitializeComponent();
        }

        private void Resultados_Load(object sender, EventArgs e) {
            Correctas.Text = "";
            Incorrectas.Text = "";
            Correctas.Text = correcta;
            Incorrectas.Text = incorrecta;
            botonP1.Focus();
        }

        private void botonP1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void botonP1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                this.Close();
            }
        }
    }
}
