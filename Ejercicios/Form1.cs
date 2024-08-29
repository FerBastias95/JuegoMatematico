using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Reflection;
using NCalc;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicios {
    public partial class Form1 : Form
    {
        public int vidas = 0;
        public int dif = 3;
        public int correctas = 0;
        public int tiempo;
        public bool problema1R, problema2R, problema3R, problema4R, problema5R,
            problema6R, problema7R, problema8R, problema9R, problema10R,
            problema1F, problema2F, problema3F, problema4F, problema5F
            , problema6F, problema7F, problema8F, problema9F, problema10F;
        public List<int> orden;
        public List<EnunciadoBase> elegidos;
        public List<EnunciadoBase> enunciados;
        public List<EnunciadoBase> avanzados;
        public List<Label> labels;
        public List<ReaLTaiizor.Controls.Button> botones;
        public List<bool> resueltos;
        public List<bool> fallados;
        public List<string> original;
        public bool inicio = false;
        public bool practica = false;
        string pathName = "";
        BDD ejercicios;
        public Form1()
        {
            tiempo = 60;
            vidas = 5;
            correctas = 0;
            InitializeComponent();
        }
        private void iniciarLayout()
        {
            correctas = 0;
            dif = 0;
            vidas = 5;
            tiempo = 60;
            for (int i = 0; i < 10; i++)
            {
                labels[i].Text = "Falta completar";
                labels[i].ForeColor = Color.Red;
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

        private void cargarEnunciados()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos SQLite|*.sqlite|Todos los archivos|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Inicializar las listas
                iniciarLayout();
                ejercicios = null;
                enunciados = new List<EnunciadoBase>();
                avanzados = new List<EnunciadoBase>();
                elegidos = new List<EnunciadoBase>();
                original = new List<string>();

                string archivoSeleccionado = openFileDialog.FileName;
                int i = 0;
                Random randy = new Random();
                ejercicios = new BDD(archivoSeleccionado);
                enunciados = ejercicios.ObtenerTodosEnunciados();
                // Filtrar enunciados avanzados y almacenarlos en la lista avanzados
                foreach (var enunciado in enunciados)
                {
                    enunciado.Original = enunciado.Enunciado;
                    if (enunciado.Avanzado)
                    {
                        avanzados.Add(enunciado);
                    }
                }

                // Verificar la cantidad total de enunciados
                int totalEnunciados = enunciados.Count;
                if (totalEnunciados <= 10)
                {
                    // Si hay 10 o menos enunciados, agregar todos los enunciados
                    elegidos.AddRange(enunciados);
                }
                else
                {
                    // Si hay más de 10 enunciados, seleccionar 10 al azar
                    Seleccionar10(enunciados, totalEnunciados);
                }

                // Si la cantidad de enunciados es menor a 10, rellenar con enunciados avanzados
                if (avanzados.Count() > 0)
                {
                    while (elegidos.Count < 10)
                    {
                        int a = 0;
                        // Generar números aleatorios para seleccionar los enunciados restantes de la lista de enunciados avanzados
                        List<int> indicesRestantes = GenerarNumerosAleatorios(avanzados.Count - 1);
                        // Agregar los enunciados restantes a la lista de elegidos
                        foreach (int index in indicesRestantes)
                        {
                            // Crear un nuevo enunciado y copiar las propiedades del enunciado base
                            EnunciadoBase enunciadoNuevo = new EnunciadoBase();
                            EnunciadoBase enunciadoBase = avanzados[indicesRestantes[index]];
                            enunciadoNuevo = crearEnunciado(enunciadoNuevo, enunciadoBase, a);
                            // Agregar el nuevo enunciado a la lista de elegidos
                            CalcularRespuesta(enunciadoNuevo);
                            elegidos.Add(enunciadoNuevo);
                            a++;
                        }
                    }
                }
                else
                {
                    while (elegidos.Count < 10)
                    {
                        int a = 0;
                        // Generar números aleatorios para seleccionar los enunciados restantes de la lista de enunciados avanzados
                        List<int> indicesRestantes = GenerarNumerosAleatorios(elegidos.Count - 1);
                        // Agregar los enunciados restantes a la lista de elegidos
                        foreach (int index in indicesRestantes)
                        {
                            // Crear un nuevo enunciado y copiar las propiedades del enunciado base
                            EnunciadoBase enunciadoNuevo = new EnunciadoBase();
                            EnunciadoBase enunciadoBase = elegidos[indicesRestantes[index]];

                            // Agregar el nuevo enunciado a la lista de elegidos
                            elegidos.Add(crearEnunciado(enunciadoNuevo, enunciadoBase, a));
                            a++;
                        }
                    }
                }

                // Mostrar los enunciados seleccionados en la interfaz gráfica
                if (avanzados.Count > 0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        var enunciado = elegidos[j];
                        modificarVariables(enunciado);
                        while (!IsResponseValid(enunciado))
                        {
                            modificarVariables(enunciado);
                        }
                    }
                }
                for (int j = 0; j < 10; j++)
                {
                    botones[j].Text = elegidos[j].Nombre;
                    resueltos[j] = false;
                }
                dificultad(0);
                labelVidas.Text = vidas.ToString();
                LabelResueltos.Text = correctas.ToString();
                cambiarVariables.Enabled = true;
                botonOpciones.Enabled = true;
            }
        }

        private EnunciadoBase crearEnunciado(EnunciadoBase enunciadoNuevo, EnunciadoBase enunciadoBase, int a)
        {
            enunciadoNuevo.Nombre = enunciadoBase.Nombre;
            enunciadoNuevo.Avanzado = enunciadoBase.Avanzado;
            enunciadoNuevo.Decimal1 = enunciadoBase.Decimal1;
            enunciadoNuevo.Decimal2 = enunciadoBase.Decimal2;
            enunciadoNuevo.Decimal3 = enunciadoBase.Decimal3;
            enunciadoNuevo.Decimal4 = enunciadoBase.Decimal4;
            enunciadoNuevo.Inicio1 = enunciadoBase.Inicio1;
            enunciadoNuevo.Inicio2 = enunciadoBase.Inicio2;
            enunciadoNuevo.Inicio3 = enunciadoBase.Inicio3;
            enunciadoNuevo.Inicio4 = enunciadoBase.Inicio4;
            enunciadoNuevo.Final1 = enunciadoBase.Final1;
            enunciadoNuevo.Final2 = enunciadoBase.Final2;
            enunciadoNuevo.Final3 = enunciadoBase.Final3;
            enunciadoNuevo.Final4 = enunciadoBase.Final4;
            enunciadoNuevo.Enunciado = enunciadoBase.Enunciado;
            enunciadoNuevo.Imagen = enunciadoBase.Imagen;
            enunciadoNuevo.Formula = enunciadoBase.Formula;
            enunciadoNuevo.Original = enunciadoBase.Original;
            enunciadoNuevo.indice = a;
            enunciadoNuevo.Categoria = enunciadoBase.Categoria;
            enunciadoNuevo.Curso = enunciadoBase.Curso;
            enunciadoNuevo.Respuesta = enunciadoBase.Respuesta;
            return enunciadoNuevo;
        }
        static List<int> GenerarNumerosAleatorios(int X)
        {
            List<int> numerosAleatorios = new List<int>();
            HashSet<int> numerosGenerados = new HashSet<int>(); // Conjunto para evitar repeticiones
            Random rnd = new Random();

            while (numerosAleatorios.Count < X + 1)
            {
                int numeroAleatorio = rnd.Next(0, X + 1); // Genera un número aleatorio entre 0 y X
                if (!numerosGenerados.Contains(numeroAleatorio))
                {
                    numerosAleatorios.Add(numeroAleatorio);
                    numerosGenerados.Add(numeroAleatorio);
                }
            }
            return numerosAleatorios;
        }

        public void Seleccionar10(List<EnunciadoBase> e, int totalEnunciados)
        {
            List<int> indicesSeleccionados = GenerarNumerosAleatorios(totalEnunciados - 1);
            if (elegidos.Count < 10)
            {
                for (int k = 0; k < 10; k++)
                {
                    EnunciadoBase enunciadoNuevo = new EnunciadoBase();
                    enunciadoNuevo = e[indicesSeleccionados[k]];
                    elegidos.Add(enunciadoNuevo);
                }
            }
            else
            {
                for (int k = 0; k < 10; k++)
                {
                    EnunciadoBase enunciadoNuevo = new EnunciadoBase();
                    enunciadoNuevo = e[indicesSeleccionados[k]];
                    elegidos[k] = enunciadoNuevo;
                }
            }
            for (int j = 0; j < 10; j++)
            {
                botones[j].Text = elegidos[j].Nombre;
            }
        }

        public void modificarVariables(EnunciadoBase enunciadoBase)
        {
            Random randy = new Random();
            EnunciadoBase e = enunciadoBase;
            e.Enunciado = e.Original;

            if (e.Avanzado)
            {
                if (e.Decimal1)
                {
                    if (e.Final1 > e.Inicio1)
                    {
                        double extra = randy.NextDouble();
                        e.Variable1 = e.Inicio1 + (e.Final1 - e.Inicio1) * extra;
                        e.Variable1 = Math.Round(e.Variable1, 2);
                    }
                    else if (e.Final1 < e.Inicio1)
                    {
                        double extra = randy.NextDouble();
                        e.Variable1 = e.Inicio1 + (e.Inicio1 - e.Final1) * extra;
                        e.Variable1 = Math.Round(e.Variable1, 2);
                    }
                }
                else
                {
                    if (e.Final1 > e.Inicio1)
                    {
                        e.Variable1 = randy.Next(e.Inicio1, (int)e.Final1 + 1);
                    }
                    else if (e.Final1 < e.Inicio1)
                    {
                        e.Variable1 = randy.Next(e.Final1, (int)e.Inicio1 + 1);
                    }
                }
                if (e.Decimal2)
                {
                    if (e.Final2 > e.Inicio2)
                    {
                        double extra = randy.NextDouble();
                        e.Variable2 = e.Inicio2 + (e.Final2 - e.Inicio2) * extra;
                        e.Variable2 = Math.Round(e.Variable2, 2);
                    }
                    else if (e.Final2 < e.Inicio2)
                    {
                        double extra = randy.NextDouble();
                        e.Variable2 = e.Inicio2 + (e.Inicio2 - e.Final2) * extra;
                        e.Variable2 = Math.Round(e.Variable2, 2);
                    }
                }
                else
                {
                    if (e.Final2 > e.Inicio2)
                    {
                        e.Variable2 = randy.Next(e.Inicio2, (int)e.Final2 + 1);
                    }
                    else if (e.Final2 < e.Inicio2)
                    {
                        e.Variable2 = randy.Next(e.Final2, (int)e.Inicio2 + 1);
                    }
                }
                if (e.Decimal3)
                {
                    if (e.Final3 > e.Inicio3)
                    {
                        double extra = randy.NextDouble();
                        e.Variable3 = e.Inicio3 + (e.Final3 - e.Inicio3) * extra;
                        e.Variable3 = Math.Round(e.Variable3, 2);
                    }
                    else if (e.Final3 < e.Inicio3)
                    {
                        double extra = randy.NextDouble();
                        e.Variable3 = e.Inicio3 + (e.Inicio3 - e.Final3) * extra;
                        e.Variable3 = Math.Round(e.Variable3, 2);
                    }
                }
                else
                {
                    if (e.Final3 > e.Inicio3)
                    {
                        e.Variable3 = randy.Next(e.Inicio3, (int)e.Final3 + 1);
                    }
                    else if (e.Final3 < e.Inicio3)
                    {
                        e.Variable3 = randy.Next(e.Final3, (int)e.Inicio3 + 1);
                    }
                }
                if (e.Decimal4)
                {
                    if (e.Final4 > e.Inicio4)
                    {
                        double extra = randy.NextDouble();
                        e.Variable4 = e.Inicio4 + (e.Final4 - e.Inicio4) * extra;
                        e.Variable4 = Math.Round(e.Variable4, 2);
                    }
                    else if (e.Final4 < e.Inicio4)
                    {
                        double extra = randy.NextDouble();
                        e.Variable4 = e.Inicio4 + (e.Inicio4 - e.Final4) * extra;
                        e.Variable4 = Math.Round(e.Variable4, 2);
                    }
                }
                else
                {
                    if (e.Final4 > e.Inicio4)
                    {
                        e.Variable4 = randy.Next(e.Inicio4, (int)e.Final4 + 1);
                    }
                    else if (e.Final4 < e.Inicio4)
                    {
                        e.Variable4 = randy.Next(e.Final4, (int)e.Inicio4 + 1);
                    }
                }
                reemplazarVariables(e);
                e.Respuesta = CalcularRespuesta(e);
            }
        }
        public void reemplazarVariables(EnunciadoBase enunciado)
        {
            if (enunciado.Avanzado)
            {
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v1}", enunciado.Variable1.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v2}", enunciado.Variable2.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v3}", enunciado.Variable3.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v4}", enunciado.Variable4.ToString());
            }
        }
        public double CalcularRespuesta(EnunciadoBase enunciado)
        {
            // Reemplazar las variables en la fórmula por sus valores
            string formulaEvaluable = enunciado.Formula;
            formulaEvaluable = formulaEvaluable.Replace("Var1", enunciado.Variable1.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var2", enunciado.Variable2.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var3", enunciado.Variable3.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var4", enunciado.Variable4.ToString());
            formulaEvaluable = formulaEvaluable.Replace("π", "3.1415926535897932384626433832795");
            try
            {
                object result = new DataTable().Compute(formulaEvaluable, null);
                Console.WriteLine($"El resultado de la operación {formulaEvaluable} es: {result}");
                double resultadoNumerico = Convert.ToDouble(result);
                //double resultadoRedondeado = Math.Round(resultadoNumerico, 1);
                return resultadoNumerico;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public bool IsResponseValid(EnunciadoBase enunciado)
        {
            int categoria = enunciado.Categoria;

            // Validar la respuesta solo para las categorías 1, 2 y 3
            if (categoria == 1)
            {
                // La respuesta debe ser menor que el valor del curso
                return CalcularRespuesta(enunciado) > enunciado.Curso;
            }
            else if (categoria == 2)
            {
                // La respuesta debe ser mayor que el valor del curso
                return CalcularRespuesta(enunciado) < enunciado.Curso;
            }
            else if (categoria == 3)
            {
                // La respuesta puede ser cualquier valor entero
                return IsInteger(CalcularRespuesta(enunciado).ToString());
            }
            else if (categoria == 4)
            {
                // La respuesta puede ser cualquier valor entero
                return CalcularRespuesta(enunciado) % enunciado.Curso == 0;
            }
            else
            {
                // Todas las demás categorías devuelven respuestas válidas automáticamente
                return true;
            }
        }
        private bool IsInteger(string valor)
        {
            // Try to parse the string to a BigInteger
            return BigInteger.TryParse(valor, out _);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labels = [LabelP1, LabelP2, LabelP3, LabelP4, LabelP5, labelP6, labelP7, labelP8, labelP9, labelP10];
            resueltos = [problema1R, problema2R, problema3R, problema4R, problema5R, problema6R, problema7R, problema8R, problema9R, problema10R];
            botones = [botonP1, botonP2, botonP3, botonP4, botonP5, botonP6, botonP7, botonP8, botonP9, botonP10, button1];
            fallados = [problema1F, problema2F, problema3F, problema4F, problema5F
            , problema6F, problema7F, problema8F, problema9F, problema10F];

            labelVidas.Text = vidas.ToString();
            LabelResueltos.Text = correctas.ToString();
            dificultad(3);
            iniciarLayout();
            abrirEnunciados.ForeColor = Color.Black;
            abrirEnunciados2.ForeColor = Color.Black;
            cambiarEnunciados.ForeColor = Color.Black;
            cambiarEnunciados.InactiveColor = SystemColors.InactiveCaption;
            cambiarEnunciados.EnteredColor = SystemColors.ActiveCaption;
            cambiarEnunciados.BorderColor = Color.FromArgb(32, 34, 37);
            cambiarEnunciados.EnteredBorderColor = Color.Black;
            cambiarEnunciados.EnteredColor = SystemColors.ActiveCaption;
            cambiarEnunciados.PressedBorderColor = SystemColors.Highlight;
            cambiarEnunciados.PressedColor = SystemColors.Highlight;
            cambiarVariables.ForeColor = Color.Black;
            botonOpciones.ForeColor = Color.Black;
            botonP1.ForeColor = Color.Black;
            botonP2.ForeColor = Color.Black;
            botonP3.ForeColor = Color.Black;
            botonP4.ForeColor = Color.Black;
            botonP5.ForeColor = Color.Black;
            botonP6.ForeColor = Color.Black;
            botonP7.ForeColor = Color.Black;
            botonP8.ForeColor = Color.Black;
            botonP9.ForeColor = Color.Black;
            botonP10.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            toolTip1.SetToolTip(this.botonOpciones, "Acá puede definir cuántos ejercicios desea resolver. También puede optar por un desafío con tiempo.");
            toolTip1.SetToolTip(this.button1, "Presione aquí para iniciar el desafío contrarreloj.");
            toolTip1.SetToolTip(this.cambiarVariables, "Si desea modificar los números de los enunciados, presione aquí.");
            toolTip1.SetToolTip(this.abrirEnunciados, "Presione aquí para abrir una lista de ejercicios. En caso de no tener, utilice el generador.");
        }
        private void cambiarVariables_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                modificarVariables(elegidos[i]);
                while (!IsResponseValid(elegidos[i]))
                {
                    modificarVariables(elegidos[i]);
                }
            }
            MessageBox.Show("Enunciados modificados");
        }
        private void botonOpciones_Click(object sender, EventArgs e)
        {
            List<int> numeros = GenerarNumerosAleatorios(enunciados.Count - 1);
            Opciones o = new Opciones(this);
            o.ShowDialog();
        }
        public void dificultad(int d)
        {
            dif = d;
            button1.Hide();
            int i = 0;
            for (int j = 0; j < 10; j++)
            {
                labels[j].Hide();
                botones[j].Hide();
            }

            if (d == 0)
            {
                abrirEnunciados2.Visible = false;
                abrirEnunciados.Text = "Cambiar Enunciados";

                if (enunciados.Count > 10)
                {
                    cambiarEnunciados.Show();
                    cambiarVariables.Size = new Size(472, 44);
                    cambiarVariables.Location = new Point(363, 357);
                }
                else
                {
                    cambiarEnunciados.Hide();
                    cambiarVariables.Size = new Size(718, 44);
                    cambiarVariables.Location = new Point(117, 357);
                }

                if (!inicio) {
                    if (practica) {
                        if (avanzados.Count > 0) {
                            cambiarVariables.Show();
                        }
                        abrirEnunciados.Size = new System.Drawing.Size(472, 35);
                        botonOpciones.Show();
                    }
                    else {
                        abrirEnunciados.Size = new Size(472, 71);
                    }
                    inicio = true;
                }
                
                backColor.Show();
                labelVidas.Show();
                LabelResueltos.Show();
                label1.Show();
                label2.Show();
                abrirEnunciados.Location = new Point(363, 407);

                botones[0].Location = new Point(117, 164);
                botones[1].Location = new Point(264, 164);
                botones[2].Location = new Point(412, 164);
                botones[3].Location = new Point(563, 164);
                botones[4].Location = new Point(707, 164);
                labels[0].Location = new Point(107, 138);
                labels[1].Location = new Point(255, 138);
                labels[2].Location = new Point(403, 138);
                labels[3].Location = new Point(552, 138);
                labels[4].Location = new Point(698, 138);

                for (i = 0; i < 5; i++)
                {
                    labels[i].Show();
                    botones[i].Show();
                    label3.Hide();
                    label4.Hide();
                }
            }
            else if (d == 1)
            {
                abrirEnunciados2.Visible = false;
                abrirEnunciados.Size = new Size(718, 71);

                if (practica) {
                    if (avanzados.Count > 0) {
                        cambiarVariables.Show();
                    }
                    botonOpciones.Show();
                    abrirEnunciados.Size = new Size(718, 35);

                }

                labelVidas.Show();
                LabelResueltos.Show();
                backColor.Show();
                label1.Show();
                label2.Show();
                abrirEnunciados.Size = new System.Drawing.Size(472, 35);
                abrirEnunciados.Location = new Point(363, 407);

                botones[0].Location = new Point(117, 110);
                botones[1].Location = new Point(264, 110);
                botones[2].Location = new Point(412, 110);
                botones[3].Location = new Point(563, 110);
                botones[4].Location = new Point(707, 110);
                labels[0].Location = new Point(107, 84);
                labels[1].Location = new Point(255, 84);
                labels[2].Location = new Point(403, 84);
                labels[3].Location = new Point(552, 84);
                labels[4].Location = new Point(698, 84);
                for (i = 0; i < 10; i++)
                {
                    labels[i].Show();
                    botones[i].Show();
                }
                label3.Hide();
                label4.Hide();
            }
            else if (d == 2)
            {
                abrirEnunciados2.Visible = false;

                labelVidas.Show();
                LabelResueltos.Show();
                label1.Show();
                label2.Show();
                backColor.Show();
                cambiarVariables.Show();
                botonOpciones.Show();
                abrirEnunciados.Size = new System.Drawing.Size(472, 35);
                abrirEnunciados.Location = new Point(363, 407);

                for (int j = 0; j < 10; j++)
                {
                    labels[j].Hide();
                    botones[j].Hide();
                }
                label3.Hide();
                label4.Hide();
                button1.Show();
            }
            else
            {
                labelVidas.Hide();
                LabelResueltos.Hide();
                label1.Hide();
                label2.Hide();
                backColor.Hide();
                cambiarVariables.Hide();
                botonOpciones.Hide();
                abrirEnunciados.Location = new Point(117, 374);
                abrirEnunciados.Size = new System.Drawing.Size(355, 75);
                for (int j = 0; j < 10; j++)
                {
                    labels[j].Hide();
                    botones[j].Hide();
                }
                label3.Show();
                label4.Show();
                button1.Hide();
            }
        }

        private void CrearVentana(int i)
        {
            if (resueltos[i] == false)
            {
                VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[i], this, i);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            practica = true;
            cargarEnunciados();
        }

        private void abrirEnunciados2_Click(object sender, EventArgs e)
        {
            cargarEnunciados();
        }
        private void botonP1_Click(object sender, EventArgs e)
        {
            CrearVentana(0);
        }
        private void botonP2_Click(object sender, EventArgs e)
        {
            CrearVentana(1);
        }
        private void botonP3_Click(object sender, EventArgs e)
        {
            CrearVentana(2);
        }
        private void botonP4_Click(object sender, EventArgs e)
        {
            CrearVentana(3);
        }
        private void botonP5_Click(object sender, EventArgs e)
        {
            CrearVentana(4);
        }
        private void botonP6_Click(object sender, EventArgs e)
        {
            CrearVentana(5);
        }
        private void botonP7_Click(object sender, EventArgs e)
        {
            CrearVentana(6);
        }
        private void botonP8_Click(object sender, EventArgs e)
        {
            CrearVentana(7);
        }
        private void botonP9_Click(object sender, EventArgs e)
        {
            CrearVentana(8);
        }
        private void botonP10_Click(object sender, EventArgs e)
        {
            CrearVentana(9);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (problema1R == false)
            {
                VentanaEnunciadoDesafio problema1Form = new VentanaEnunciadoDesafio(enunciados, this);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }
        private void cambiarEnunciados_Click(object sender, EventArgs e)
        {
            Seleccionar10(enunciados, enunciados.Count);
        }
        public void Victoria()
        {
            Victory v = new Victory();
            v.ShowDialog();
        }

    }
}
