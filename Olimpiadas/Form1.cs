namespace Olimpiadas
{
    public partial class Form1 : Form
    {
        private Problema problema;
        public int vidas = 0;
        public int correctas = 0;
        public bool problema1R, problema2R, problema3R, problema4R, problema5R, problema1F, problema2F, problema3F, problema4F, problema5F;
        private string e1, e2, e3, e4, e5;
        private int r1, r2, r3, r4, r5;
        public BDD bdd;
        public Form1()
        {
            bdd = new BDD();
            vidas = 5;
            correctas = 0;
            problema1R = false;
            problema2R = false;
            problema3R = false;
            problema4R = false;
            problema5R = false;
            problema1F = false;
            problema2F = false;
            problema3F = false;
            problema4F = false;
            problema5F = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            problema = new Problema();

            e1 = problema.enunciadosSeleccionados[0].GenerarEnunciado();
            r1 = problema.enunciadosSeleccionados[0].EntregarRespuesta();
            e2 = problema.enunciadosSeleccionados[1].GenerarEnunciado();
            r2 = problema.enunciadosSeleccionados[1].EntregarRespuesta();
            e3 = problema.enunciadosSeleccionados[2].GenerarEnunciado();
            r3 = problema.enunciadosSeleccionados[2].EntregarRespuesta();
            e4 = problema.enunciadosSeleccionados[3].GenerarEnunciado();
            r4 = problema.enunciadosSeleccionados[3].EntregarRespuesta();
            e5 = problema.enunciadosSeleccionados[4].GenerarEnunciado();
            r5 = problema.enunciadosSeleccionados[4].EntregarRespuesta();
        }

        private void iniciarLayout()
        {
            LabelP1.Text = "No";
            LabelP2.Text = "No";
            LabelP3.Text = "No";
            LabelP4.Text = "No";
            LabelP5.Text = "No";
            LabelP1.ForeColor = Color.Red;
            LabelP2.ForeColor = Color.Red;
            LabelP3.ForeColor = Color.Red;
            LabelP4.ForeColor = Color.Red;
            LabelP5.ForeColor = Color.Red;
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
                    e1 = problema.enunciadosSeleccionados[0].GenerarEnunciado();
                    r1 = problema.enunciadosSeleccionados[0].EntregarRespuesta();
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
                    e2 = problema.enunciadosSeleccionados[1].GenerarEnunciado();
                    r2 = problema.enunciadosSeleccionados[1].EntregarRespuesta();
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
                    e3 = problema.enunciadosSeleccionados[2].GenerarEnunciado();
                    r3 = problema.enunciadosSeleccionados[2].EntregarRespuesta();
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
                    e4 = problema.enunciadosSeleccionados[3].GenerarEnunciado();
                    r4 = problema.enunciadosSeleccionados[3].EntregarRespuesta();
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
                    e5 = problema.enunciadosSeleccionados[4].GenerarEnunciado();
                    r5 = problema.enunciadosSeleccionados[4].EntregarRespuesta();
                    problema5F = false;
                }
                Problema_1 problema1Form = new Problema_1(e5, r5, 5, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
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
            AlterarBDD bdd = new AlterarBDD();
            bdd.ShowDialog();
        }
    }
}
