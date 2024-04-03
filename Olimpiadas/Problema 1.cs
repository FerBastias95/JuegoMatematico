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
    public partial class Problema_1 : Form
    {
        Enunciado1 enu;
        public Form1 FormPrincipal { get; set; }
        string en;
        int r;
        int i;
        int v;
        int c;
        public Problema_1(string enunciado, int respuesta, int indice, int vidas, int correctas)
        {
            enu = new Enunciado1();
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
            switch (i)
            {
                case 1:
                    if (r.ToString() == RespuestaP1.Text)
                    {
                        MessageBox.Show("¡Respuesta correcta!");
                        FormPrincipal.problema1R = true; // Modificar el booleano del formulario principal
                        FormPrincipal.actualizarLayout();
                        c++;
                        FormPrincipal.actualizarCorrectas(c);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error, intente nuevamente.");
                        v--;
                        FormPrincipal.actualizarVidas(v);
                        FormPrincipal.problema1F = true;
                        this.Close();
                    }
                    break;
                case 2:
                    if (r.ToString() == RespuestaP1.Text)
                    {
                        MessageBox.Show("¡Respuesta correcta!");
                        FormPrincipal.problema2R = true; // Modificar el booleano del formulario principal
                        FormPrincipal.actualizarLayout();
                        c++;
                        FormPrincipal.actualizarCorrectas(c);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, intente nuevamente.");
                        v--;
                        FormPrincipal.actualizarVidas(v);
                        FormPrincipal.problema2F = true;
                        this.Close();
                    }
                    break;
                case 3:
                    if (r.ToString() == RespuestaP1.Text)
                    {
                        MessageBox.Show("¡Respuesta correcta!");
                        FormPrincipal.problema3R = true; // Modificar el booleano del formulario principal
                        FormPrincipal.actualizarLayout();
                        c++;
                        FormPrincipal.actualizarCorrectas(c);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, intente nuevamente.");
                        v--;
                        FormPrincipal.actualizarVidas(v); 
                        FormPrincipal.problema3F = true;
                        this.Close();
                    }
                    break;
                case 4:
                    if (r.ToString() == RespuestaP1.Text)
                    {
                        MessageBox.Show("¡Respuesta correcta!");
                        FormPrincipal.problema4R = true; // Modificar el booleano del formulario principal
                        FormPrincipal.actualizarLayout();
                        c++;
                        FormPrincipal.actualizarCorrectas(c);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, intente nuevamente.");
                        v--;
                        FormPrincipal.actualizarVidas(v);
                        FormPrincipal.problema4F = true;
                        this.Close();
                    }
                    break;
                case 5:
                    if (r.ToString() == RespuestaP1.Text)
                    {
                        MessageBox.Show("¡Respuesta correcta!");
                        FormPrincipal.problema5R = true; // Modificar el booleano del formulario principal
                        FormPrincipal.actualizarLayout();
                        c++;
                        FormPrincipal.actualizarCorrectas(c);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, intente nuevamente.");
                        v--;
                        FormPrincipal.actualizarVidas(v);
                        FormPrincipal.problema5F = true;
                        this.Close();
                    }
                    break;
                default:
                    break;
            }

        }
    }
}