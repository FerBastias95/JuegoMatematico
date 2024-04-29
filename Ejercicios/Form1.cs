using System.Data;
using System.Drawing.Drawing2D;
using NCalc;

namespace Ejercicios {
    public partial class Form1 : Form {
        public int vidas = 0;
        public int dif = 3;
        public int correctas = 0;
        public int botonesActivos = 0;
        public bool problema1R, problema2R, problema3R, problema4R, problema5R,
            problema6R, problema7R, problema8R, problema9R, problema10R,
            problema1F, problema2F, problema3F, problema4F, problema5F
            , problema6F, problema7F, problema8F, problema9F, problema10F;
        public List<int> orden;
        public List<EnunciadoBase> elegidos;
        public List<EnunciadoBase> enunciados;
        public List<EnunciadoBase> avanzados;
        public List<Label> labels;
        public List<Button> botones;
        public List<bool> resueltos;
        public List<bool> fallados;
        public List<string> problemas;
        public List<string> original;
        public List<double> respuestas;
        string pathName = "";
        BDD ejercicios;
        public Form1() {
            vidas = 5;
            correctas = 0;
            InitializeComponent();
        }
        private void iniciarLayout() {
            for (int i = 0; i < 10; i++) {
                labels[i].Text = "No";
                labels[i].ForeColor = Color.Red;
            }
        }
        public void actualizarVidas(int a) {
            vidas = a;
            labelVidas.Text = vidas.ToString();
        }
        public void actualizarCorrectas(int c) {
            correctas = c;
            LabelResueltos.Text = correctas.ToString();
        }
        private void button1_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos SQLite|*.sqlite|Todos los archivos|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK) {
                // Inicializar las listas
                ejercicios = null;
                enunciados = new List<EnunciadoBase>();
                avanzados = new List<EnunciadoBase>();
                elegidos = new List<EnunciadoBase>();
                problemas = new List<string>(); // Inicializar como lista vac�a
                respuestas = new List<double>(); // Inicializar como lista vac�a
                original = new List<string>();

                string archivoSeleccionado = openFileDialog.FileName;
                int i = 0;
                Random randy = new Random();
                botonesActivos = 0;
                ejercicios = new BDD(archivoSeleccionado);
                enunciados = ejercicios.ObtenerTodosEnunciados();

                // Filtrar enunciados avanzados y almacenarlos en la lista avanzados
                foreach (var enunciado in enunciados) {
                    if (enunciado.Avanzado) {
                        avanzados.Add(enunciado);
                    }
                }

                // Verificar la cantidad total de enunciados
                int totalEnunciados = enunciados.Count;
                if (totalEnunciados <= 10) {
                    // Si hay 10 o menos enunciados, agregar todos los enunciados
                    elegidos.AddRange(enunciados);
                }
                else {
                    // Si hay m�s de 10 enunciados, seleccionar 10 al azar
                    List<int> indicesSeleccionados = GenerarNumerosAleatorios(totalEnunciados - 1);
                    foreach (int index in indicesSeleccionados) {
                        elegidos.Add(enunciados[index]);
                    }
                }

                // Si la cantidad de enunciados es menor a 10, rellenar con enunciados avanzados
                while (elegidos.Count < 10) {
                    // Calcular cu�ntos enunciados faltan
                    int enunciadosRestantes = 10 - elegidos.Count;

                    // Generar n�meros aleatorios para seleccionar los enunciados restantes de la lista de enunciados avanzados
                    List<int> indicesRestantes = GenerarNumerosAleatorios(avanzados.Count - 1);

                    // Agregar los enunciados restantes a la lista de elegidos
                    foreach (int index in indicesRestantes) {
                        elegidos.Add(avanzados[index]);
                        if (elegidos.Count == 10) break; // Salir del bucle si ya tenemos 10 enunciados
                    }
                }

                // Mostrar los enunciados seleccionados en la interfaz gr�fica
                for (int j = 0; j < elegidos.Count; j++) {
                    var enunciado = elegidos[j];
                    botones[j].Show();
                    original.Add(enunciado.Enunciado);
                    modificarVariables(j, elegidos);
                    reemplazarVariables(enunciado);
                    problemas.Add(enunciado.Enunciado);
                    respuestas.Add(enunciado.Respuesta);
                }
                cambiarVariables.Enabled = true;
            }
            else {
                MessageBox.Show("No se encontraron enunciados en el archivo seleccionado.");
            }
        }
        static List<int> GenerarNumerosAleatorios(int X) {
            List<int> numerosAleatorios = new List<int>();
            HashSet<int> numerosGenerados = new HashSet<int>(); // Conjunto para evitar repeticiones
            Random rnd = new Random();

            while (numerosAleatorios.Count < X + 1) {
                int numeroAleatorio = rnd.Next(0, X + 1); // Genera un n�mero aleatorio entre 0 y X

                if (!numerosGenerados.Contains(numeroAleatorio)) {
                    numerosAleatorios.Add(numeroAleatorio);
                    numerosGenerados.Add(numeroAleatorio);
                }
            }
            return numerosAleatorios;
        }

        public void modificarVariables(int indice, List<EnunciadoBase> elegidos) {
            Random randy = new Random();
            var enunciado = elegidos[indice];
                if (enunciado.Avanzado) {
                    if (enunciado.Decimal1) {
                        if (enunciado.Final1 > enunciado.Inicio1) {
                            double extra = randy.NextDouble();
                            enunciado.Variable1 = enunciado.Inicio1 + (enunciado.Final1 - enunciado.Inicio1) * extra;
                            enunciado.Variable1 = Math.Round(enunciado.Variable1, 2);
                        }
                        else if (enunciado.Final1 < enunciado.Inicio1) {
                            double extra = randy.NextDouble();
                            enunciado.Variable1 = enunciado.Inicio1 + (enunciado.Inicio1 - enunciado.Final1) * extra;
                            enunciado.Variable1 = Math.Round(enunciado.Variable1, 2);
                        }
                    }
                    else {
                        if (enunciado.Final1 > enunciado.Inicio1) {
                            enunciado.Variable1 = randy.Next((int)enunciado.Inicio1, (int)enunciado.Final1 + 1);
                        }
                        else if (enunciado.Final1 < enunciado.Inicio1) {
                            enunciado.Variable1 = randy.Next((int)enunciado.Final1, (int)enunciado.Inicio1 + 1);
                        }
                    }
                    if (enunciado.Decimal2) {
                        if (enunciado.Final2 > enunciado.Inicio2) {
                            double extra = randy.NextDouble();
                            enunciado.Variable2 = enunciado.Inicio2 + (enunciado.Final2 - enunciado.Inicio2) * extra;
                            enunciado.Variable2 = Math.Round(enunciado.Variable2, 2);
                        }
                        else if (enunciado.Final2 < enunciado.Inicio2) {
                            double extra = randy.NextDouble();
                            enunciado.Variable2 = enunciado.Inicio2 + (enunciado.Inicio2 - enunciado.Final2) * extra;
                            enunciado.Variable2 = Math.Round(enunciado.Variable2, 2);
                        }
                    }
                    else {
                        if (enunciado.Final2 > enunciado.Inicio2) {
                            enunciado.Variable2 = randy.Next((int)enunciado.Inicio2, (int)enunciado.Final2 + 1);
                        }
                        else if (enunciado.Final2 < enunciado.Inicio2) {
                            enunciado.Variable2 = randy.Next((int)enunciado.Final2, (int)enunciado.Inicio2 + 1);
                        }
                    }
                    if (enunciado.Decimal3) {
                        if (enunciado.Final3 > enunciado.Inicio3) {
                            double extra = randy.NextDouble();
                            enunciado.Variable3 = enunciado.Inicio3 + (enunciado.Final3 - enunciado.Inicio3) * extra;
                            enunciado.Variable3 = Math.Round(enunciado.Variable3, 2);
                        }
                        else if (enunciado.Final3 < enunciado.Inicio3) {
                            double extra = randy.NextDouble();
                            enunciado.Variable3 = enunciado.Inicio3 + (enunciado.Inicio3 - enunciado.Final3) * extra;
                            enunciado.Variable3 = Math.Round(enunciado.Variable3, 2);
                        }
                    }
                    else {
                        if (enunciado.Final3 > enunciado.Inicio3) {
                            enunciado.Variable3 = randy.Next((int)enunciado.Inicio3, (int)enunciado.Final3 + 1);
                        }
                        else if (enunciado.Final3 < enunciado.Inicio3) {
                            enunciado.Variable3 = randy.Next((int)enunciado.Final3, (int)enunciado.Inicio3 + 1);
                        }
                    }
                    if (enunciado.Decimal4) {
                        if (enunciado.Final4 > enunciado.Inicio4) {
                            double extra = randy.NextDouble();
                            enunciado.Variable4 = enunciado.Inicio4 + (enunciado.Final4 - enunciado.Inicio4) * extra;
                            enunciado.Variable4 = Math.Round(enunciado.Variable4, 2);
                        }
                        else if (enunciado.Final4 < enunciado.Inicio4) {
                            double extra = randy.NextDouble();
                            enunciado.Variable4 = enunciado.Inicio4 + (enunciado.Inicio4 - enunciado.Final4) * extra;
                            enunciado.Variable4 = Math.Round(enunciado.Variable4, 2);
                        }
                    }
                    else {
                        if (enunciado.Final4 > enunciado.Inicio4) {
                            enunciado.Variable4 = randy.Next((int)enunciado.Inicio4, (int)enunciado.Final4 + 1);
                        }
                        else if (enunciado.Final4 < enunciado.Inicio4) {
                            enunciado.Variable4 = randy.Next((int)enunciado.Final4, (int)enunciado.Inicio4 + 1);
                        }
                    }
                     enunciado.Enunciado = original[indice];
        enunciado.Respuesta = CalcularRespuesta(enunciado);
        reemplazarVariables(enunciado);

        // Actualizar el enunciado en la lista 'elegidos'
        elegidos[indice] = enunciado;

               }
        }
        public EnunciadoBase reemplazarVariables(EnunciadoBase enunciado) {
            enunciado.Enunciado = enunciado.Enunciado.Replace("{v1}", enunciado.Variable1.ToString());
            enunciado.Enunciado = enunciado.Enunciado.Replace("{v2}", enunciado.Variable2.ToString());
            enunciado.Enunciado = enunciado.Enunciado.Replace("{v3}", enunciado.Variable3.ToString());
            enunciado.Enunciado = enunciado.Enunciado.Replace("{v4}", enunciado.Variable4.ToString());
            return enunciado;
        }
        public double CalcularRespuesta(EnunciadoBase enunciado) {
            // Reemplazar las variables en la f�rmula por sus valores
            string formulaEvaluable = enunciado.Formula;
            formulaEvaluable = formulaEvaluable.Replace("Var1", enunciado.Variable1.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var2", enunciado.Variable2.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var3", enunciado.Variable3.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var4", enunciado.Variable4.ToString());

            try {
                object result = new DataTable().Compute(formulaEvaluable, null);
                Console.WriteLine($"El resultado de la operaci�n {formulaEvaluable} es: {result}");
                return Convert.ToDouble(result);
            }
            catch (Exception ex) {
                return -1;
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            labels = [LabelP1, LabelP2, LabelP3, LabelP4, LabelP5, labelP6, labelP7, labelP8, labelP9, labelP10];
            resueltos = [problema1R, problema2R, problema3R, problema4R, problema5R, problema6R, problema7R, problema8R, problema9R, problema10R];
            botones = [botonP1, botonP2, botonP3, botonP4, botonP5, botonP6, botonP7, botonP8, botonP9, botonP10, button1];
            fallados = [problema1F, problema2F, problema3F, problema4F, problema5F
            , problema6F, problema7F, problema8F, problema9F, problema10F];

            labelVidas.Text = vidas.ToString();
            LabelResueltos.Text = correctas.ToString();
            dificultad(3);
            iniciarLayout();
        }
        private void cambiarVariables_Click(object sender, EventArgs e) {
            for (int i = 0; i < 10; i++) {
                modificarVariables(i, elegidos);
            }
            MessageBox.Show("Enunciados modificados");
        }
        private void botonOpciones_Click(object sender, EventArgs e) {
            List<int> numeros = GenerarNumerosAleatorios(enunciados.Count-1);
            MessageBox.Show($"{numeros[0]}");
            Opciones o = new Opciones(this);
            o.Show();
        }

        public void dificultad(int d) {
            dif = d;
            button1.Hide();
            int i = 0;
            for (int j = 0; j < 10; j++) {
                labels[j].Hide();
                botones[j].Hide();
            }

            if (dif == 0) {
                for (i = 0; i < 5; i++) {
                    labels[i].Show();
                    botones[i].Show();
                }
            }
            else if (dif == 1) {
                for (i = 0; i < 10; i++) {
                    labels[i].Show();
                    botones[i].Show();
                }
            }
            else if (dif == 2) {
                for (int j = 0; j < 10; j++) {
                    labels[j].Hide();
                    botones[j].Hide();
                }
                button1.Show();
            }
            else {
                for (int j = 0; j < 10; j++) {
                    labels[j].Hide();
                    botones[j].Hide();
                }
                button1.Hide();
            }
        }

        private void botonP1_Click(object sender, EventArgs e) {
            if (problema1R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[0], respuestas[0], 0, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP2_Click(object sender, EventArgs e) {
            if (problema2R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[1], respuestas[1], 1, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP3_Click(object sender, EventArgs e) {
            if (problema3R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[2], respuestas[2], 2, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP4_Click(object sender, EventArgs e) {
            if (problema4R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[3], respuestas[3], 3, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP5_Click(object sender, EventArgs e) {
            if (problema5R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[4], respuestas[4], 4, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP6_Click(object sender, EventArgs e) {
            if (problema6R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[5], respuestas[5], 5, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP7_Click(object sender, EventArgs e) {
            if (problema7R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[6], respuestas[6], 6, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP8_Click(object sender, EventArgs e) {
            if (problema8R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[7], respuestas[7], 7, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP9_Click(object sender, EventArgs e) {
            if (problema9R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[8], respuestas[8], 8, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }

        private void botonP10_Click(object sender, EventArgs e) {
            if (problema10R == false) {
                Problema_1 problema1Form = new Problema_1(problemas[9], respuestas[9], 9, vidas, correctas);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }
    }
}
