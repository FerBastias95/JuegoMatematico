using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpiadas
{
    public partial class AlterarBDD : Form
    {
        public AlterarBDD()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnunciadoAvanzado adv = new EnunciadoAvanzado();
            adv.ShowDialog();
        }
    }
}
