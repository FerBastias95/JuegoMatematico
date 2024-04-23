namespace Olimpiadas
{
    partial class AlterarBDD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nuevoEnunciado = new Button();
            borrarEnunciado = new Button();
            label1 = new Label();
            NombreEnunciado = new TextBox();
            label2 = new Label();
            categoria = new ComboBox();
            label6 = new Label();
            textoEnunciado = new RichTextBox();
            idEnunciado = new TextBox();
            label10 = new Label();
            actualizarEnunciado = new Button();
            abrirImagen = new Button();
            abrirAvanzado = new Button();
            label5 = new Label();
            cursoSeleccion = new ComboBox();
            imagenEnunciado = new PictureBox();
            panel1 = new Panel();
            cambiarBDD = new Button();
            crearLista = new Button();
            listBoxEnunciados = new ListBox();
            label4 = new Label();
            NombreLista = new TextBox();
            label3 = new Label();
            resultadoEnunciado2 = new TextBox();
            resultadoEnunciado = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nuevoEnunciado
            // 
            nuevoEnunciado.Location = new Point(12, 440);
            nuevoEnunciado.Margin = new Padding(3, 4, 3, 4);
            nuevoEnunciado.Name = "nuevoEnunciado";
            nuevoEnunciado.Size = new Size(206, 33);
            nuevoEnunciado.TabIndex = 1;
            nuevoEnunciado.Text = "Nuevo enunciado";
            nuevoEnunciado.UseVisualStyleBackColor = true;
            nuevoEnunciado.Click += nuevoEnunciado_Click;
            // 
            // borrarEnunciado
            // 
            borrarEnunciado.Location = new Point(12, 481);
            borrarEnunciado.Margin = new Padding(3, 4, 3, 4);
            borrarEnunciado.Name = "borrarEnunciado";
            borrarEnunciado.Size = new Size(206, 31);
            borrarEnunciado.TabIndex = 2;
            borrarEnunciado.Text = "Eliminar seleccionado";
            borrarEnunciado.UseVisualStyleBackColor = true;
            borrarEnunciado.Click += borrarEnunciado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 12);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre enunciado";
            // 
            // NombreEnunciado
            // 
            NombreEnunciado.Enabled = false;
            NombreEnunciado.Location = new Point(150, 11);
            NombreEnunciado.Margin = new Padding(3, 4, 3, 4);
            NombreEnunciado.Name = "NombreEnunciado";
            NombreEnunciado.Size = new Size(567, 27);
            NombreEnunciado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 45);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Categoría";
            // 
            // categoria
            // 
            categoria.Enabled = false;
            categoria.FormattingEnabled = true;
            categoria.Items.AddRange(new object[] { "(sin categoría)", "Algebra", "Geometría", "Estadística", "Probabilidades" });
            categoria.Location = new Point(373, 45);
            categoria.Margin = new Padding(3, 4, 3, 4);
            categoria.Name = "categoria";
            categoria.Size = new Size(156, 28);
            categoria.TabIndex = 6;
            categoria.SelectedIndexChanged += categoria_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 111);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 14;
            label6.Text = "Enunciado";
            // 
            // textoEnunciado
            // 
            textoEnunciado.Enabled = false;
            textoEnunciado.Location = new Point(224, 135);
            textoEnunciado.Margin = new Padding(3, 4, 3, 4);
            textoEnunciado.Name = "textoEnunciado";
            textoEnunciado.Size = new Size(367, 261);
            textoEnunciado.TabIndex = 15;
            textoEnunciado.Text = "";
            // 
            // idEnunciado
            // 
            idEnunciado.Enabled = false;
            idEnunciado.Location = new Point(578, 45);
            idEnunciado.Margin = new Padding(3, 4, 3, 4);
            idEnunciado.Name = "idEnunciado";
            idEnunciado.Size = new Size(139, 27);
            idEnunciado.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(548, 45);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 26;
            label10.Text = "ID";
            // 
            // actualizarEnunciado
            // 
            actualizarEnunciado.Enabled = false;
            actualizarEnunciado.ImageAlign = ContentAlignment.MiddleRight;
            actualizarEnunciado.Location = new Point(224, 481);
            actualizarEnunciado.Margin = new Padding(3, 4, 3, 4);
            actualizarEnunciado.Name = "actualizarEnunciado";
            actualizarEnunciado.Size = new Size(724, 33);
            actualizarEnunciado.TabIndex = 27;
            actualizarEnunciado.Text = "Actualizar";
            actualizarEnunciado.UseVisualStyleBackColor = true;
            actualizarEnunciado.Click += actualizarEnunciado_Click;
            // 
            // abrirImagen
            // 
            abrirImagen.Enabled = false;
            abrirImagen.Location = new Point(617, 401);
            abrirImagen.Margin = new Padding(3, 4, 3, 4);
            abrirImagen.Name = "abrirImagen";
            abrirImagen.Size = new Size(332, 31);
            abrirImagen.TabIndex = 31;
            abrirImagen.Text = "Cargar Imagen";
            abrirImagen.UseVisualStyleBackColor = true;
            abrirImagen.Click += abrirImagen_Click;
            // 
            // abrirAvanzado
            // 
            abrirAvanzado.AutoSize = true;
            abrirAvanzado.Enabled = false;
            abrirAvanzado.Location = new Point(224, 440);
            abrirAvanzado.Margin = new Padding(3, 4, 3, 4);
            abrirAvanzado.Name = "abrirAvanzado";
            abrirAvanzado.Size = new Size(724, 33);
            abrirAvanzado.TabIndex = 35;
            abrirAvanzado.Text = "Editar enunciado avanzado";
            abrirAvanzado.UseVisualStyleBackColor = true;
            abrirAvanzado.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 45);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 40;
            label5.Text = "Curso";
            // 
            // cursoSeleccion
            // 
            cursoSeleccion.Enabled = false;
            cursoSeleccion.FormattingEnabled = true;
            cursoSeleccion.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cursoSeleccion.Location = new Point(150, 45);
            cursoSeleccion.Margin = new Padding(3, 4, 3, 4);
            cursoSeleccion.Name = "cursoSeleccion";
            cursoSeleccion.Size = new Size(119, 28);
            cursoSeleccion.TabIndex = 41;
            cursoSeleccion.SelectedIndexChanged += cursoSeleccion_SelectedIndexChanged;
            // 
            // imagenEnunciado
            // 
            imagenEnunciado.Location = new Point(617, 135);
            imagenEnunciado.Margin = new Padding(3, 4, 3, 4);
            imagenEnunciado.Name = "imagenEnunciado";
            imagenEnunciado.Size = new Size(332, 261);
            imagenEnunciado.TabIndex = 33;
            imagenEnunciado.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cursoSeleccion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(NombreEnunciado);
            panel1.Controls.Add(categoria);
            panel1.Controls.Add(idEnunciado);
            panel1.Location = new Point(224, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 85);
            panel1.TabIndex = 44;
            // 
            // cambiarBDD
            // 
            cambiarBDD.Location = new Point(12, 68);
            cambiarBDD.Margin = new Padding(3, 4, 3, 4);
            cambiarBDD.Name = "cambiarBDD";
            cambiarBDD.Size = new Size(104, 33);
            cambiarBDD.TabIndex = 45;
            cambiarBDD.Text = "Cambiar lista";
            cambiarBDD.UseVisualStyleBackColor = true;
            cambiarBDD.Click += cambiarBDD_Click;
            // 
            // crearLista
            // 
            crearLista.Location = new Point(122, 68);
            crearLista.Margin = new Padding(3, 4, 3, 4);
            crearLista.Name = "crearLista";
            crearLista.Size = new Size(96, 33);
            crearLista.TabIndex = 46;
            crearLista.Text = "Crear lista";
            crearLista.UseVisualStyleBackColor = true;
            crearLista.Click += crearLista_Click;
            // 
            // listBoxEnunciados
            // 
            listBoxEnunciados.Enabled = false;
            listBoxEnunciados.FormattingEnabled = true;
            listBoxEnunciados.Location = new Point(12, 135);
            listBoxEnunciados.Name = "listBoxEnunciados";
            listBoxEnunciados.Size = new Size(206, 284);
            listBoxEnunciados.TabIndex = 47;
            listBoxEnunciados.SelectedIndexChanged += listBoxEnunciados_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 11);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 48;
            label4.Text = "Nombre de la lista:";
            // 
            // NombreLista
            // 
            NombreLista.Location = new Point(12, 34);
            NombreLista.Name = "NombreLista";
            NombreLista.ReadOnly = true;
            NombreLista.Size = new Size(206, 27);
            NombreLista.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 555);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 37;
            label3.Text = "Resultado";
            // 
            // resultadoEnunciado2
            // 
            resultadoEnunciado2.Location = new Point(423, 657);
            resultadoEnunciado2.Margin = new Padding(3, 4, 3, 4);
            resultadoEnunciado2.MaximumSize = new Size(100, 100);
            resultadoEnunciado2.MinimumSize = new Size(100, 100);
            resultadoEnunciado2.Name = "resultadoEnunciado2";
            resultadoEnunciado2.Size = new Size(100, 27);
            resultadoEnunciado2.TabIndex = 36;
            // 
            // resultadoEnunciado
            // 
            resultadoEnunciado.Enabled = false;
            resultadoEnunciado.Location = new Point(325, 403);
            resultadoEnunciado.Name = "resultadoEnunciado";
            resultadoEnunciado.Size = new Size(265, 27);
            resultadoEnunciado.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(725, 111);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 51;
            label8.Text = "Imagen (Opcional)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(224, 406);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 52;
            label9.Text = "Resultado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 112);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 53;
            label7.Text = "Lista de Enunciados";
            // 
            // AlterarBDD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 522);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(resultadoEnunciado);
            Controls.Add(imagenEnunciado);
            Controls.Add(textoEnunciado);
            Controls.Add(NombreLista);
            Controls.Add(label6);
            Controls.Add(abrirImagen);
            Controls.Add(label4);
            Controls.Add(listBoxEnunciados);
            Controls.Add(cambiarBDD);
            Controls.Add(nuevoEnunciado);
            Controls.Add(borrarEnunciado);
            Controls.Add(abrirAvanzado);
            Controls.Add(crearLista);
            Controls.Add(actualizarEnunciado);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AlterarBDD";
            Text = "AlterarBDD";
            FormClosed += AlterarBDD_FormClosed;
            Load += AlterarBDD_Load;
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button nuevoEnunciado;
        private Button borrarEnunciado;
        private Label label1;
        private TextBox NombreEnunciado;
        private Label label2;
        private ComboBox categoria;
        private Label label6;
        private RichTextBox textoEnunciado;
        private TextBox idEnunciado;
        private Label label10;
        private Button actualizarEnunciado;
        private Button abrirImagen;
        private Button abrirAvanzado;
        private Label label5;
        private ComboBox cursoSeleccion;
        private Panel panel1;
        private PictureBox imagenEnunciado;
        private Button cambiarBDD;
        private Button crearLista;
        private ListBox listBoxEnunciados;
        private Label label4;
        private TextBox NombreLista;
        private Label label3;
        private TextBox resultadoEnunciado2;
        private TextBox resultadoEnunciado;
        private Label label8;
        private Label label9;
        private Label label7;
    }
}