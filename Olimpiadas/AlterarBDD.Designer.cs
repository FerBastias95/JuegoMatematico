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
            opcionTexto = new RadioButton();
            opcionImagen = new RadioButton();
            label6 = new Label();
            textoEnunciado = new RichTextBox();
            idEnunciado = new TextBox();
            label10 = new Label();
            actualizarEnunciado = new Button();
            label11 = new Label();
            resultadoImagen = new TextBox();
            abrirImagen = new Button();
            abrirAvanzado = new Button();
            resultadoEnunciado = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cursoSeleccion = new ComboBox();
            listaEnunciados2 = new ComboBox();
            splitContainer1 = new SplitContainer();
            imagenEnunciado = new PictureBox();
            imagenTexto = new RichTextBox();
            panel1 = new Panel();
            opcionAvanzado = new RadioButton();
            cambiarBDD = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nuevoEnunciado
            // 
            nuevoEnunciado.Location = new Point(3, 550);
            nuevoEnunciado.Name = "nuevoEnunciado";
            nuevoEnunciado.Size = new Size(192, 25);
            nuevoEnunciado.TabIndex = 1;
            nuevoEnunciado.Text = "Nuevo";
            nuevoEnunciado.UseVisualStyleBackColor = true;
            nuevoEnunciado.Click += nuevoEnunciado_Click;
            // 
            // borrarEnunciado
            // 
            borrarEnunciado.Location = new Point(3, 581);
            borrarEnunciado.Name = "borrarEnunciado";
            borrarEnunciado.Size = new Size(192, 25);
            borrarEnunciado.TabIndex = 2;
            borrarEnunciado.Text = "Eliminar";
            borrarEnunciado.UseVisualStyleBackColor = true;
            borrarEnunciado.Click += borrarEnunciado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre enunciado";
            // 
            // NombreEnunciado
            // 
            NombreEnunciado.Location = new Point(131, 7);
            NombreEnunciado.Name = "NombreEnunciado";
            NombreEnunciado.Size = new Size(637, 23);
            NombreEnunciado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 41);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Categoría";
            // 
            // categoria
            // 
            categoria.FormattingEnabled = true;
            categoria.Items.AddRange(new object[] { "Algebra", "Geometría", "Estadística", "Probabilidades" });
            categoria.Location = new Point(378, 38);
            categoria.Name = "categoria";
            categoria.Size = new Size(243, 23);
            categoria.TabIndex = 6;
            // 
            // opcionTexto
            // 
            opcionTexto.AutoSize = true;
            opcionTexto.Checked = true;
            opcionTexto.Location = new Point(130, 74);
            opcionTexto.Name = "opcionTexto";
            opcionTexto.Size = new Size(53, 19);
            opcionTexto.TabIndex = 7;
            opcionTexto.TabStop = true;
            opcionTexto.Text = "Texto";
            opcionTexto.UseVisualStyleBackColor = true;
            opcionTexto.CheckedChanged += opcionTexto_CheckedChanged;
            // 
            // opcionImagen
            // 
            opcionImagen.AutoSize = true;
            opcionImagen.Location = new Point(193, 74);
            opcionImagen.Name = "opcionImagen";
            opcionImagen.Size = new Size(105, 19);
            opcionImagen.TabIndex = 8;
            opcionImagen.Text = "Texto e imagen";
            opcionImagen.UseVisualStyleBackColor = true;
            opcionImagen.CheckedChanged += opcionImagen_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 6);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 14;
            label6.Text = "Enunciado";
            // 
            // textoEnunciado
            // 
            textoEnunciado.Location = new Point(80, 6);
            textoEnunciado.Name = "textoEnunciado";
            textoEnunciado.Size = new Size(288, 402);
            textoEnunciado.TabIndex = 15;
            textoEnunciado.Text = "";
            // 
            // idEnunciado
            // 
            idEnunciado.Location = new Point(655, 38);
            idEnunciado.Name = "idEnunciado";
            idEnunciado.Size = new Size(113, 23);
            idEnunciado.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(631, 41);
            label10.Name = "label10";
            label10.Size = new Size(18, 15);
            label10.TabIndex = 26;
            label10.Text = "ID";
            // 
            // actualizarEnunciado
            // 
            actualizarEnunciado.ImageAlign = ContentAlignment.MiddleRight;
            actualizarEnunciado.Location = new Point(201, 578);
            actualizarEnunciado.Name = "actualizarEnunciado";
            actualizarEnunciado.Size = new Size(771, 25);
            actualizarEnunciado.TabIndex = 27;
            actualizarEnunciado.Text = "Actualizar";
            actualizarEnunciado.UseVisualStyleBackColor = true;
            actualizarEnunciado.Click += actualizarEnunciado_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 94);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 29;
            label11.Text = "Resultado";
            // 
            // resultadoImagen
            // 
            resultadoImagen.Enabled = false;
            resultadoImagen.Location = new Point(64, 91);
            resultadoImagen.Name = "resultadoImagen";
            resultadoImagen.Size = new Size(329, 23);
            resultadoImagen.TabIndex = 30;
            // 
            // abrirImagen
            // 
            abrirImagen.Enabled = false;
            abrirImagen.Location = new Point(3, 120);
            abrirImagen.Name = "abrirImagen";
            abrirImagen.Size = new Size(390, 23);
            abrirImagen.TabIndex = 31;
            abrirImagen.Text = "Cargar Imagen";
            abrirImagen.UseVisualStyleBackColor = true;
            abrirImagen.Click += abrirImagen_Click;
            // 
            // abrirAvanzado
            // 
            abrirAvanzado.AutoSize = true;
            abrirAvanzado.Enabled = false;
            abrirAvanzado.Location = new Point(201, 550);
            abrirAvanzado.Name = "abrirAvanzado";
            abrirAvanzado.Size = new Size(771, 25);
            abrirAvanzado.TabIndex = 35;
            abrirAvanzado.Text = "Editar enunciado avanzado";
            abrirAvanzado.UseVisualStyleBackColor = true;
            abrirAvanzado.Click += button5_Click;
            // 
            // resultadoEnunciado
            // 
            resultadoEnunciado.Location = new Point(80, 414);
            resultadoEnunciado.Name = "resultadoEnunciado";
            resultadoEnunciado.Size = new Size(288, 23);
            resultadoEnunciado.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 418);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 37;
            label3.Text = "Resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 75);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 38;
            label4.Text = "Formato enunciado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 43);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 40;
            label5.Text = "Curso";
            // 
            // cursoSeleccion
            // 
            cursoSeleccion.FormattingEnabled = true;
            cursoSeleccion.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cursoSeleccion.Location = new Point(59, 38);
            cursoSeleccion.Name = "cursoSeleccion";
            cursoSeleccion.Size = new Size(243, 23);
            cursoSeleccion.TabIndex = 41;
            // 
            // listaEnunciados2
            // 
            listaEnunciados2.FormattingEnabled = true;
            listaEnunciados2.Location = new Point(3, 15);
            listaEnunciados2.Name = "listaEnunciados2";
            listaEnunciados2.Size = new Size(192, 23);
            listaEnunciados2.TabIndex = 3;
            listaEnunciados2.Text = "Seleccione enunciado";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(201, 104);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textoEnunciado);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(resultadoEnunciado);
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(imagenEnunciado);
            splitContainer1.Panel2.Controls.Add(imagenTexto);
            splitContainer1.Panel2.Controls.Add(abrirImagen);
            splitContainer1.Panel2.Controls.Add(resultadoImagen);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Size = new Size(771, 440);
            splitContainer1.SplitterDistance = 371;
            splitContainer1.TabIndex = 43;
            // 
            // imagenEnunciado
            // 
            imagenEnunciado.Location = new Point(3, 149);
            imagenEnunciado.Name = "imagenEnunciado";
            imagenEnunciado.Size = new Size(390, 288);
            imagenEnunciado.TabIndex = 33;
            imagenEnunciado.TabStop = false;
            // 
            // imagenTexto
            // 
            imagenTexto.Enabled = false;
            imagenTexto.Location = new Point(3, 6);
            imagenTexto.Name = "imagenTexto";
            imagenTexto.Size = new Size(390, 79);
            imagenTexto.TabIndex = 32;
            imagenTexto.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(opcionAvanzado);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cursoSeleccion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(NombreEnunciado);
            panel1.Controls.Add(categoria);
            panel1.Controls.Add(opcionTexto);
            panel1.Controls.Add(opcionImagen);
            panel1.Controls.Add(idEnunciado);
            panel1.Location = new Point(201, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 98);
            panel1.TabIndex = 44;
            // 
            // opcionAvanzado
            // 
            opcionAvanzado.AutoSize = true;
            opcionAvanzado.Location = new Point(308, 74);
            opcionAvanzado.Name = "opcionAvanzado";
            opcionAvanzado.Size = new Size(77, 19);
            opcionAvanzado.TabIndex = 42;
            opcionAvanzado.TabStop = true;
            opcionAvanzado.Text = "Avanzado";
            opcionAvanzado.UseVisualStyleBackColor = true;
            opcionAvanzado.CheckedChanged += opcionAvanzado_CheckedChanged;
            // 
            // cambiarBDD
            // 
            cambiarBDD.Location = new Point(3, 47);
            cambiarBDD.Name = "cambiarBDD";
            cambiarBDD.Size = new Size(192, 25);
            cambiarBDD.TabIndex = 45;
            cambiarBDD.Text = "Cambiar lista";
            cambiarBDD.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 81);
            button1.Name = "button1";
            button1.Size = new Size(192, 25);
            button1.TabIndex = 46;
            button1.Text = "Crear lista";
            button1.UseVisualStyleBackColor = true;
            // 
            // AlterarBDD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 621);
            Controls.Add(listaEnunciados2);
            Controls.Add(cambiarBDD);
            Controls.Add(nuevoEnunciado);
            Controls.Add(borrarEnunciado);
            Controls.Add(abrirAvanzado);
            Controls.Add(button1);
            Controls.Add(actualizarEnunciado);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "AlterarBDD";
            Text = "AlterarBDD";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private RadioButton opcionTexto;
        private RadioButton opcionImagen;
        private Label label6;
        private RichTextBox textoEnunciado;
        private TextBox idEnunciado;
        private Label label10;
        private Button actualizarEnunciado;
        private Label label11;
        private TextBox resultadoImagen;
        private Button abrirImagen;
        private Button abrirAvanzado;
        private TextBox resultadoEnunciado;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cursoSeleccion;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private RichTextBox imagenTexto;
        private RadioButton opcionAvanzado;
        private PictureBox imagenEnunciado;
        private Button cambiarBDD;
        private Button button1;
        private ComboBox listaEnunciados2;
    }
}