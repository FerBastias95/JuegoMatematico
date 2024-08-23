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
    public partial class Victory : Form {
        public Victory() {
            InitializeComponent();
        }

        private void Victory_Load(object sender, EventArgs e) {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Combina la ruta base con la carpeta Assets y el archivo mp3
            string filePath = Path.Combine(basePath, @"..\Assets\victoria.mp3");

            // Configura el reproductor para reproducir el archivo
            axWindowsMediaPlayer1.URL = Path.GetFullPath(filePath);
            axWindowsMediaPlayer1.settings.setMode("loop", true); // Repetir la música en bucle (opcional)
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
