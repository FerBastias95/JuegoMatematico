using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpiadas {
    public partial class VentanaEnunciadoImagen : Form {
        EnunciadoBase enu;
        List<EnunciadoBase> lista;
        string en;
        public VentanaEnunciadoImagen(EnunciadoBase e) {
            enu = e;
            en = enu.Enunciado;
            InitializeComponent();
        }

        private void Problema_1_Load(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Escalar y centrar la imagen
            
            Enunciado1.Text = en;
            if (enu.Avanzado == true) {
                RespuestaP1.Text = enu.Formula;
            }
            else {
                RespuestaP1.Text = enu.Respuesta.ToString();
            }
            if (enu.Imagen != null) {
                using (MemoryStream ms = new MemoryStream(enu.Imagen)) {
                    pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            else {
                pictureBox1.Image = null;
            }
        }

        private void botonP1_Click(object sender, EventArgs e) {
            double input;
        }
    }
}