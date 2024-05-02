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

        private void button1_Click(object sender, EventArgs e) {
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

        private void Opciones_Load(object sender, EventArgs e) {
            if (opciones.dif == 0) {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            else if (opciones.dif == 1) {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                radioButton3.Checked = false;
            }
            else if (opciones.dif == 2) {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = true;
            }
            opcionesTiempo.Text = tiempo.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                // Desactivar radioButton2
                radioButton2.Checked = false;
                // Activar radioButton3
                radioButton3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (radioButton2.Checked) {
                // Desactivar radioButton1
                radioButton1.Checked = false;
                // Activar radioButton3
                radioButton3.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e) {
            // Si radioButton3 se marca, desactivar radioButton1 y radioButton2
            if (radioButton3.Checked) {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }
    }
}
