﻿using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Reflection;
using NCalc;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicios {
    public partial class Form1 : Form {
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
        public List<Button> botones;
        public List<bool> resueltos;
        public List<bool> fallados;
        public List<string> original;
        string pathName = "";
        BDD ejercicios;
        public Form1() {
            tiempo = 60;
            vidas = 5;
            correctas = 0;
            InitializeComponent();
        }
        private void iniciarLayout() {
            correctas = 0;
            dif = 0;
            vidas = 5;
            tiempo = 60;
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
                foreach (var enunciado in enunciados) {
                    enunciado.Original = enunciado.Enunciado;
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
                    // Si hay más de 10 enunciados, seleccionar 10 al azar
                    List<int> indicesSeleccionados = GenerarNumerosAleatorios(totalEnunciados - 1);
                    foreach (int index in indicesSeleccionados) {
                        int a = 0;
                        EnunciadoBase enunciadoNuevo = new EnunciadoBase();
                        enunciadoNuevo = enunciados[index];
                        enunciadoNuevo.indice = a;
                        elegidos.Add(enunciadoNuevo);
                        a++;
                    }
                }

                // Si la cantidad de enunciados es menor a 10, rellenar con enunciados avanzados
                while (elegidos.Count < 10) {
                    int a = 0;
                    // Generar números aleatorios para seleccionar los enunciados restantes de la lista de enunciados avanzados
                    List<int> indicesRestantes = GenerarNumerosAleatorios(avanzados.Count - 1);
                    // Agregar los enunciados restantes a la lista de elegidos
                    foreach (int index in indicesRestantes) {
                        // Crear un nuevo enunciado y copiar las propiedades del enunciado base
                        EnunciadoBase enunciadoNuevo = new EnunciadoBase();
                        EnunciadoBase enunciadoBase = avanzados[indicesRestantes[index]];
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
                        // Agregar el nuevo enunciado a la lista de elegidos

                        CalcularRespuesta(enunciadoNuevo);
                        elegidos.Add(enunciadoNuevo);
                        a++;
                    }
                }

                // Mostrar los enunciados seleccionados en la interfaz gráfica
                for (int j = 0; j < elegidos.Count; j++) {
                    var enunciado = elegidos[j];
                    botones[j].Show();
                    modificarVariables(enunciado);
                }
                dificultad(0);
                cambiarVariables.Enabled = true;
                botonOpciones.Enabled = true;
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
                int numeroAleatorio = rnd.Next(0, X + 1); // Genera un número aleatorio entre 0 y X

                if (!numerosGenerados.Contains(numeroAleatorio)) {
                    numerosAleatorios.Add(numeroAleatorio);
                    numerosGenerados.Add(numeroAleatorio);
                }
            }
            return numerosAleatorios;
        }

        public void modificarVariables(EnunciadoBase enunciadoBase) {
            Random randy = new Random();
            EnunciadoBase e = enunciadoBase;
            e.Enunciado = e.Original;

            if (e.Avanzado) {
                if (e.Decimal1) {
                    if (e.Final1 > e.Inicio1) {
                        double extra = randy.NextDouble();
                        e.Variable1 = e.Inicio1 + (e.Final1 - e.Inicio1) * extra;
                        e.Variable1 = Math.Round(e.Variable1, 2);
                    }
                    else if (e.Final1 < e.Inicio1) {
                        double extra = randy.NextDouble();
                        e.Variable1 = e.Inicio1 + (e.Inicio1 - e.Final1) * extra;
                        e.Variable1 = Math.Round(e.Variable1, 2);
                    }
                }
                else {
                    if (e.Final1 > e.Inicio1) {
                        e.Variable1 = randy.Next(e.Inicio1, (int)e.Final1 + 1);
                    }
                    else if (e.Final1 < e.Inicio1) {
                        e.Variable1 = randy.Next(e.Final1, (int)e.Inicio1 + 1);
                    }
                }
                if (e.Decimal2) {
                    if (e.Final2 > e.Inicio2) {
                        double extra = randy.NextDouble();
                        e.Variable2 = e.Inicio2 + (e.Final2 - e.Inicio2) * extra;
                        e.Variable2 = Math.Round(e.Variable2, 2);
                    }
                    else if (e.Final2 < e.Inicio2) {
                        double extra = randy.NextDouble();
                        e.Variable2 = e.Inicio2 + (e.Inicio2 - e.Final2) * extra;
                        e.Variable2 = Math.Round(e.Variable2, 2);
                    }
                }
                else {
                    if (e.Final2 > e.Inicio2) {
                        e.Variable2 = randy.Next(e.Inicio2, (int)e.Final2 + 1);
                    }
                    else if (e.Final2 < e.Inicio2) {
                        e.Variable2 = randy.Next(e.Final2, (int)e.Inicio2 + 1);
                    }
                }
                if (e.Decimal3) {
                    if (e.Final3 > e.Inicio3) {
                        double extra = randy.NextDouble();
                        e.Variable3 = e.Inicio3 + (e.Final3 - e.Inicio3) * extra;
                        e.Variable3 = Math.Round(e.Variable3, 2);
                    }
                    else if (e.Final3 < e.Inicio3) {
                        double extra = randy.NextDouble();
                        e.Variable3 = e.Inicio3 + (e.Inicio3 - e.Final3) * extra;
                        e.Variable3 = Math.Round(e.Variable3, 2);
                    }
                }
                else {
                    if (e.Final3 > e.Inicio3) {
                        e.Variable3 = randy.Next(e.Inicio3, (int)e.Final3 + 1);
                    }
                    else if (e.Final3 < e.Inicio3) {
                        e.Variable3 = randy.Next(e.Final3, (int)e.Inicio3 + 1);
                    }
                }
                if (e.Decimal4) {
                    if (e.Final4 > e.Inicio4) {
                        double extra = randy.NextDouble();
                        e.Variable4 = e.Inicio4 + (e.Final4 - e.Inicio4) * extra;
                        e.Variable4 = Math.Round(e.Variable4, 2);
                    }
                    else if (e.Final4 < e.Inicio4) {
                        double extra = randy.NextDouble();
                        e.Variable4 = e.Inicio4 + (e.Inicio4 - e.Final4) * extra;
                        e.Variable4 = Math.Round(e.Variable4, 2);
                    }
                }
                else {
                    if (e.Final4 > e.Inicio4) {
                        e.Variable4 = randy.Next(e.Inicio4, (int)e.Final4 + 1);
                    }
                    else if (e.Final4 < e.Inicio4) {
                        e.Variable4 = randy.Next(e.Final4, (int)e.Inicio4 + 1);
                    }
                }
                reemplazarVariables(e);
                e.Respuesta = CalcularRespuesta(e);
            }
        }
        public void reemplazarVariables(EnunciadoBase enunciado) {
            if (enunciado.Avanzado) {
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v1}", enunciado.Variable1.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v2}", enunciado.Variable2.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v3}", enunciado.Variable3.ToString());
                enunciado.Enunciado = enunciado.Enunciado.Replace("{v4}", enunciado.Variable4.ToString());
            }
        }
        public double CalcularRespuesta(EnunciadoBase enunciado) {
            // Reemplazar las variables en la fórmula por sus valores
            string formulaEvaluable = enunciado.Formula;
            formulaEvaluable = formulaEvaluable.Replace("Var1", enunciado.Variable1.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var2", enunciado.Variable2.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var3", enunciado.Variable3.ToString());
            formulaEvaluable = formulaEvaluable.Replace("Var4", enunciado.Variable4.ToString());
            formulaEvaluable = formulaEvaluable.Replace("π", "3.1415926535897932384626433832795");

            try {
                object result = new DataTable().Compute(formulaEvaluable, null);
                Console.WriteLine($"El resultado de la operación {formulaEvaluable} es: {result}");
                double resultadoNumerico = Convert.ToDouble(result);
                double resultadoRedondeado = Math.Round(resultadoNumerico, 1);
                return resultadoRedondeado;
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
                modificarVariables(elegidos[i]);
            }
            MessageBox.Show("Enunciados modificados");
        }
        private void botonOpciones_Click(object sender, EventArgs e) {
            List<int> numeros = GenerarNumerosAleatorios(enunciados.Count - 1);
            Opciones o = new Opciones(this);
            o.ShowDialog();
        }

        public void dificultad(int d) {
            dif = d;
            button1.Hide();
            int i = 0;
            for (int j = 0; j < 10; j++) {
                labels[j].Hide();
                botones[j].Hide();
            }

            if (d == 0) {
                for (i = 0; i < 5; i++) {
                    labels[i].Show();
                    botones[i].Show();
                }
            }
            else if (d == 1) {
                for (i = 0; i < 10; i++) {
                    labels[i].Show();
                    botones[i].Show();
                }
            }
            else if (d == 2) {
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
            if (elegidos[0].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[0], this, 0);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[0], this, 0);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void botonP2_Click(object sender, EventArgs e) {
            if (elegidos[1].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[1], this, 1);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[1], this, 1);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void botonP3_Click(object sender, EventArgs e) {
            if (elegidos[2].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[2], this, 2);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[2], this, 2);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void botonP4_Click(object sender, EventArgs e) {
            if (elegidos[3].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[3], this, 3);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[3], this, 3);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void botonP5_Click(object sender, EventArgs e) {
            if (elegidos[4].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[4], this, 4);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[4], this, 4);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void botonP6_Click(object sender, EventArgs e) {
            if (elegidos[5].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[5], this, 5);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[5], this, 5);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void botonP7_Click(object sender, EventArgs e) {
            if (elegidos[6].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[6], this, 6);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[6], this, 6);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void botonP8_Click(object sender, EventArgs e) {
            if (elegidos[7].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[7], this, 7);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[7], this, 7);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void botonP9_Click(object sender, EventArgs e) {
            if (elegidos[8].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[8], this, 8);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[8], this, 8);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void botonP10_Click(object sender, EventArgs e) {
            if (elegidos[9].Imagen == null) {
                if (problema1R == false) {
                    VentanaEnunciado problema1Form = new VentanaEnunciado(elegidos[9], this, 9);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
            else {
                if (problema1R == false) {
                    VentanaEnunciadoImagen problema1Form = new VentanaEnunciadoImagen(elegidos[9], this, 9);
                    problema1Form.FormPrincipal = this;
                    problema1Form.ShowDialog();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            if (problema1R == false) {
                VentanaEnunciadoDesafio problema1Form = new VentanaEnunciadoDesafio(elegidos, this);
                problema1Form.FormPrincipal = this;
                problema1Form.ShowDialog();
            }
        }
    }
}
