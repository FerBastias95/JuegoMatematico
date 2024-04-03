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
            listaEnunciados = new ListBox();
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
            imagenEnunciado = new PictureBox();
            label11 = new Label();
            resultadoImagen = new TextBox();
            abrirImagen = new Button();
            abrirAvanzado = new Button();
            resultadoEnunciado = new TextBox();
            label3 = new Label();
            label4 = new Label();
            permitirAvanzado = new CheckBox();
            label5 = new Label();
            curso = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).BeginInit();
            SuspendLayout();
            // 
            // listaEnunciados
            // 
            listaEnunciados.FormattingEnabled = true;
            listaEnunciados.ItemHeight = 15;
            listaEnunciados.Location = new Point(32, 14);
            listaEnunciados.Name = "listaEnunciados";
            listaEnunciados.Size = new Size(118, 289);
            listaEnunciados.TabIndex = 0;
            // 
            // nuevoEnunciado
            // 
            nuevoEnunciado.Location = new Point(32, 315);
            nuevoEnunciado.Name = "nuevoEnunciado";
            nuevoEnunciado.Size = new Size(118, 23);
            nuevoEnunciado.TabIndex = 1;
            nuevoEnunciado.Text = "Nuevo";
            nuevoEnunciado.UseVisualStyleBackColor = true;
            nuevoEnunciado.Click += nuevoEnunciado_Click;
            // 
            // borrarEnunciado
            // 
            borrarEnunciado.Location = new Point(32, 344);
            borrarEnunciado.Name = "borrarEnunciado";
            borrarEnunciado.Size = new Size(118, 23);
            borrarEnunciado.TabIndex = 2;
            borrarEnunciado.Text = "Eliminar";
            borrarEnunciado.UseVisualStyleBackColor = true;
            borrarEnunciado.Click += borrarEnunciado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 14);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre enunciado";
            // 
            // NombreEnunciado
            // 
            NombreEnunciado.Location = new Point(287, 11);
            NombreEnunciado.Name = "NombreEnunciado";
            NombreEnunciado.Size = new Size(465, 23);
            NombreEnunciado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 74);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Categoría";
            // 
            // categoria
            // 
            categoria.FormattingEnabled = true;
            categoria.Items.AddRange(new object[] { "Algebra", "Geometría", "Estadística", "Probabilidades" });
            categoria.Location = new Point(287, 71);
            categoria.Name = "categoria";
            categoria.Size = new Size(206, 23);
            categoria.TabIndex = 6;
            // 
            // opcionTexto
            // 
            opcionTexto.AutoSize = true;
            opcionTexto.Checked = true;
            opcionTexto.Location = new Point(287, 100);
            opcionTexto.Name = "opcionTexto";
            opcionTexto.Size = new Size(111, 19);
            opcionTexto.TabIndex = 7;
            opcionTexto.TabStop = true;
            opcionTexto.Text = "Texto y variables";
            opcionTexto.UseVisualStyleBackColor = true;
            opcionTexto.CheckedChanged += opcionTexto_CheckedChanged;
            // 
            // opcionImagen
            // 
            opcionImagen.AutoSize = true;
            opcionImagen.Location = new Point(404, 100);
            opcionImagen.Name = "opcionImagen";
            opcionImagen.Size = new Size(65, 19);
            opcionImagen.TabIndex = 8;
            opcionImagen.Text = "Imagen";
            opcionImagen.UseVisualStyleBackColor = true;
            opcionImagen.CheckedChanged += opcionImagen_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(171, 125);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 14;
            label6.Text = "Enunciado";
            // 
            // textoEnunciado
            // 
            textoEnunciado.Location = new Point(287, 125);
            textoEnunciado.Name = "textoEnunciado";
            textoEnunciado.Size = new Size(206, 138);
            textoEnunciado.TabIndex = 15;
            textoEnunciado.Text = "";
            // 
            // idEnunciado
            // 
            idEnunciado.Location = new Point(287, 42);
            idEnunciado.Name = "idEnunciado";
            idEnunciado.Size = new Size(100, 23);
            idEnunciado.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(171, 45);
            label10.Name = "label10";
            label10.Size = new Size(18, 15);
            label10.TabIndex = 26;
            label10.Text = "ID";
            // 
            // actualizarEnunciado
            // 
            actualizarEnunciado.Location = new Point(170, 344);
            actualizarEnunciado.Name = "actualizarEnunciado";
            actualizarEnunciado.Size = new Size(580, 23);
            actualizarEnunciado.TabIndex = 27;
            actualizarEnunciado.Text = "Actualizar";
            actualizarEnunciado.UseVisualStyleBackColor = true;
            // 
            // imagenEnunciado
            // 
            imagenEnunciado.Enabled = false;
            imagenEnunciado.Location = new Point(514, 125);
            imagenEnunciado.Name = "imagenEnunciado";
            imagenEnunciado.Size = new Size(238, 109);
            imagenEnunciado.TabIndex = 28;
            imagenEnunciado.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(513, 278);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 29;
            label11.Text = "Resultado";
            // 
            // resultadoImagen
            // 
            resultadoImagen.Enabled = false;
            resultadoImagen.Location = new Point(578, 275);
            resultadoImagen.Name = "resultadoImagen";
            resultadoImagen.Size = new Size(172, 23);
            resultadoImagen.TabIndex = 30;
            // 
            // abrirImagen
            // 
            abrirImagen.Enabled = false;
            abrirImagen.Location = new Point(513, 240);
            abrirImagen.Name = "abrirImagen";
            abrirImagen.Size = new Size(238, 23);
            abrirImagen.TabIndex = 31;
            abrirImagen.Text = "Cargar Imagen";
            abrirImagen.UseVisualStyleBackColor = true;
            // 
            // abrirAvanzado
            // 
            abrirAvanzado.Enabled = false;
            abrirAvanzado.Location = new Point(287, 315);
            abrirAvanzado.Name = "abrirAvanzado";
            abrirAvanzado.Size = new Size(463, 23);
            abrirAvanzado.TabIndex = 35;
            abrirAvanzado.Text = "Editar enunciado avanzado";
            abrirAvanzado.UseVisualStyleBackColor = true;
            abrirAvanzado.Click += button5_Click;
            // 
            // resultadoEnunciado
            // 
            resultadoEnunciado.Location = new Point(287, 275);
            resultadoEnunciado.Name = "resultadoEnunciado";
            resultadoEnunciado.Size = new Size(206, 23);
            resultadoEnunciado.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 278);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 37;
            label3.Text = "Resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 102);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 38;
            label4.Text = "Formato enunciado";
            // 
            // permitirAvanzado
            // 
            permitirAvanzado.AutoSize = true;
            permitirAvanzado.Location = new Point(171, 318);
            permitirAvanzado.Name = "permitirAvanzado";
            permitirAvanzado.Size = new Size(78, 19);
            permitirAvanzado.TabIndex = 39;
            permitirAvanzado.Text = "Avanzado";
            permitirAvanzado.UseVisualStyleBackColor = true;
            permitirAvanzado.CheckedChanged += permitirAvanzado_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(513, 74);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 40;
            label5.Text = "Curso";
            // 
            // curso
            // 
            curso.FormattingEnabled = true;
            curso.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            curso.Location = new Point(584, 71);
            curso.Name = "curso";
            curso.Size = new Size(166, 23);
            curso.TabIndex = 41;
            // 
            // AlterarBDD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 381);
            Controls.Add(curso);
            Controls.Add(label5);
            Controls.Add(permitirAvanzado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(resultadoEnunciado);
            Controls.Add(abrirAvanzado);
            Controls.Add(abrirImagen);
            Controls.Add(resultadoImagen);
            Controls.Add(label11);
            Controls.Add(imagenEnunciado);
            Controls.Add(actualizarEnunciado);
            Controls.Add(label10);
            Controls.Add(idEnunciado);
            Controls.Add(textoEnunciado);
            Controls.Add(label6);
            Controls.Add(opcionImagen);
            Controls.Add(opcionTexto);
            Controls.Add(categoria);
            Controls.Add(label2);
            Controls.Add(NombreEnunciado);
            Controls.Add(label1);
            Controls.Add(borrarEnunciado);
            Controls.Add(nuevoEnunciado);
            Controls.Add(listaEnunciados);
            MaximizeBox = false;
            Name = "AlterarBDD";
            Text = "AlterarBDD";
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listaEnunciados;
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
        private PictureBox imagenEnunciado;
        private Label label11;
        private TextBox resultadoImagen;
        private Button abrirImagen;
        private Button abrirAvanzado;
        private TextBox resultadoEnunciado;
        private Label label3;
        private Label label4;
        private CheckBox permitirAvanzado;
        private Label label5;
        private ComboBox curso;
    }
}