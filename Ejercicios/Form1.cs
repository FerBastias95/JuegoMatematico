namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public int vidas = 0;
        public int correctas = 0;
        public List<EnunciadoBase> enunciados;
        public bool problema1R, problema2R, problema3R, problema4R, problema5R, 
            problema6R, problema7R, problema8R, problema9R, problema10R, 
            problema1F, problema2F, problema3F, problema4F, problema5F;
        private string e1, e2, e3, e4, e5;
        private int r1, r2, r3, r4, r5;
        string pathName = "";
        BDD ejercicios;
        public Form1()
        {
            vidas = 5;
            correctas = 0;
            problema1R = false;
            problema2R = false;
            problema3R = false;
            problema4R = false;
            problema5R = false;
            problema6R = false;
            problema7R = false;
            problema8R = false;
            problema9R = false;
            problema10R = false;
            problema1F = false;
            problema2F = false;
            problema3F = false;
            problema4F = false;
            problema5F = false;
            InitializeComponent();
        }

        private void iniciarLayout()
        {
            LabelP1.Text = "No";
            LabelP2.Text = "No";
            LabelP3.Text = "No";
            LabelP4.Text = "No";
            LabelP5.Text = "No";
            labelP6.Text = "No";
            labelP7.Text = "No";
            labelP8.Text = "No";
            labelP9.Text = "No";
            labelP10.Text = "No";
            LabelP1.ForeColor = Color.Red;
            LabelP2.ForeColor = Color.Red;
            LabelP3.ForeColor = Color.Red;
            LabelP4.ForeColor = Color.Red;
            LabelP5.ForeColor = Color.Red;
            labelP6.ForeColor = Color.Red;
            labelP7.ForeColor = Color.Red;
            labelP8.ForeColor = Color.Red;
            labelP9.ForeColor = Color.Red;
            labelP10.ForeColor = Color.Red;
        }

        public void actualizarLayout()
        {
            if (problema1R == true)
            {
                LabelP1.Text = "¡Ok!";
                LabelP1.ForeColor = Color.Green;
            }
            if (problema2R == true)
            {
                LabelP2.Text = "¡Ok!";
                LabelP2.ForeColor = Color.Green;
            }
            if (problema3R == true)
            {
                LabelP3.Text = "¡Ok!";
                LabelP3.ForeColor = Color.Green;
            }
            if (problema4R == true)
            {
                LabelP4.Text = "¡Ok!";
                LabelP4.ForeColor = Color.Green;
            }
            if (problema5R == true)
            {
                LabelP5.Text = "¡Ok!";
                LabelP5.ForeColor = Color.Green;
            }
            if (problema6R == true)
            {
                labelP6.Text = "¡Ok!";
                labelP6.ForeColor = Color.Green;
            }
            if (problema7R == true)
            {
                labelP7.Text = "¡Ok!";
                labelP7.ForeColor = Color.Green;
            }
            if (problema8R == true)
            {
                labelP8.Text = "¡Ok!";
                labelP8.ForeColor = Color.Green;
            }
            if (problema9R == true)
            {
                labelP9.Text = "¡Ok!";
                labelP9.ForeColor = Color.Green;
            }
            if (problema10R == true)
            {
                labelP10.Text = "¡Ok!";
                labelP10.ForeColor = Color.Green;
            }
        }

        public void actualizarVidas(int a)
        {
            vidas = a;
            labelVidas.Text = vidas.ToString();
        }

        public void actualizarCorrectas(int c)
        {
            correctas = c;
            LabelResueltos.Text = correctas.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos SQLite|*.sqlite|Todos los archivos|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            // Verificar si se seleccionó un archivo
            if (result == DialogResult.OK)
            {
                enunciados = null;
                string archivoSeleccionado = openFileDialog.FileName;
                ejercicios = new BDD(archivoSeleccionado);
                enunciados = new List<EnunciadoBase>();
                enunciados = ejercicios.ObtenerTodosEnunciados();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelVidas.Text = vidas.ToString();
            LabelResueltos.Text = correctas.ToString();
            iniciarLayout();
        }

        private void botonP1_Click(object sender, EventArgs e)
        {
            if (problema1R == false)
            {
                if (problema1F == true)
                {
                    //e1 = problema.enunciadosSeleccionados[0].GenerarEnunciado();
                    //r1 = problema.enunciadosSeleccionados[0].EntregarRespuesta();
                    problema1F = false;
                }
                Problema_1 problema1Form = new Problema_1(e1, r1, 1, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP2_Click(object sender, EventArgs e)
        {
            if (problema2R == false)
            {
                if (problema2F == true)
                {
                    //e2 = problema.enunciadosSeleccionados[1].GenerarEnunciado();
                    //r2 = problema.enunciadosSeleccionados[1].EntregarRespuesta();
                    problema2F = false;
                }
                Problema_1 problema1Form = new Problema_1(e2, r2, 2, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP3_Click(object sender, EventArgs e)
        {
            if (problema3R == false)
            {
                if (problema3F == true)
                {
                    //e3 = problema.enunciadosSeleccionados[2].GenerarEnunciado();
                    //r3 = problema.enunciadosSeleccionados[2].EntregarRespuesta();
                    problema3F = false;
                }
                Problema_1 problema1Form = new Problema_1(e3, r3, 3, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP4_Click(object sender, EventArgs e)
        {
            if (problema4R == false)
            {
                if (problema2F == true)
                {
                    //e4 = problema.enunciadosSeleccionados[3].GenerarEnunciado();
                    //r4 = problema.enunciadosSeleccionados[3].EntregarRespuesta();
                    problema4F = false;
                }
                Problema_1 problema1Form = new Problema_1(e4, r4, 4, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP5_Click(object sender, EventArgs e)
        {
            if (problema5R == false)
            {
                if (problema5F == true)
                {
                    //e5 = problema.enunciadosSeleccionados[4].GenerarEnunciado();
                    // r5 = problema.enunciadosSeleccionados[4].EntregarRespuesta();
                    problema5F = false;
                }
                Problema_1 problema1Form = new Problema_1(e5, r5, 5, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP6_Click(object sender, EventArgs e)
        {

        }

        private void botonP7_Click(object sender, EventArgs e)
        {

        }

        private void botonP8_Click(object sender, EventArgs e)
        {

        }

        private void botonP9_Click(object sender, EventArgs e)
        {

        }

        private void botonP10_Click(object sender, EventArgs e)
        {

        }
    }
}
