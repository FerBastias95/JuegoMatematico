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
    public partial class EnunciadoAvanzado : Form
    {
        EnunciadoBase avanzado;
        BDD datosAvanzado;
        public EnunciadoAvanzado(BDD datos, EnunciadoBase enunciado)
        {
            datosAvanzado = datos;
            avanzado = enunciado;
            InitializeComponent();
        }

        private void ActAvanzado_Click(object sender, EventArgs e)
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
            }
            if (b2)
            {
                avanzado.Final1 = int.Parse(var1f.Text);
                if (avanzado.Final1 > avanzado.Inicio1)
                {
                    avanzado.Variable1 = randy.Next(avanzado.Inicio1, avanzado.Final1);
                }
            }

            if (b3)
            {
                avanzado.Variable2 = int.Parse(var2i.Text);
                avanzado.Inicio2 = int.Parse(var2i.Text);
            }
            if (b4)
            {
                avanzado.Final2 = int.Parse(var2f.Text);
                if (avanzado.Final2 > avanzado.Inicio2)
                {
                    avanzado.Variable2 = randy.Next(avanzado.Inicio2, avanzado.Final2);
                }
            }

            if (b5)
            {
                avanzado.Variable3 = int.Parse(var3i.Text);
                avanzado.Inicio3 = int.Parse(var3i.Text);
            }
            if (b6)
            {
                avanzado.Final3 = int.Parse(var3f.Text);
                if (avanzado.Final3 > avanzado.Inicio3)
                {
                    avanzado.Variable3 = randy.Next(avanzado.Inicio3, avanzado.Final3);
                }
            }

            if (b7)
            {
                avanzado.Variable4 = int.Parse(var4i.Text);
                avanzado.Inicio4 = int.Parse(var4i.Text);
            }
            if (b8)
            {
                avanzado.Final4 = int.Parse(var4f.Text);
                if (avanzado.Final3 > avanzado.Inicio3)
                {
                    avanzado.Variable4 = randy.Next(avanzado.Inicio4, avanzado.Final4);
                }
            }

            avanzado.Enunciado = avanzadoTexto.Text;
            double respuesta = 0;

            switch (operacion1.Text)
            {
                case "+":
                    respuesta += avanzado.Variable1;
                    break;
                case "-":
                    respuesta -= avanzado.Variable1;
                    break;
                case "Raíz Cuadrada":
                    respuesta = Math.Sqrt(avanzado.Variable1);
                    break;
                case "Raíz Cúbica":
                    respuesta = Math.Cbrt(avanzado.Variable1);
                    break;
                case "Log B2":
                    respuesta = Math.Log2(avanzado.Variable1);
                    break;
                case "Log B10":
                    respuesta = Math.Log10(avanzado.Variable1);
                    break;
                case "Log Natural":
                    respuesta = Math.Log(avanzado.Variable1);
                    break;
                default:
                    break;
            }

            switch (operacion2.Text)
            {
                case "+":
                    respuesta += avanzado.Variable2;
                    break;
                case "-":
                    respuesta -= avanzado.Variable2;
                    break;
                case "*":
                    respuesta *= avanzado.Variable2;
                    break;
                case "/":
                    respuesta /= avanzado.Variable2;
                    break;
                case "Elevado a":
                    respuesta = Math.Pow(respuesta, avanzado.Variable2);
                    break;
                case "Raíz Cuadrada":
                    respuesta += Math.Sqrt(avanzado.Variable2);
                    break;
                case "Raíz Cúbica":
                    respuesta += Math.Cbrt(avanzado.Variable2);
                    break;
                case "Log B2":
                    respuesta += Math.Log2(avanzado.Variable2);
                    break;
                case "Log B10":
                    respuesta += Math.Log10(avanzado.Variable2);
                    break;
                case "Log Natural":
                    respuesta += Math.Log(avanzado.Variable2);
                    break;
                default:
                    break;
            }

            switch (operacion3.Text)
            {
                case "+":
                    switch (variable3.Text)
                    {
                        case "Variable 1":
                            respuesta += avanzado.Variable1;
                            break;
                        case "Variable 2":
                            respuesta += avanzado.Variable2;
                            break;
                        case "Variable 3":
                            respuesta += avanzado.Variable3;
                            break;
                        case "Variable 4":
                            respuesta += avanzado.Variable4;
                            break;
                        default:
                            double test;
                            bool sepuede = double.TryParse(variable3.Text, out test);
                            if (sepuede)
                            {
                                respuesta += double.Parse(variable3.Text);
                            }
                            break;
                    }
                    break;
                case "-":
                    switch (variable3.Text)
                    {
                        case "Variable 1":
                            respuesta -= avanzado.Variable1;
                            break;
                        case "Variable 2":
                            respuesta -= avanzado.Variable2;
                            break;
                        case "Variable 3":
                            respuesta -= avanzado.Variable3;
                            break;
                        case "Variable 4":
                            respuesta -= avanzado.Variable4;
                            break;
                        default:
                            double test;
                            bool sepuede = double.TryParse(variable3.Text, out test);
                            if (sepuede)
                            {
                                respuesta -= double.Parse(variable3.Text);
                            }
                            break;
                    }
                    break;
                case "*":
                    switch (variable3.Text)
                    {
                        case "Variable 1":
                            respuesta *= avanzado.Variable1;
                            break;
                        case "Variable 2":
                            respuesta *= avanzado.Variable2;
                            break;
                        case "Variable 3":
                            respuesta *= avanzado.Variable3;
                            break;
                        case "Variable 4":
                            respuesta *= avanzado.Variable4;
                            break;
                        default:
                            double test;
                            bool sepuede = double.TryParse(variable3.Text, out test);
                            if (sepuede)
                            {
                                respuesta *= double.Parse(variable3.Text);
                            }
                            break;
                    }
                    break;
                case "/":
                    switch (variable3.Text)
                    {
                        case "Variable 1":
                            respuesta /= avanzado.Variable1;
                            break;
                        case "Variable 2":
                            respuesta /= avanzado.Variable2;
                            break;
                        case "Variable 3":
                            respuesta /= avanzado.Variable3;
                            break;
                        case "Variable 4":
                            respuesta /= avanzado.Variable4;
                            break;
                        default:
                            double test;
                            bool sepuede = double.TryParse(variable3.Text, out test);
                            if (sepuede)
                            {
                                respuesta /= double.Parse(variable3.Text);
                            }
                            break;
                    }
                    break;
                case "Elevado a":
                    switch (variable3.Text)
                    {
                        case "Variable 1":
                            respuesta = Math.Pow(respuesta, avanzado.Variable1); 
                            break;
                        case "Variable 2":
                            respuesta = Math.Pow(respuesta, avanzado.Variable2);
                            break;
                        case "Variable 3":
                            respuesta = Math.Pow(respuesta, avanzado.Variable3);
                            break;
                        case "Variable 4":
                            respuesta = Math.Pow(respuesta, avanzado.Variable4);
                            break;
                        default:
                            double test;
                            bool sepuede = double.TryParse(variable4.Text, out test);
                            if (sepuede)
                            {
                                respuesta /= double.Parse(variable4.Text);
                            }
                            break;
                    }
                    break;
                case "Raíz Cuadrada":
                    switch (variable3.Text)
                    {
                        case "Variable 1":
                            respuesta += Math.Sqrt(avanzado.Variable1);
                            break;
                        case "Variable 2":
                            respuesta += Math.Sqrt(avanzado.Variable2);
                            break;
                        case "Variable 3":
                            respuesta += Math.Sqrt(avanzado.Variable3);
                            break;
                        case "Variable 4":
                            respuesta += Math.Sqrt(avanzado.Variable4);
                            break;
                        default:
                            double test;
                            bool sepuede = double.TryParse(variable4.Text, out test);
                            if (sepuede)
                            {
                                respuesta += Math.Sqrt(avanzado.Variable3);
                            }
                            break;
                    }
                    break;
                case "Raíz Cúbica":
                    respuesta += Math.Cbrt(avanzado.Variable3);
                    break;
                case "Log B2":
                    respuesta += Math.Log2(avanzado.Variable3);
                    break;
                case "Log B10":
                    respuesta += Math.Log10(avanzado.Variable3);
                    break;
                case "Log Natural":
                    respuesta += Math.Log(avanzado.Variable3);
                    break;
                default:
                    break;
            }

            switch (operacion4.Text)
            {
                case "+":
                    respuesta += avanzado.Variable4;
                    break;
                case "-":
                    respuesta -= avanzado.Variable4;
                    break;
                case "*":
                    respuesta *= avanzado.Variable4;
                    break;
                case "/":
                    respuesta /= avanzado.Variable4;
                    break;
                case "Elevado a":
                    respuesta = Math.Pow(respuesta, avanzado.Variable4);
                    break;
                case "Raíz Cuadrada":
                    respuesta += Math.Sqrt(avanzado.Variable4);
                    break;
                case "Raíz Cúbica":
                    respuesta += Math.Cbrt(avanzado.Variable4);
                    break;
                case "Log B2":
                    respuesta += Math.Log2(avanzado.Variable4);
                    break;
                case "Log B10":
                    respuesta += Math.Log10(avanzado.Variable4);
                    break;
                case "Log Natural":
                    respuesta += Math.Log(avanzado.Variable4);
                    break;
                default:
                    break;
            }
            avanzado.Respuesta = respuesta;
            avanzado.Enunciado = avanzado.Enunciado.Replace("{v1}", avanzado.Variable1.ToString());
            avanzado.Enunciado = avanzado.Enunciado.Replace("{v2}", avanzado.Variable2.ToString());
            avanzado.Enunciado = avanzado.Enunciado.Replace("{v3}", avanzado.Variable3.ToString());
            avanzado.Enunciado = avanzado.Enunciado.Replace("{v4}", avanzado.Variable4.ToString());
            MessageBox.Show($"Enunciado: {avanzado.Enunciado}, y su resultado es: {avanzado.Respuesta}");
            datosAvanzado.ActualizarEnunciado(avanzado);
            this.Close();
        }

        private void operacion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operacion1.TabIndex != 0 && variable1.TabIndex != 0)
            {
                operacion2.Enabled = true;
                variable2.Enabled = true;
            }
            else
            {
                operacion2.Enabled = false;
                variable2.Enabled = false;
                operacion3.Enabled = false;
                variable3.Enabled = false;
                operacion4.Enabled = false;
                variable4.Enabled = false;
            }
        }

        private void variable1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operacion1.TabIndex != 0 && variable1.TabIndex != 0)
            {
                operacion2.Enabled = true;
                variable2.Enabled = true;
            }
            else
            {
                operacion2.Enabled = false;
                variable2.Enabled = false;
                operacion3.Enabled = false;
                variable3.Enabled = false;
                operacion4.Enabled = false;
                variable4.Enabled = false;
            }
        }

        private void operacion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operacion2.TabIndex != 0 && variable2.TabIndex != 0)
            {
                operacion3.Enabled = true;
                variable3.Enabled = true;
            }
            else
            {
                operacion3.Enabled = false;
                variable3.Enabled = false;
                operacion4.Enabled = false;
                variable4.Enabled = false;
            }
        }

        private void variable2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operacion2.TabIndex != 0 && variable2.TabIndex != 0)
            {
                operacion3.Enabled = true;
                variable3.Enabled = true;
            }
            else
            {
                operacion3.Enabled = false;
                variable3.Enabled = false;
                operacion4.Enabled = false;
                variable4.Enabled = false;
            }
        }

        private void operacion3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operacion2.TabIndex != 0 && variable2.TabIndex != 0)
            {
                operacion4.Enabled = true;
                variable4.Enabled = true;
            }
            else
            {
                operacion4.Enabled = false;
                variable4.Enabled = false;
            }
        }

        private void variable3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operacion2.TabIndex != 0 && variable2.TabIndex != 0)
            {
                operacion4.Enabled = true;
                variable4.Enabled = true;
            }
            else
            {
                operacion4.Enabled = false;
                variable4.Enabled = false;
            }
        }

        private void EnunciadoAvanzado_Load(object sender, EventArgs e)
        {
            avanzadoTexto.Text = avanzado.Enunciado;
            var1i.Text = avanzado.Inicio1.ToString();
            var2i.Text = avanzado.Inicio2.ToString();
            var3i.Text = avanzado.Inicio3.ToString();
            var4i.Text = avanzado.Inicio4.ToString();
            var1f.Text = avanzado.Final1.ToString();
            var2f.Text = avanzado.Final2.ToString();
            var3f.Text = avanzado.Final3.ToString();
            var4f.Text = avanzado.Final4.ToString();
        }

        private void cancelarCambios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

