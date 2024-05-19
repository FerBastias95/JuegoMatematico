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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarBDD));
            nuevoEnunciado = new Button();
            borrarEnunciado = new Button();
            cambiarBDD = new Button();
            crearLista = new Button();
            listBoxEnunciados = new ListBox();
            NombreLista = new TextBox();
            label3 = new Label();
            resultadoEnunciado2 = new TextBox();
            abrirAvanzado = new Button();
            VistaPrevia = new Button();
            textoEnunciado = new RichTextBox();
            abrirImagen = new Button();
            resultadoEnunciado = new TextBox();
            NombreEnunciado = new TextBox();
            imagenEnunciado = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).BeginInit();
            SuspendLayout();
            // 
            // nuevoEnunciado
            // 
            nuevoEnunciado.BackColor = Color.FromArgb(245, 203, 0);
            nuevoEnunciado.FlatStyle = FlatStyle.Flat;
            nuevoEnunciado.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nuevoEnunciado.Location = new Point(36, 794);
            nuevoEnunciado.Margin = new Padding(4, 6, 4, 6);
            nuevoEnunciado.Name = "nuevoEnunciado";
            nuevoEnunciado.Size = new Size(466, 55);
            nuevoEnunciado.TabIndex = 1;
            nuevoEnunciado.Text = "Nuevo enunciado";
            nuevoEnunciado.UseVisualStyleBackColor = false;
            nuevoEnunciado.Click += nuevoEnunciado_Click;
            // 
            // borrarEnunciado
            // 
            borrarEnunciado.BackColor = Color.FromArgb(245, 203, 0);
            borrarEnunciado.FlatStyle = FlatStyle.Flat;
            borrarEnunciado.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrarEnunciado.Location = new Point(36, 861);
            borrarEnunciado.Margin = new Padding(4, 6, 4, 6);
            borrarEnunciado.Name = "borrarEnunciado";
            borrarEnunciado.Size = new Size(466, 55);
            borrarEnunciado.TabIndex = 2;
            borrarEnunciado.Text = "Eliminar seleccionado";
            borrarEnunciado.UseVisualStyleBackColor = false;
            borrarEnunciado.Click += borrarEnunciado_Click;
            // 
            // cambiarBDD
            // 
            cambiarBDD.BackColor = SystemColors.GradientInactiveCaption;
            cambiarBDD.FlatStyle = FlatStyle.Popup;
            cambiarBDD.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            cambiarBDD.Location = new Point(36, 141);
            cambiarBDD.Margin = new Padding(4, 6, 4, 6);
            cambiarBDD.Name = "cambiarBDD";
            cambiarBDD.Size = new Size(223, 62);
            cambiarBDD.TabIndex = 45;
            cambiarBDD.Text = "Cambiar lista";
            cambiarBDD.UseVisualStyleBackColor = false;
            cambiarBDD.Click += cambiarBDD_Click;
            // 
            // crearLista
            // 
            crearLista.BackColor = SystemColors.GradientInactiveCaption;
            crearLista.FlatStyle = FlatStyle.Popup;
            crearLista.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic);
            crearLista.Location = new Point(267, 141);
            crearLista.Margin = new Padding(4, 6, 4, 6);
            crearLista.Name = "crearLista";
            crearLista.Size = new Size(235, 62);
            crearLista.TabIndex = 46;
            crearLista.Text = "Crear lista";
            crearLista.UseVisualStyleBackColor = false;
            crearLista.Click += crearLista_Click;
            // 
            // listBoxEnunciados
            // 
            listBoxEnunciados.BackColor = SystemColors.GradientInactiveCaption;
            listBoxEnunciados.Enabled = false;
            listBoxEnunciados.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxEnunciados.FormattingEnabled = true;
            listBoxEnunciados.ItemHeight = 51;
            listBoxEnunciados.Location = new Point(36, 311);
            listBoxEnunciados.Margin = new Padding(4);
            listBoxEnunciados.Name = "listBoxEnunciados";
            listBoxEnunciados.Size = new Size(466, 463);
            listBoxEnunciados.TabIndex = 47;
            listBoxEnunciados.SelectedIndexChanged += listBoxEnunciados_SelectedIndexChanged;
            // 
            // NombreLista
            // 
            NombreLista.BackColor = SystemColors.GradientInactiveCaption;
            NombreLista.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NombreLista.Location = new Point(36, 80);
            NombreLista.Margin = new Padding(4);
            NombreLista.Name = "NombreLista";
            NombreLista.ReadOnly = true;
            NombreLista.Size = new Size(466, 42);
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
            resultadoEnunciado2.Size = new Size(100, 35);
            resultadoEnunciado2.TabIndex = 36;
            // 
            // abrirAvanzado
            // 
            abrirAvanzado.AutoSize = true;
            abrirAvanzado.BackColor = Color.FromArgb(164, 114, 214);
            abrirAvanzado.Enabled = false;
            abrirAvanzado.FlatStyle = FlatStyle.Flat;
            abrirAvanzado.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            abrirAvanzado.Location = new Point(551, 794);
            abrirAvanzado.Margin = new Padding(4, 6, 4, 6);
            abrirAvanzado.Name = "abrirAvanzado";
            abrirAvanzado.Size = new Size(1286, 55);
            abrirAvanzado.TabIndex = 35;
            abrirAvanzado.Text = "Editar enunciado avanzado";
            abrirAvanzado.UseVisualStyleBackColor = false;
            abrirAvanzado.Click += button5_Click;
            // 
            // VistaPrevia
            // 
            VistaPrevia.BackColor = Color.FromArgb(164, 114, 214);
            VistaPrevia.Enabled = false;
            VistaPrevia.FlatStyle = FlatStyle.Flat;
            VistaPrevia.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            VistaPrevia.ImageAlign = ContentAlignment.MiddleRight;
            VistaPrevia.Location = new Point(551, 861);
            VistaPrevia.Margin = new Padding(4, 6, 4, 6);
            VistaPrevia.Name = "VistaPrevia";
            VistaPrevia.Size = new Size(1286, 55);
            VistaPrevia.TabIndex = 27;
            VistaPrevia.Text = "Vista Previa";
            VistaPrevia.UseVisualStyleBackColor = false;
            VistaPrevia.Click += actualizarEnunciado_Click;
            // 
            // textoEnunciado
            // 
            textoEnunciado.BackColor = Color.MistyRose;
            textoEnunciado.Enabled = false;
            textoEnunciado.Font = new Font("Century Gothic", 14.1428576F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textoEnunciado.Location = new Point(569, 141);
            textoEnunciado.Margin = new Padding(4, 6, 4, 6);
            textoEnunciado.Name = "textoEnunciado";
            textoEnunciado.Size = new Size(611, 518);
            textoEnunciado.TabIndex = 15;
            textoEnunciado.Text = "";
            textoEnunciado.TextChanged += textoEnunciado_TextChanged;
            // 
            // abrirImagen
            // 
            abrirImagen.BackColor = SystemColors.GradientInactiveCaption;
            abrirImagen.Enabled = false;
            abrirImagen.FlatStyle = FlatStyle.Flat;
            abrirImagen.Font = new Font("Century Gothic", 14.1428576F, FontStyle.Bold);
            abrirImagen.Location = new Point(1228, 690);
            abrirImagen.Margin = new Padding(4, 6, 4, 6);
            abrirImagen.Name = "abrirImagen";
            abrirImagen.Size = new Size(596, 61);
            abrirImagen.TabIndex = 31;
            abrirImagen.Text = "Cargar Imagen";
            abrirImagen.UseVisualStyleBackColor = false;
            abrirImagen.Click += abrirImagen_Click;
            // 
            // resultadoEnunciado
            // 
            resultadoEnunciado.BackColor = Color.MistyRose;
            resultadoEnunciado.Enabled = false;
            resultadoEnunciado.Font = new Font("Century Gothic", 15.8571434F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            resultadoEnunciado.Location = new Point(784, 692);
            resultadoEnunciado.Margin = new Padding(4);
            resultadoEnunciado.Name = "resultadoEnunciado";
            resultadoEnunciado.Size = new Size(396, 53);
            resultadoEnunciado.TabIndex = 50;
            resultadoEnunciado.TextChanged += resultadoEnunciado_TextChanged;
            // 
            // NombreEnunciado
            // 
            NombreEnunciado.BackColor = Color.MistyRose;
            NombreEnunciado.Enabled = false;
            NombreEnunciado.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NombreEnunciado.Location = new Point(940, 28);
            NombreEnunciado.Margin = new Padding(4, 6, 4, 6);
            NombreEnunciado.Name = "NombreEnunciado";
            NombreEnunciado.Size = new Size(897, 42);
            NombreEnunciado.TabIndex = 4;
            // 
            // imagenEnunciado
            // 
            imagenEnunciado.BackColor = Color.MistyRose;
            imagenEnunciado.Location = new Point(1228, 141);
            imagenEnunciado.Name = "imagenEnunciado";
            imagenEnunciado.Size = new Size(596, 518);
            imagenEnunciado.TabIndex = 51;
            imagenEnunciado.TabStop = false;
            // 
            // AlterarBDD
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1870, 942);
            Controls.Add(imagenEnunciado);
            Controls.Add(crearLista);
            Controls.Add(textoEnunciado);
            Controls.Add(cambiarBDD);
            Controls.Add(NombreEnunciado);
            Controls.Add(NombreLista);
            Controls.Add(VistaPrevia);
            Controls.Add(resultadoEnunciado);
            Controls.Add(abrirAvanzado);
            Controls.Add(abrirImagen);
            Controls.Add(borrarEnunciado);
            Controls.Add(listBoxEnunciados);
            Controls.Add(nuevoEnunciado);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            Name = "AlterarBDD";
            Text = "AlterarBDD";
            FormClosed += AlterarBDD_FormClosed;
            Load += AlterarBDD_Load;
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button nuevoEnunciado;
        private Button borrarEnunciado;
        private Button cambiarBDD;
        private Button crearLista;
        private ListBox listBoxEnunciados;
        private TextBox NombreLista;
        private Label label3;
        private TextBox resultadoEnunciado2;
        private Button abrirAvanzado;
        private Button VistaPrevia;
        private RichTextBox textoEnunciado;
        private Button abrirImagen;
        private TextBox resultadoEnunciado;
        private TextBox NombreEnunciado;
        private PictureBox imagenEnunciado;
    }
}