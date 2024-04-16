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
            label11 = new Label();
            resultadoImagen = new TextBox();
            abrirImagen = new Button();
            abrirAvanzado = new Button();
            resultadoEnunciado = new TextBox();
            label3 = new Label();
            label5 = new Label();
            cursoSeleccion = new ComboBox();
            listaEnunciados2 = new ComboBox();
            splitContainer1 = new SplitContainer();
            imagenEnunciado = new PictureBox();
            imagenTexto = new RichTextBox();
            panel1 = new Panel();
            tipoEnunciado = new ComboBox();
            label7 = new Label();
            cambiarBDD = new Button();
            crearLista = new Button();
            listBoxEnunciados = new ListBox();
            label4 = new Label();
            NombreLista = new TextBox();
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
            nuevoEnunciado.Location = new Point(5, 550);
            nuevoEnunciado.Margin = new Padding(3, 4, 3, 4);
            nuevoEnunciado.Name = "nuevoEnunciado";
            nuevoEnunciado.Size = new Size(219, 33);
            nuevoEnunciado.TabIndex = 1;
            nuevoEnunciado.Text = "Nuevo";
            nuevoEnunciado.UseVisualStyleBackColor = true;
            nuevoEnunciado.Click += nuevoEnunciado_Click;
            // 
            // borrarEnunciado
            // 
            borrarEnunciado.Location = new Point(5, 592);
            borrarEnunciado.Margin = new Padding(3, 4, 3, 4);
            borrarEnunciado.Name = "borrarEnunciado";
            borrarEnunciado.Size = new Size(219, 33);
            borrarEnunciado.TabIndex = 2;
            borrarEnunciado.Text = "Eliminar";
            borrarEnunciado.UseVisualStyleBackColor = true;
            borrarEnunciado.Click += borrarEnunciado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
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
            NombreEnunciado.Size = new Size(727, 27);
            NombreEnunciado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 55);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Categoría";
            // 
            // categoria
            // 
            categoria.FormattingEnabled = true;
            categoria.Items.AddRange(new object[] { "Algebra", "Geometría", "Estadística", "Probabilidades" });
            categoria.Location = new Point(432, 51);
            categoria.Margin = new Padding(3, 4, 3, 4);
            categoria.Name = "categoria";
            categoria.Size = new Size(277, 28);
            categoria.TabIndex = 6;
            categoria.SelectedIndexChanged += categoria_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 8);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 14;
            label6.Text = "Enunciado";
            // 
            // textoEnunciado
            // 
            textoEnunciado.Location = new Point(91, 8);
            textoEnunciado.Margin = new Padding(3, 4, 3, 4);
            textoEnunciado.Name = "textoEnunciado";
            textoEnunciado.Size = new Size(329, 535);
            textoEnunciado.TabIndex = 15;
            textoEnunciado.Text = "";
            // 
            // idEnunciado
            // 
            idEnunciado.Location = new Point(749, 51);
            idEnunciado.Margin = new Padding(3, 4, 3, 4);
            idEnunciado.Name = "idEnunciado";
            idEnunciado.Size = new Size(127, 27);
            idEnunciado.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(721, 55);
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
            actualizarEnunciado.Size = new Size(881, 33);
            actualizarEnunciado.TabIndex = 27;
            actualizarEnunciado.Text = "Actualizar";
            actualizarEnunciado.UseVisualStyleBackColor = true;
            actualizarEnunciado.Click += actualizarEnunciado_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 125);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 29;
            label11.Text = "Resultado";
            // 
            // resultadoImagen
            // 
            resultadoImagen.Enabled = false;
            resultadoImagen.Location = new Point(73, 121);
            resultadoImagen.Margin = new Padding(3, 4, 3, 4);
            resultadoImagen.Name = "resultadoImagen";
            resultadoImagen.Size = new Size(375, 27);
            resultadoImagen.TabIndex = 30;
            // 
            // abrirImagen
            // 
            abrirImagen.Enabled = false;
            abrirImagen.Location = new Point(3, 160);
            abrirImagen.Margin = new Padding(3, 4, 3, 4);
            abrirImagen.Name = "abrirImagen";
            abrirImagen.Size = new Size(446, 31);
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
            abrirAvanzado.Size = new Size(881, 33);
            abrirAvanzado.TabIndex = 35;
            abrirAvanzado.Text = "Editar enunciado avanzado";
            abrirAvanzado.UseVisualStyleBackColor = true;
            abrirAvanzado.Click += button5_Click;
            // 
            // resultadoEnunciado
            // 
            resultadoEnunciado.Location = new Point(91, 552);
            resultadoEnunciado.Margin = new Padding(3, 4, 3, 4);
            resultadoEnunciado.Name = "resultadoEnunciado";
            resultadoEnunciado.Size = new Size(329, 27);
            resultadoEnunciado.TabIndex = 36;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 57);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 40;
            label5.Text = "Curso";
            // 
            // cursoSeleccion
            // 
            cursoSeleccion.FormattingEnabled = true;
            cursoSeleccion.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cursoSeleccion.Location = new Point(67, 51);
            cursoSeleccion.Margin = new Padding(3, 4, 3, 4);
            cursoSeleccion.Name = "cursoSeleccion";
            cursoSeleccion.Size = new Size(277, 28);
            cursoSeleccion.TabIndex = 41;
            cursoSeleccion.SelectedIndexChanged += cursoSeleccion_SelectedIndexChanged;
            // 
            // listaEnunciados2
            // 
            listaEnunciados2.FormattingEnabled = true;
            listaEnunciados2.Location = new Point(7, 16);
            listaEnunciados2.Margin = new Padding(3, 4, 3, 4);
            listaEnunciados2.Name = "listaEnunciados2";
            listaEnunciados2.Size = new Size(217, 28);
            listaEnunciados2.TabIndex = 3;
            listaEnunciados2.Text = "Seleccione enunciado";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(230, 139);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
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
            splitContainer1.Size = new Size(881, 587);
            splitContainer1.SplitterDistance = 423;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 43;
            // 
            // imagenEnunciado
            // 
            imagenEnunciado.Location = new Point(3, 199);
            imagenEnunciado.Margin = new Padding(3, 4, 3, 4);
            imagenEnunciado.Name = "imagenEnunciado";
            imagenEnunciado.Size = new Size(446, 384);
            imagenEnunciado.TabIndex = 33;
            imagenEnunciado.TabStop = false;
            // 
            // imagenTexto
            // 
            imagenTexto.Enabled = false;
            imagenTexto.Location = new Point(3, 8);
            imagenTexto.Margin = new Padding(3, 4, 3, 4);
            imagenTexto.Name = "imagenTexto";
            imagenTexto.Size = new Size(445, 104);
            imagenTexto.TabIndex = 32;
            imagenTexto.Text = "";
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
            panel1.Location = new Point(230, 8);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 131);
            panel1.TabIndex = 44;
            // 
            // tipoEnunciado
            // 
            tipoEnunciado.FormattingEnabled = true;
            tipoEnunciado.Items.AddRange(new object[] { "Texto", "Texto e imágenes", "Avanzado" });
            tipoEnunciado.Location = new Point(156, 92);
            tipoEnunciado.Name = "tipoEnunciado";
            tipoEnunciado.Size = new Size(188, 28);
            tipoEnunciado.TabIndex = 46;
            tipoEnunciado.SelectedIndexChanged += tipoEnunciado_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 95);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 45;
            label7.Text = "Tipo de enunciado";
            // 
            // cambiarBDD
            // 
            cambiarBDD.Location = new Point(5, 733);
            cambiarBDD.Margin = new Padding(3, 4, 3, 4);
            cambiarBDD.Name = "cambiarBDD";
            cambiarBDD.Size = new Size(219, 33);
            cambiarBDD.TabIndex = 45;
            cambiarBDD.Text = "Cambiar lista";
            cambiarBDD.UseVisualStyleBackColor = true;
            cambiarBDD.Click += cambiarBDD_Click;
            // 
            // crearLista
            // 
            crearLista.Location = new Point(5, 771);
            crearLista.Margin = new Padding(3, 4, 3, 4);
            crearLista.Name = "crearLista";
            crearLista.Size = new Size(219, 33);
            crearLista.TabIndex = 46;
            crearLista.Text = "Crear lista";
            crearLista.UseVisualStyleBackColor = true;
            crearLista.Click += crearLista_Click;
            // 
            // listBoxEnunciados
            // 
            listBoxEnunciados.FormattingEnabled = true;
            listBoxEnunciados.Location = new Point(5, 59);
            listBoxEnunciados.Name = "listBoxEnunciados";
            listBoxEnunciados.Size = new Size(217, 484);
            listBoxEnunciados.TabIndex = 47;
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
            // AlterarBDD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 828);
            Controls.Add(NombreLista);
            Controls.Add(label4);
            Controls.Add(listBoxEnunciados);
            Controls.Add(listaEnunciados2);
            Controls.Add(cambiarBDD);
            Controls.Add(nuevoEnunciado);
            Controls.Add(borrarEnunciado);
            Controls.Add(abrirAvanzado);
            Controls.Add(crearLista);
            Controls.Add(actualizarEnunciado);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AlterarBDD";
            Text = "AlterarBDD";
            FormClosed += AlterarBDD_FormClosed;
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
        private Label label5;
        private ComboBox cursoSeleccion;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private RichTextBox imagenTexto;
        private PictureBox imagenEnunciado;
        private Button cambiarBDD;
        private Button crearLista;
        private ComboBox listaEnunciados2;
        private ListBox listBoxEnunciados;
        private Label label4;
        private TextBox NombreLista;
        private ComboBox tipoEnunciado;
        private Label label7;
    }
}