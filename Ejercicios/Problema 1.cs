using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Problema_1 : Form
    {
        EnunciadoBase enu;
        public Form1 FormPrincipal { get; set; }
        string en;
        double r;
        int i;
        int v;
        int c;
        public Problema_1(string enunciado, double respuesta, int indice, int vidas, int correctas)
        {
            enu = new EnunciadoBase();
            en = enunciado;
            r = respuesta;
            i = indice;
            v = vidas;
            c = correctas;
            InitializeComponent();
        }
  
        private void Problema_1_Load(object sender, EventArgs e)
        {
            Enunciado1.Text = en;
        }

        private void botonP1_Click(object sender, EventArgs e)
        {
            if (enu.Decimal1 || enu.Decimal2 || enu.Decimal3 || enu.Decimal4) {
                double diferencia = Math.Abs(r - FormPrincipal.respuestas[i]);
                if (diferencia <= 0.2) {
                    MessageBox.Show("¡Respuesta correcta!");
                    FormPrincipal.resueltos[i] = true; // Modificar el booleano del formulario principal
                    FormPrincipal.labels[i].Text = "¡OK!";
                    FormPrincipal.labels[i].ForeColor = Color.Green;
                    c++;
                    FormPrincipal.actualizarCorrectas(c);
                    this.Close();

                }
                else {
                    MessageBox.Show("Error, intente nuevamente.");
                    v--;
                    FormPrincipal.actualizarVidas(v);
                    modificarVariables(enu);
                    this.Close();
                }
            }
            else {
                if (r == FormPrincipal.respuestas[i]) {
                    MessageBox.Show("¡Respuesta correcta!");
                    FormPrincipal.resueltos[i] = true; // Modificar el booleano del formulario principal
                    FormPrincipal.labels[i].Text = "¡OK!";
                    FormPrincipal.labels[i].ForeColor = Color.Green;
                    c++;
                    FormPrincipal.actualizarCorrectas(c);
                    this.Close();

                }
                else {
                    MessageBox.Show("Error, intente nuevamente.");
                    v--;
                    FormPrincipal.actualizarVidas(v);
                    modificarVariables(enu);
                    this.Close();
                }
            }
        }

        public void modificarVariables(EnunciadoBase enunciado) {
            int i = 0;
            if (enunciado.Avanzado == true) {
                enunciado.Enunciado = en;
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
                enunciado.Enunciado = en;
                enunciado.Respuesta = CalcularRespuesta(enunciado);
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v1}", enunciado.Variable1.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v2}", enunciado.Variable2.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v3}", enunciado.Variable3.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v4}", enunciado.Variable4.ToString());
            }
            en = (enunciado.Enunciado);
            r = (enunciado.Respuesta);
            i++;
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