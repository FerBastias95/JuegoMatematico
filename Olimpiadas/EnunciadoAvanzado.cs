using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpiadas {
    public partial class EnunciadoAvanzado : Form {
        BDD datosAvanzado;
        EnunciadoBase avanzado;
        Calculator calculator;
        AlterarBDD alterarBDD;
        int caretIndex;
        string newText;
        string Enunciado;
        string Operacion;
        bool resultOK = false;
        public EnunciadoAvanzado(BDD datos, EnunciadoBase enunciado, AlterarBDD alterarBDD) {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            datosAvanzado = datos;
            avanzado = enunciado;
            this.alterarBDD = alterarBDD;
            InitializeComponent();
            ActiveControl = tbInput;
            calculator = new Calculator();
            this.alterarBDD = alterarBDD;
        }

        private void on_click_number(object sender, EventArgs e) {
            Button b = (Button)sender;
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + b.Text + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + b.Text.Length;
            tbInput.SelectionLength = 0;
        }
        private void on_click_operand(object sender, EventArgs e) {
            Button b = (Button)sender;
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + b.Text + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 1;
            tbInput.SelectionLength = 0;
        }
        private void on_click_function(object sender, EventArgs e) {
            Button b = (Button)sender;
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + b.Text + '(' + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 4;
            tbInput.SelectionLength = 0;
        }
        private void on_click_inverse_function(object sender, EventArgs e) {
            Button b = (Button)sender;
            string func = b.Text.Substring(0, 3);
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + "arc" + func + "(" + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 7;
            tbInput.SelectionLength = 0;
        }
        private void on_click_backspace(object sender, EventArgs e) {
            if (tbInput.SelectionStart > 0) {
                int previousCaretIndex = tbInput.SelectionStart;
                tbInput.Text = tbInput.Text.Remove(previousCaretIndex - 1, 1);
                tbInput.SelectionStart = previousCaretIndex - 1;
                tbInput.SelectionLength = 0;
            }
        }
        private void on_click_log(object sender, EventArgs e) {
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + "log[10](" + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 8;
            tbInput.SelectionLength = 0;
        }
        private void on_click_root(object sender, EventArgs e) {
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + "√[2](" + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 5;
            tbInput.SelectionLength = 0;
        }
        private void on_click_factorial(object sender, EventArgs e) {
            Button b = (Button)sender;
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + "!" + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 1;
            tbInput.SelectionLength = 0;
        }
        private void on_click_equal(object sender, EventArgs e) {
            getResult();
        }

        private void on_click_ans(object sender, EventArgs e) {
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + tbResult.Text + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + tbResult.Text.Length;
            tbInput.SelectionLength = 0;
        }
        private void on_click_clear(object sender, EventArgs e) {
            tbInput.Clear();
            ActiveControl = tbInput;
        }
        private void keyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = e.SuppressKeyPress = true; // disable the beep sound 
                getResult();
            }
        }
        private void tbResult_KeyPress(object sender, KeyPressEventArgs e) {
            // preventing user from editing the result text box
            if (e.KeyChar != 'c' - 96) // except: CTRL + C (copy result)
            {
                e.Handled = true;
            }
        }
        private void getResult() {
            string input = tbInput.Text;
            bool numeroOK = false;
            string result = input;
            result = result.Replace("Var1", avanzado.Variable1.ToString());
            result = result.Replace("Var2", avanzado.Variable2.ToString());
            result = result.Replace("Var3", avanzado.Variable3.ToString());
            result = result.Replace("Var4", avanzado.Variable4.ToString());
            result = result.Replace("π", "3,1415926535897932384626433832795");
            result = calculator.calculate(result, out Color color);

            int categoriaIndex = categoria.SelectedIndex;

            // Validar la respuesta según la categoría seleccionada
            switch (categoriaIndex) {
                case 0:
                    // No hay condiciones adicionales, la respuesta siempre es válida
                    numeroOK = true;
                    break;
                case 1:
                    // Verificar si la respuesta es mayor que el valor del curso
                    numeroOK = IsGreaterThanCurso(result);
                    break;
                case 2:
                    // Verificar si la respuesta es menor que el valor del curso
                    numeroOK = IsLessThanCurso(result);
                    break;
                case 3:
                    // Verificar si la respuesta es un número entero
                    numeroOK = IsInteger(result);
                    break;
                default:
                    // En caso de una categoría no válida, la respuesta se considera no válida
                    break;
            }

            if (!numeroOK) {
                // La respuesta no es válida, llama a GenerarVariables() y detén el proceso
                generarVariables();
                getResult();
                return;
            }

            // La respuesta es válida, continúa con el proceso normal de getResult()

            tbResult.ForeColor = color;
            tbResult.Text = result;
        }

        private bool IsGreaterThanCurso(string respuesta) {
            double respuestaValue = Convert.ToDouble(respuesta);
            double cursoValue = Convert.ToDouble(curso.Text);
            return respuestaValue > cursoValue;
        }

        // Función para verificar si la respuesta es menor que el valor del curso
        private bool IsLessThanCurso(string respuesta) {
            double respuestaValue = Convert.ToDouble(respuesta);
            double cursoValue = Convert.ToDouble(curso);
            return respuestaValue < cursoValue;
        }

        // Función para verificar si la respuesta es un número entero
        private bool IsInteger(string respuesta) {
            return double.TryParse(respuesta, out double result) && result == Math.Floor(result);
        }

        private void botonRandom_Click(object sender, EventArgs e) {
            generarVariables();
        }
        private void generarVariables() {
            Random randy = new Random();
            bool b1, b2, b3, b4, b5, b6, b7, b8;
            int t1, t2, t3, t4, t5, t6, t7, t8;
            b1 = int.TryParse(var1i.Text, out t1);
            b2 = int.TryParse(var1f.Text, out t2);
            b3 = int.TryParse(var2i.Text, out t3);
            b4 = int.TryParse(var2f.Text, out t4);
            b5 = int.TryParse(var3i.Text, out t5);
            b6 = int.TryParse(var3f.Text, out t6);
            b7 = int.TryParse(var4i.Text, out t7);
            b8 = int.TryParse(var4f.Text, out t8);

            avanzado.Avanzado = true;
            if (checkBox1.Checked) {
                if (b1) {
                    avanzado.Variable1 = double.Parse(var1i.Text);
                    avanzado.Inicio1 = double.Parse(var1i.Text);
                    avanzado.Decimal1 = true;

                    if (b2) {
                        avanzado.Final1 = double.Parse(var1f.Text);
                        if (avanzado.Final1 > avanzado.Inicio1) {
                            double extra = randy.NextDouble();
                            avanzado.Variable1 = avanzado.Inicio1 + (avanzado.Final1 - avanzado.Inicio1) * extra;
                            avanzado.Variable1 = Math.Round(avanzado.Variable1, 2);
                        }
                        else if (avanzado.Final1 < avanzado.Inicio1) {
                            double extra = randy.NextDouble();
                            avanzado.Variable1 = avanzado.Inicio1 + (avanzado.Inicio1 - avanzado.Final1) * extra;
                            avanzado.Variable1 = Math.Round(avanzado.Variable1, 2);
                        }
                    }
                }
            }
            else {
                if (b1) {
                    avanzado.Variable1 = int.Parse(var1i.Text);
                    avanzado.Inicio1 = int.Parse(var1i.Text);
                    avanzado.Decimal1 = false;

                    if (b2) {
                        avanzado.Final1 = int.Parse(var1f.Text);
                        if (avanzado.Final1 > avanzado.Inicio1) {
                            avanzado.Variable1 = randy.Next((int)avanzado.Inicio1, (int)avanzado.Final1 + 1);
                        }
                        else if (avanzado.Final1 < avanzado.Inicio1) {
                            avanzado.Variable1 = randy.Next((int)avanzado.Final1, (int)avanzado.Inicio1 + 1);
                        }
                    }
                }
            }

            if (checkBox2.Checked) {
                if (b1) {
                    avanzado.Variable2 = double.Parse(var2i.Text);
                    avanzado.Inicio2 = double.Parse(var2i.Text);
                    avanzado.Decimal2 = true;

                    if (b2) {
                        avanzado.Final2 = double.Parse(var2f.Text);
                        if (avanzado.Final2 > avanzado.Inicio2) {
                            double extra = randy.NextDouble();
                            avanzado.Variable2 = avanzado.Inicio2 + (avanzado.Final2 - avanzado.Inicio2) * extra;
                            avanzado.Variable2 = Math.Round(avanzado.Variable2, 2);
                        }
                        else if (avanzado.Final2 < avanzado.Inicio2) {
                            double extra = randy.NextDouble();
                            avanzado.Variable2 = avanzado.Inicio2 + (avanzado.Inicio2 - avanzado.Final2) * extra;
                            avanzado.Variable2 = Math.Round(avanzado.Variable2, 2);
                        }
                    }
                }
            }
            else {
                if (b3) {
                    avanzado.Decimal2 = false;
                    avanzado.Variable2 = int.Parse(var2i.Text);
                    avanzado.Inicio2 = int.Parse(var2i.Text);
                    if (b4) {
                        avanzado.Final2 = int.Parse(var2f.Text);
                        if (avanzado.Final2 > avanzado.Inicio2) {
                            avanzado.Variable2 = randy.Next((int)avanzado.Inicio2, (int)avanzado.Final2 + 1);
                        }
                        else if (avanzado.Final2 < avanzado.Inicio2) {
                            avanzado.Variable2 = randy.Next((int)avanzado.Final2, (int)avanzado.Inicio2 + 1);
                        }
                    }
                }
            }

            if (checkBox3.Checked) {
                if (b1) {
                    avanzado.Variable3 = double.Parse(var3i.Text);
                    avanzado.Inicio3 = double.Parse(var3i.Text);
                    avanzado.Decimal3 = true;

                    if (b2) {
                        avanzado.Final3 = double.Parse(var3f.Text);
                        if (avanzado.Final3 > avanzado.Inicio3) {
                            double extra = randy.NextDouble();
                            avanzado.Variable3 = avanzado.Inicio3 + (avanzado.Final3 - avanzado.Inicio3) * extra;
                            avanzado.Variable3 = Math.Round(avanzado.Variable3, 2);
                        }
                        else if (avanzado.Final3 < avanzado.Inicio3) {
                            double extra = randy.NextDouble();
                            avanzado.Variable3 = avanzado.Inicio3 + (avanzado.Inicio3 - avanzado.Final3) * extra;
                            avanzado.Variable3 = Math.Round(avanzado.Variable3, 2);
                        }
                    }
                }
            }
            else {
                if (b5) {
                    avanzado.Variable3 = int.Parse(var3i.Text);
                    avanzado.Inicio3 = int.Parse(var3i.Text);
                    avanzado.Decimal3 = false;

                    if (b6) {
                        avanzado.Final3 = int.Parse(var3f.Text);
                        if (avanzado.Final3 > avanzado.Inicio3) {
                            avanzado.Variable3 = randy.Next((int)avanzado.Inicio3, (int)avanzado.Final3 + 1);
                        }
                        else if (avanzado.Final3 < avanzado.Inicio3) {
                            avanzado.Variable3 = randy.Next((int)avanzado.Final3, (int)avanzado.Inicio3 + 1);
                        }
                    }
                }
            }

            if (checkBox4.Checked) {
                if (b1) {
                    avanzado.Variable4 = double.Parse(var4i.Text);
                    avanzado.Inicio4 = double.Parse(var4i.Text);
                    avanzado.Decimal4 = true;
                    if (b2) {
                        avanzado.Final4 = double.Parse(var4f.Text);
                        if (avanzado.Final4 > avanzado.Inicio4) {
                            double extra = randy.NextDouble();
                            avanzado.Variable4 = avanzado.Inicio4 + (avanzado.Final4 - avanzado.Inicio4) * extra;
                            avanzado.Variable4 = Math.Round(avanzado.Variable4, 2);
                        }
                        else if (avanzado.Final4 < avanzado.Inicio4) {
                            double extra = randy.NextDouble();
                            avanzado.Variable4 = avanzado.Inicio4 + (avanzado.Inicio4 - avanzado.Final4) * extra;
                            avanzado.Variable4 = Math.Round(avanzado.Variable4, 2);
                        }
                    }
                }
            }
            else {
                if (b7) {
                    avanzado.Variable4 = int.Parse(var4i.Text);
                    avanzado.Inicio4 = int.Parse(var4i.Text);
                    avanzado.Decimal4 = false;
                    if (b8) {
                        avanzado.Final4 = int.Parse(var4f.Text);
                        if (avanzado.Final4 > avanzado.Inicio4) {
                            avanzado.Variable4 = randy.Next((int)avanzado.Inicio4, (int)avanzado.Final4 + 1);
                        }
                        else if (avanzado.Final4 < avanzado.Inicio4) {
                            avanzado.Variable4 = randy.Next((int)avanzado.Final4, (int)avanzado.Inicio4 + 1);
                        }
                    }
                }
            }
            labelv1.Text = avanzado.Variable1.ToString();
            labelv2.Text = avanzado.Variable2.ToString();
            labelv3.Text = avanzado.Variable3.ToString();
            labelv4.Text = avanzado.Variable4.ToString();
        }
        private void botonGuardar_Click(object sender, EventArgs e) {
            avanzado.Enunciado = avanzadoEnunciado.Text;
            avanzado.Formula = tbInput.Text;
            Enunciado = avanzadoEnunciado.Text;
            Operacion = tbInput.Text;
            getResult();
            Enunciado = Enunciado.Replace("{v1}", avanzado.Variable1.ToString());
            Enunciado = Enunciado.Replace("{v2}", avanzado.Variable2.ToString());
            Enunciado = Enunciado.Replace("{v3}", avanzado.Variable3.ToString());
            Enunciado = Enunciado.Replace("{v4}", avanzado.Variable4.ToString());
            Operacion = Operacion.Replace("{v1}", avanzado.Variable1.ToString());
            Operacion = Operacion.Replace("{v2}", avanzado.Variable2.ToString());
            Operacion = Operacion.Replace("{v3}", avanzado.Variable3.ToString());
            Operacion = Operacion.Replace("{v4}", avanzado.Variable4.ToString());
            bool respuestaValida = double.TryParse(tbResult.Text, out double test);
            if (respuestaValida) {
                alterarBDD.ActualizarAvanzado(avanzadoEnunciado.Text, tbInput.Text);
                avanzado.Avanzado = true;
                avanzado.Respuesta = double.Parse(tbResult.Text);
                MessageBox.Show($"Enunciado:\n" +
                    $"{avanzado.Enunciado}\n" +
                    $"Su versión con números es:\n{Enunciado}\n" +
                    $"El resultado es: {avanzado.Respuesta}");
                alterarBDD.HabilitarFunciones();
                datosAvanzado.ActualizarEnunciado(avanzado);
                this.Close();
            }
            else {
                MessageBox.Show("Error en la respuesta. Asegurese que su fórmula sea válida.\n" +
                    "Recuerde presionar el botón = para obtener el resultado también, " +
                    "y verifique que sea correcto.");
            }
        }
        private void botonCerrar_Click(object sender, EventArgs e) {
            avanzado.Avanzado = false;
            alterarBDD.ActualizarAvanzado("", "0");
            alterarBDD.HabilitarFunciones();
            MessageBox.Show("El enunciado ahora es regular.");
            this.Close();
        }
        private void MainView_Load(object sender, EventArgs e) {
            avanzadoEnunciado.Text = avanzado.Enunciado;
            tbInput.Text = avanzado.Formula;
            categoria.SelectedIndex = avanzado.Categoria;
            curso.Text = avanzado.Curso.ToString();
            tbResult.Text = avanzado.Respuesta.ToString();
            labelv1.Text = avanzado.Variable1.ToString();
            labelv2.Text = avanzado.Variable2.ToString();
            labelv3.Text = avanzado.Variable3.ToString();
            labelv4.Text = avanzado.Variable4.ToString();
            var1i.Text = avanzado.Inicio1.ToString();
            var1f.Text = avanzado.Final1.ToString();
            var2i.Text = avanzado.Inicio2.ToString();
            var2f.Text = avanzado.Final2.ToString();
            var3i.Text = avanzado.Inicio3.ToString();
            var3f.Text = avanzado.Final3.ToString();
            var4i.Text = avanzado.Inicio4.ToString();
            var4f.Text = avanzado.Final4.ToString();
        }
        private void insertVar1_Click(object sender, EventArgs e) {
            Button b = (Button)sender;
            string insertar = "{v1}";
            caretIndex = avanzadoEnunciado.SelectionStart;
            newText = avanzadoEnunciado.Text.Substring(0, caretIndex) + insertar + avanzadoEnunciado.Text.Substring(caretIndex, avanzadoEnunciado.Text.Length - caretIndex);
            avanzadoEnunciado.Text = newText;
            ActiveControl = tbInput;
            avanzadoEnunciado.SelectionStart = caretIndex + insertar.Length;
            avanzadoEnunciado.SelectionLength = 0;
        }
        private void insertVar2_Click(object sender, EventArgs e) {
            Button b = (Button)sender;
            string insertar = "{v2}";
            caretIndex = avanzadoEnunciado.SelectionStart;
            newText = avanzadoEnunciado.Text.Substring(0, caretIndex) + insertar + avanzadoEnunciado.Text.Substring(caretIndex, avanzadoEnunciado.Text.Length - caretIndex);
            avanzadoEnunciado.Text = newText;
            ActiveControl = tbInput;
            avanzadoEnunciado.SelectionStart = caretIndex + insertar.Length;
            avanzadoEnunciado.SelectionLength = 0;
        }

        private void insertVar3_Click(object sender, EventArgs e) {
            Button b = (Button)sender;
            string insertar = "{v3}";
            caretIndex = avanzadoEnunciado.SelectionStart;
            newText = avanzadoEnunciado.Text.Substring(0, caretIndex) + insertar + avanzadoEnunciado.Text.Substring(caretIndex, avanzadoEnunciado.Text.Length - caretIndex);
            avanzadoEnunciado.Text = newText;
            ActiveControl = tbInput;
            avanzadoEnunciado.SelectionStart = caretIndex + insertar.Length;
            avanzadoEnunciado.SelectionLength = 0;
        }

        private void insertVar4_Click(object sender, EventArgs e) {
            Button b = (Button)sender;
            string insertar = "{v4}";
            caretIndex = avanzadoEnunciado.SelectionStart;
            newText = avanzadoEnunciado.Text.Substring(0, caretIndex) + insertar + avanzadoEnunciado.Text.Substring(caretIndex, avanzadoEnunciado.Text.Length - caretIndex);
            avanzadoEnunciado.Text = newText;
            ActiveControl = tbInput;
            avanzadoEnunciado.SelectionStart = caretIndex + insertar.Length;
            avanzadoEnunciado.SelectionLength = 0;
        }

        private void categoria_SelectedIndexChanged(object sender, EventArgs e) {
            avanzado.Categoria = categoria.SelectedIndex;
            if (categoria.SelectedIndex == 1 || categoria.SelectedIndex == 2) {
                curso.Enabled = true;
            }
            else {
                curso.Enabled = false;
            }
        }
    }
}