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
        public Opciones(Form1 f) {
            opciones = f;
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                opciones.dificultad(0);
            }
            else if (radioButton2.Checked) {
                opciones.dificultad(1);
            }
            else if (radioButton3.Checked) {
                opciones.dificultad(2);
            }
            this.Close();
        }

        private void Opciones_Load(object sender, EventArgs e) {
            if(opciones.dif == 0) {
                radioButton1.Checked = true;
            }
            else if(opciones.dif == 1) {
                radioButton2.Checked = true;
            }
            else if(opciones.dif == 2) {
                radioButton3.Checked = true;
            }
        }
    }
}
