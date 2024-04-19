﻿using System;
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
    public partial class MainView : Form
    {
        EnunciadoBase avanzado;
        BDD datosAvanzado;
        Calculator calculator;
        int caretIndex;
        string newText;
        string EnunciadoAvanzado;
        string Operacion;
        public MainView(BDD datos, EnunciadoBase enunciado)
        {
            datosAvanzado = datos;
            avanzado = enunciado;
            InitializeComponent();
            ActiveControl = tbInput;
            calculator = new Calculator();
        }

        private void on_click_number(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + b.Text + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + b.Text.Length;
            tbInput.SelectionLength = 0;
        }

        private void on_click_operand(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + b.Text + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 1;
            tbInput.SelectionLength = 0;
        }

        private void on_click_function(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + b.Text + '(' + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 4;
            tbInput.SelectionLength = 0;
        }

        private void on_click_inverse_function(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string func = b.Text.Substring(0, 3);
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + "arc" + func + "(" + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 7;
            tbInput.SelectionLength = 0;
        }
        private void on_click_backspace(object sender, EventArgs e)
        {
            if (tbInput.SelectionStart > 0)
            {
                int previousCaretIndex = tbInput.SelectionStart;
                tbInput.Text = tbInput.Text.Remove(previousCaretIndex - 1, 1);
                tbInput.SelectionStart = previousCaretIndex - 1;
                tbInput.SelectionLength = 0;
            }
        }
        private void on_click_log(object sender, EventArgs e)
        {
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + "log[10](" + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 8;
            tbInput.SelectionLength = 0;
        }

        private void on_click_root(object sender, EventArgs e)
        {
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + "√[2](" + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 5;
            tbInput.SelectionLength = 0;
        }

        private void on_click_factorial(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + "!" + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + 1;
            tbInput.SelectionLength = 0;
        }

        private void on_click_equal(object sender, EventArgs e)
        {
            getResult();
        }

        private void on_click_ans(object sender, EventArgs e)
        {
            caretIndex = tbInput.SelectionStart;
            newText = tbInput.Text.Substring(0, caretIndex) + tbResult.Text + tbInput.Text.Substring(caretIndex, tbInput.Text.Length - caretIndex);
            tbInput.Text = newText;
            ActiveControl = tbInput;
            tbInput.SelectionStart = caretIndex + tbResult.Text.Length;
            tbInput.SelectionLength = 0;
        }

        private void on_click_clear(object sender, EventArgs e)
        {
            tbInput.Clear();
            ActiveControl = tbInput;
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true; // disable the beep sound 
                getResult();
            }
        }

        private void tbResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            // preventing user from editing the result text box
            if (e.KeyChar != 'c' - 96) // except: CTRL + C (copy result)
            {
                e.Handled = true;
            }
        }

        private void getResult()
        {
            string result = tbInput.Text;

            result = result.Replace("Var1", avanzado.Variable1.ToString());
            result = result.Replace("Var2", avanzado.Variable2.ToString());
            result = result.Replace("Var3", avanzado.Variable3.ToString());
            result = result.Replace("Var4", avanzado.Variable4.ToString());
            result = calculator.calculate(result, out Color color);
            tbResult.ForeColor = color;
            tbResult.Text = result;
        }

        private void botonRandom_Click(object sender, EventArgs e)
        {
            generarVariables();
        }
        private void generarVariables()
        {
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
            if (b1)
            {
                avanzado.Variable1 = int.Parse(var1i.Text);
                avanzado.Inicio1 = int.Parse(var1i.Text);
                if (b2)
                {
                    avanzado.Final1 = int.Parse(var1f.Text);
                    if (avanzado.Final1 > avanzado.Inicio1)
                    {
                        avanzado.Variable1 = randy.Next(avanzado.Inicio1, avanzado.Final1 + 1);
                    }
                }
            }

            if (b3)
            {
                avanzado.Variable2 = int.Parse(var2i.Text);
                avanzado.Inicio2 = int.Parse(var2i.Text);
                if (b4)
                {
                    avanzado.Final2 = int.Parse(var2f.Text);
                    if (avanzado.Final2 > avanzado.Inicio2)
                    {
                        avanzado.Variable2 = randy.Next(avanzado.Inicio2, avanzado.Final2 + 1);
                    }
                }
            }

            if (b5)
            {
                avanzado.Variable3 = int.Parse(var3i.Text);
                avanzado.Inicio3 = int.Parse(var3i.Text);
                if (b6)
                {
                    avanzado.Final3 = int.Parse(var3f.Text);
                    if (avanzado.Final3 > avanzado.Inicio3)
                    {
                        avanzado.Variable3 = randy.Next(avanzado.Inicio3, avanzado.Final3 + 1);
                    }
                }
            }

            if (b7)
            {
                avanzado.Variable4 = int.Parse(var4i.Text);
                avanzado.Inicio4 = int.Parse(var4i.Text);
                if (b8)
                {
                    avanzado.Final4 = int.Parse(var4f.Text);
                    if (avanzado.Final3 > avanzado.Inicio3)
                    {
                        avanzado.Variable4 = randy.Next(avanzado.Inicio4, avanzado.Final4 + 1);
                    }
                }
            }

            MessageBox.Show($"Sus variables son {avanzado.Variable1}, {avanzado.Variable2}, {avanzado.Variable3} y {avanzado.Variable4}.");
        }
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            avanzado.Enunciado = avanzadoEnunciado.Text;
            EnunciadoAvanzado = avanzadoEnunciado.Text;
            Operacion = tbInput.Text;
            EnunciadoAvanzado = EnunciadoAvanzado.Replace("{v1}", avanzado.Variable1.ToString());
            EnunciadoAvanzado = EnunciadoAvanzado.Replace("{v2}", avanzado.Variable2.ToString());
            EnunciadoAvanzado = EnunciadoAvanzado.Replace("{v3}", avanzado.Variable3.ToString());
            EnunciadoAvanzado = EnunciadoAvanzado.Replace("{v4}", avanzado.Variable4.ToString());
            Operacion = Operacion.Replace("{v1}", avanzado.Variable1.ToString());
            Operacion = Operacion.Replace("{v2}", avanzado.Variable2.ToString());
            Operacion = Operacion.Replace("{v3}", avanzado.Variable3.ToString());
            Operacion = Operacion.Replace("{v4}", avanzado.Variable4.ToString());
            bool respuestaValida = double.TryParse(tbResult.Text, out double test);
            if (respuestaValida)
            {
                avanzado.Respuesta = double.Parse(tbResult.Text);
                MessageBox.Show($"Enunciado: {avanzado.Enunciado}\nSu versión con números es: {EnunciadoAvanzado}\nEl resultado es: {avanzado.Respuesta}");
                datosAvanzado.ActualizarEnunciado(avanzado);
            }
            else
            {
                MessageBox.Show("Error en la respuesta. Asegurese que su fórmula sea válida.");
            }
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            avanzadoEnunciado.Text = avanzado.Enunciado;
            var1i.Text = avanzado.Inicio1.ToString();
            var1f.Text = avanzado.Final1.ToString();
            var2i.Text = avanzado.Inicio2.ToString();
            var2f.Text = avanzado.Final2.ToString();
            var3i.Text = avanzado.Inicio3.ToString();
            var3f.Text = avanzado.Final3.ToString();
            var4i.Text = avanzado.Inicio4.ToString();
            var4f.Text = avanzado.Final4.ToString();
        }
    }
    // ʃ
}