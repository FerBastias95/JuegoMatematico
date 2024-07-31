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
    public partial class CustomBox : Form {
        public bool correcto = false;
        public CustomBox(bool a) {
            correcto = a;
            InitializeComponent();
        }

        private void Correcto() {
            cyberTextBox1.TextButton = "RESPUESTA CORRECTA";
            button1.EnteredColor = Color.LightGreen;
            button1.InactiveColor = Color.LightGreen;
            button1.BackColor = Color.LightGreen;
            button1.BorderColor = Color.Lime;
            button1.PressedColor = Color.Lime;
            button1.ForeColor = Color.Black;
        }

        private void Incorrecto() {
            cyberTextBox1.TextButton = "RESPUESTA INCORRECTA";
            button1.EnteredColor = Color.Red;
            button1.InactiveColor = Color.LightCoral;
            button1.BackColor = Color.LightCoral;
            button1.BorderColor = Color.DarkRed;
            button1.PressedColor = Color.DarkRed;
            button1.ForeColor = Color.Black;
        }

        private void CustomBox_Load(object sender, EventArgs e) {
            if (correcto) {
                Correcto();
            }
            else {
                Incorrecto();
            }
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
