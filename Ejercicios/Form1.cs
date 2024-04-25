using System.Data;
using NCalc;

namespace Ejercicios {
    public partial class Form1 : Form {
        public int vidas = 0;
        public int correctas = 0;
        private int botonesActivos = 0;
        public bool problema1R, problema2R, problema3R, problema4R, problema5R,
            problema6R, problema7R, problema8R, problema9R, problema10R,
            problema1F, problema2F, problema3F, problema4F, problema5F;
        public List<EnunciadoBase> enunciados;
        public List<Label> labels;
        public List<bool> resueltos;
        public List<string> problemas;
        public List<string> original;
        public List<double> respuestas;
        string pathName = "";
        BDD ejercicios;
        public Form1() {
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
        private void iniciarLayout() {
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
            // Verificar si se seleccionó un archivo
            if (result == DialogResult.OK) {
                botonesActivos = 0;
                string archivoSeleccionado = openFileDialog.FileName;
                ejercicios = new BDD(archivoSeleccionado);
                enunciados = ejercicios.ObtenerTodosEnunciados();
                int i = 0;
                // Limpiar las listas de problemas y respuestas antes de llenarlas
                problemas = new List<string>();
                respuestas = new List<double>();
                original = new List<string>();
                cambiarVariables.Enabled = true;
                // Recorrer los enunciados obtenidos
                foreach (EnunciadoBase enunciado in enunciados) {
                    i++;
                    if (enunciado.Avanzado == true) {
                        original.Add(enunciado.Enunciado);
                        enunciado.Enunciado = enunciado.Enunciado.Replace("{v1}", enunciado.Variable1.ToString());
                        enunciado.Enunciado = enunciado.Enunciado.Replace("{v2}", enunciado.Variable2.ToString());
                        enunciado.Enunciado = enunciado.Enunciado.Replace("{v3}", enunciado.Variable3.ToString());
                        enunciado.Enunciado = enunciado.Enunciado.Replace("{v4}", enunciado.Variable4.ToString());
                    }
                    problemas.Add(enunciado.Enunciado);
                    respuestas.Add(enunciado.Respuesta);
                    switch (i) {
                        case 1:
                            botonP1.Enabled = true;
                            break;
                        case 2:
                            botonP2.Enabled = true;
                            break;
                        case 3:
                            botonP3.Enabled = true;
                            break;
                        case 4:
                            botonP4.Enabled = true;
                            break;
                        case 5:
                            botonP5.Enabled = true;
                            break;
                        case 6:
                            botonP6.Enabled = true;
                            break;
                        case 7:
                            botonP7.Enabled = true;
                            break;
                        case 8:
                            botonP8.Enabled = true;
                            break;
                        case 9:
                            botonP9.Enabled = true;
                            break;
                        case 10:
                            botonP10.Enabled = true;
                            break;
                        default:
                            break;
                    }
                    botonesActivos++;
                }

                // Mostrar el primer enunciado y su respuesta
                if (enunciados.Count > 0) {
                    MessageBox.Show($"{enunciados[0].Enunciado}, {enunciados[0].Respuesta}");
                }
                else {
                    MessageBox.Show("No se encontraron enunciados en el archivo seleccionado.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            labels = [LabelP1, LabelP2, LabelP3, LabelP4, LabelP5, labelP6, labelP7, labelP8, labelP9, labelP10];
            resueltos = [problema1R, problema2R, problema3R, problema4R, problema5R, problema6R, problema7R, problema8R, problema9R, problema10R];
            labelVidas.Text = vidas.ToString();
            LabelResueltos.Text = correctas.ToString();
            iniciarLayout();
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

        private void cambiarVariables_Click(object sender, EventArgs e) {
            for (int i = 0; i < enunciados.Count; i++) {
                modificarVariables(i);
            }
            MessageBox.Show("Enunciados modificados");
        }
        public void modificarVariables(int indice) {
            EnunciadoBase enunciado = enunciados[indice];
            if (enunciado.Avanzado == true) {
                enunciado.Enunciado = original[indice];
                Random randy = new Random();

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
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v1}", enunciado.Variable1.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v2}", enunciado.Variable2.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v3}", enunciado.Variable3.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v4}", enunciado.Variable4.ToString());
            }
            problemas[indice] = (enunciado.Enunciado);
            respuestas[indice] = (enunciado.Respuesta);

            enunciados[indice] = enunciado;
        }

        public double CalcularRespuesta(EnunciadoBase enunciado) {
            // Reemplazar las variables en la fórmula por sus valores
            string formulaEvaluable = enunciado.Formula;
            formulaEvaluable = formulaEvaluable.Replace("Var1", enunciado.Variable1.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var2", enunciado.Variable2.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var3", enunciado.Variable3.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var4", enunciado.Variable4.ToString());

            try {
                object result = new DataTable().Compute(formulaEvaluable, null);
                Console.WriteLine($"El resultado de la operación {formulaEvaluable} es: {result}");
                return Convert.ToDouble(result);
            }
            catch (Exception ex) {
                return -1;
            }
        }
    }
}
