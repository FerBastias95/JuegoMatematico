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
    public partial class Opciones : Form {
        Form1 opciones;
        int tiempo;
        public Opciones(Form1 f) {
            tiempo = f.tiempo;
            opciones = f;
            InitializeComponent();
        }

        private void Opciones_Load(object sender, EventArgs e) {
            if (opciones.dif == 0) {
                radioButton1.Checked = true;
            }
            else if (opciones.dif == 1) {
                radioButton2.Checked = true;
            }
            else if (opciones.dif == 2) {
                opcionesTiempo.Enabled = true;
                radioButton3.Checked = true;
            }
            opcionesTiempo.Text = tiempo.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            if (radioButton3.Checked) {
                opcionesTiempo.Enabled = true;
            }
            else {
                opcionesTiempo.Enabled = false;
            }
        }
        private void button1_Click_1(object sender, EventArgs e) {
            bool esPosible = int.TryParse(opcionesTiempo.Text, out int test);
            if (radioButton1.Checked) {
                opciones.dificultad(0);
                this.Close();
            }
            else if (radioButton2.Checked) {
                opciones.dificultad(1);
                this.Close();
            }
            else if (radioButton3.Checked) {
                if (esPosible) {
                    opciones.tiempo = int.Parse(opcionesTiempo.Text);
                    opciones.dificultad(2);
                    this.Close();
                }
                else {
                    MessageBox.Show("Valor del tiempo no es válido.");
                }
            }
        }
    }
}
