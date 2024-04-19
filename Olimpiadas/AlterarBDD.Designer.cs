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
            tipoEnunciado = new ComboBox();
            label7 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nuevoEnunciado
            // 
            nuevoEnunciado.Location = new Point(12, 589);
            nuevoEnunciado.Margin = new Padding(3, 4, 3, 4);
            nuevoEnunciado.Name = "nuevoEnunciado";
            nuevoEnunciado.Size = new Size(206, 33);
            nuevoEnunciado.TabIndex = 1;
            nuevoEnunciado.Text = "Nuevo";
            nuevoEnunciado.UseVisualStyleBackColor = true;
            nuevoEnunciado.Click += nuevoEnunciado_Click;
            // 
            // borrarEnunciado
            // 
            borrarEnunciado.Location = new Point(12, 630);
            borrarEnunciado.Margin = new Padding(3, 4, 3, 4);
            borrarEnunciado.Name = "borrarEnunciado";
            borrarEnunciado.Size = new Size(206, 34);
            borrarEnunciado.TabIndex = 2;
            borrarEnunciado.Text = "Eliminar";
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
            NombreEnunciado.Location = new Point(150, 9);
            NombreEnunciado.Margin = new Padding(3, 4, 3, 4);
            NombreEnunciado.Name = "NombreEnunciado";
            NombreEnunciado.Size = new Size(555, 27);
            NombreEnunciado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 51);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Categoría";
            // 
            // categoria
            // 
            categoria.FormattingEnabled = true;
            categoria.Items.AddRange(new object[] { "(sin categoría)", "Algebra", "Geometría", "Estadística", "Probabilidades" });
            categoria.Location = new Point(373, 48);
            categoria.Margin = new Padding(3, 4, 3, 4);
            categoria.Name = "categoria";
            categoria.Size = new Size(156, 28);
            categoria.TabIndex = 6;
            categoria.SelectedIndexChanged += categoria_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(552, 163);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 14;
            label6.Text = "Enunciado";
            // 
            // textoEnunciado
            // 
            textoEnunciado.Location = new Point(258, 187);
            textoEnunciado.Margin = new Padding(3, 4, 3, 4);
            textoEnunciado.Name = "textoEnunciado";
            textoEnunciado.Size = new Size(679, 128);
            textoEnunciado.TabIndex = 15;
            textoEnunciado.Text = "";
            // 
            // idEnunciado
            // 
            idEnunciado.Location = new Point(578, 48);
            idEnunciado.Margin = new Padding(3, 4, 3, 4);
            idEnunciado.Name = "idEnunciado";
            idEnunciado.Size = new Size(127, 27);
            idEnunciado.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(548, 51);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 26;
            label10.Text = "ID";
            // 
            // actualizarEnunciado
            // 
            actualizarEnunciado.ImageAlign = ContentAlignment.MiddleRight;
            actualizarEnunciado.Location = new Point(230, 771);
            actualizarEnunciado.Margin = new Padding(3, 4, 3, 4);
            actualizarEnunciado.Name = "actualizarEnunciado";
            actualizarEnunciado.Size = new Size(707, 33);
            actualizarEnunciado.TabIndex = 27;
            actualizarEnunciado.Text = "Actualizar";
            actualizarEnunciado.UseVisualStyleBackColor = true;
            actualizarEnunciado.Click += actualizarEnunciado_Click;
            // 
            // abrirImagen
            // 
            abrirImagen.Enabled = false;
            abrirImagen.Location = new Point(258, 651);
            abrirImagen.Margin = new Padding(3, 4, 3, 4);
            abrirImagen.Name = "abrirImagen";
            abrirImagen.Size = new Size(679, 31);
            abrirImagen.TabIndex = 31;
            abrirImagen.Text = "Cargar Imagen";
            abrirImagen.UseVisualStyleBackColor = true;
            abrirImagen.Click += abrirImagen_Click;
            // 
            // abrirAvanzado
            // 
            abrirAvanzado.AutoSize = true;
            abrirAvanzado.Enabled = false;
            abrirAvanzado.Location = new Point(230, 733);
            abrirAvanzado.Margin = new Padding(3, 4, 3, 4);
            abrirAvanzado.Name = "abrirAvanzado";
            abrirAvanzado.Size = new Size(707, 33);
            abrirAvanzado.TabIndex = 35;
            abrirAvanzado.Text = "Editar enunciado avanzado";
            abrirAvanzado.UseVisualStyleBackColor = true;
            abrirAvanzado.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 51);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 40;
            label5.Text = "Curso";
            // 
            // cursoSeleccion
            // 
            cursoSeleccion.FormattingEnabled = true;
            cursoSeleccion.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cursoSeleccion.Location = new Point(150, 48);
            cursoSeleccion.Margin = new Padding(3, 4, 3, 4);
            cursoSeleccion.Name = "cursoSeleccion";
            cursoSeleccion.Size = new Size(119, 28);
            cursoSeleccion.TabIndex = 41;
            cursoSeleccion.SelectedIndexChanged += cursoSeleccion_SelectedIndexChanged;
            // 
            // imagenEnunciado
            // 
            imagenEnunciado.Location = new Point(258, 355);
            imagenEnunciado.Margin = new Padding(3, 4, 3, 4);
            imagenEnunciado.Name = "imagenEnunciado";
            imagenEnunciado.Size = new Size(679, 288);
            imagenEnunciado.TabIndex = 33;
            imagenEnunciado.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tipoEnunciado);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cursoSeleccion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(NombreEnunciado);
            panel1.Controls.Add(categoria);
            panel1.Controls.Add(idEnunciado);
            panel1.Location = new Point(232, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 131);
            panel1.TabIndex = 44;
            // 
            // tipoEnunciado
            // 
            tipoEnunciado.FormattingEnabled = true;
            tipoEnunciado.Items.AddRange(new object[] { "Texto", "Texto e imagen", "Avanzado", "Avanzado e imagen" });
            tipoEnunciado.Location = new Point(150, 92);
            tipoEnunciado.Name = "tipoEnunciado";
            tipoEnunciado.Size = new Size(188, 28);
            tipoEnunciado.TabIndex = 46;
            tipoEnunciado.SelectedIndexChanged += tipoEnunciado_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 95);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 45;
            label7.Text = "Tipo de enunciado";
            // 
            // cambiarBDD
            // 
            cambiarBDD.Location = new Point(12, 733);
            cambiarBDD.Margin = new Padding(3, 4, 3, 4);
            cambiarBDD.Name = "cambiarBDD";
            cambiarBDD.Size = new Size(206, 33);
            cambiarBDD.TabIndex = 45;
            cambiarBDD.Text = "Cambiar lista";
            cambiarBDD.UseVisualStyleBackColor = true;
            cambiarBDD.Click += cambiarBDD_Click;
            // 
            // crearLista
            // 
            crearLista.Location = new Point(12, 771);
            crearLista.Margin = new Padding(3, 4, 3, 4);
            crearLista.Name = "crearLista";
            crearLista.Size = new Size(206, 33);
            crearLista.TabIndex = 46;
            crearLista.Text = "Crear lista";
            crearLista.UseVisualStyleBackColor = true;
            crearLista.Click += crearLista_Click;
            // 
            // listBoxEnunciados
            // 
            listBoxEnunciados.FormattingEnabled = true;
            listBoxEnunciados.Location = new Point(12, 21);
            listBoxEnunciados.Name = "listBoxEnunciados";
            listBoxEnunciados.Size = new Size(206, 544);
            listBoxEnunciados.TabIndex = 47;
            listBoxEnunciados.SelectedIndexChanged += listBoxEnunciados_SelectedIndexChanged;
            listBoxEnunciados.SelectedValueChanged += listBoxEnunciados_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 668);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 48;
            label4.Text = "Nombre de la lista:";
            // 
            // NombreLista
            // 
            NombreLista.Location = new Point(12, 691);
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
            resultadoEnunciado.Location = new Point(315, 695);
            resultadoEnunciado.Name = "resultadoEnunciado";
            resultadoEnunciado.Size = new Size(622, 27);
            resultadoEnunciado.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(530, 331);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 51;
            label8.Text = "Imagen (Opcional)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(230, 698);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 52;
            label9.Text = "Resultado";
            // 
            // AlterarBDD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 828);
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
        private ComboBox tipoEnunciado;
        private Label label7;
        private Label label3;
        private TextBox resultadoEnunciado2;
        private TextBox resultadoEnunciado;
        private Label label8;
        private Label label9;
    }
}