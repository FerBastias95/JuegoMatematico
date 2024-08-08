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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarBDD));
            nuevoEnunciado = new Button();
            borrarEnunciado = new Button();
            listBoxEnunciados = new ListBox();
            NombreLista = new TextBox();
            label3 = new Label();
            resultadoEnunciado2 = new TextBox();
            textoEnunciado = new RichTextBox();
            resultadoEnunciado = new TextBox();
            NombreEnunciado = new TextBox();
            imagenEnunciado = new PictureBox();
            abrirAvanzado = new ReaLTaiizor.Controls.HopeButton();
            VistaPrevia = new ReaLTaiizor.Controls.HopeButton();
            crearLista = new ReaLTaiizor.Controls.Button();
            cambiarBDD = new ReaLTaiizor.Controls.Button();
            abrirImagen = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).BeginInit();
            SuspendLayout();
            // 
            // nuevoEnunciado
            // 
            nuevoEnunciado.BackColor = Color.FromArgb(245, 203, 0);
            nuevoEnunciado.FlatStyle = FlatStyle.Flat;
            nuevoEnunciado.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nuevoEnunciado.Location = new Point(21, 475);
            nuevoEnunciado.Name = "nuevoEnunciado";
            nuevoEnunciado.Size = new Size(274, 28);
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
            borrarEnunciado.Location = new Point(21, 515);
            borrarEnunciado.Name = "borrarEnunciado";
            borrarEnunciado.Size = new Size(274, 28);
            borrarEnunciado.TabIndex = 2;
            borrarEnunciado.Text = "Eliminar seleccionado";
            borrarEnunciado.UseVisualStyleBackColor = false;
            borrarEnunciado.Click += borrarEnunciado_Click;
            // 
            // listBoxEnunciados
            // 
            listBoxEnunciados.BackColor = SystemColors.GradientInactiveCaption;
            listBoxEnunciados.Enabled = false;
            listBoxEnunciados.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxEnunciados.FormattingEnabled = true;
            listBoxEnunciados.ItemHeight = 30;
            listBoxEnunciados.Location = new Point(21, 155);
            listBoxEnunciados.Margin = new Padding(3, 2, 3, 2);
            listBoxEnunciados.Name = "listBoxEnunciados";
            listBoxEnunciados.Size = new Size(274, 304);
            listBoxEnunciados.TabIndex = 47;
            listBoxEnunciados.SelectedIndexChanged += listBoxEnunciados_SelectedIndexChanged;
            // 
            // NombreLista
            // 
            NombreLista.BackColor = SystemColors.GradientInactiveCaption;
            NombreLista.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NombreLista.Location = new Point(21, 42);
            NombreLista.Margin = new Padding(3, 2, 3, 2);
            NombreLista.Name = "NombreLista";
            NombreLista.ReadOnly = true;
            NombreLista.Size = new Size(274, 27);
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
            resultadoEnunciado2.Size = new Size(100, 23);
            resultadoEnunciado2.TabIndex = 36;
            // 
            // textoEnunciado
            // 
            textoEnunciado.BackColor = Color.MistyRose;
            textoEnunciado.Enabled = false;
            textoEnunciado.Font = new Font("Century Gothic", 14.1428576F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textoEnunciado.Location = new Point(331, 85);
            textoEnunciado.Name = "textoEnunciado";
            textoEnunciado.RightToLeft = RightToLeft.No;
            textoEnunciado.Size = new Size(358, 309);
            textoEnunciado.TabIndex = 15;
            textoEnunciado.Text = "";
            textoEnunciado.TextChanged += textoEnunciado_TextChanged;
            // 
            // resultadoEnunciado
            // 
            resultadoEnunciado.BackColor = Color.MistyRose;
            resultadoEnunciado.Enabled = false;
            resultadoEnunciado.Font = new Font("Century Gothic", 15.8571434F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            resultadoEnunciado.Location = new Point(458, 413);
            resultadoEnunciado.Margin = new Padding(3, 2, 3, 2);
            resultadoEnunciado.Name = "resultadoEnunciado";
            resultadoEnunciado.Size = new Size(232, 33);
            resultadoEnunciado.TabIndex = 50;
            resultadoEnunciado.TextChanged += resultadoEnunciado_TextChanged;
            // 
            // NombreEnunciado
            // 
            NombreEnunciado.BackColor = Color.MistyRose;
            NombreEnunciado.Enabled = false;
            NombreEnunciado.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NombreEnunciado.Location = new Point(547, 15);
            NombreEnunciado.Name = "NombreEnunciado";
            NombreEnunciado.Size = new Size(525, 27);
            NombreEnunciado.TabIndex = 4;
            NombreEnunciado.TextChanged += NombreEnunciado_TextChanged;
            // 
            // imagenEnunciado
            // 
            imagenEnunciado.BackColor = Color.MistyRose;
            imagenEnunciado.Location = new Point(712, 85);
            imagenEnunciado.Margin = new Padding(2);
            imagenEnunciado.Name = "imagenEnunciado";
            imagenEnunciado.Size = new Size(360, 309);
            imagenEnunciado.TabIndex = 51;
            imagenEnunciado.TabStop = false;
            // 
            // abrirAvanzado
            // 
            abrirAvanzado.BorderColor = Color.Transparent;
            abrirAvanzado.ButtonType = ReaLTaiizor.Util.HopeButtonType.Warning;
            abrirAvanzado.DangerColor = Color.FromArgb(245, 108, 108);
            abrirAvanzado.DefaultColor = Color.FromArgb(255, 255, 255);
            abrirAvanzado.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            abrirAvanzado.HoverTextColor = Color.FromArgb(48, 49, 51);
            abrirAvanzado.InfoColor = Color.FromArgb(144, 147, 153);
            abrirAvanzado.Location = new Point(321, 475);
            abrirAvanzado.Margin = new Padding(3, 2, 3, 2);
            abrirAvanzado.Name = "abrirAvanzado";
            abrirAvanzado.PrimaryColor = Color.FromArgb(64, 158, 255);
            abrirAvanzado.Size = new Size(758, 28);
            abrirAvanzado.SuccessColor = Color.FromArgb(103, 194, 58);
            abrirAvanzado.TabIndex = 52;
            abrirAvanzado.Text = "Editar enunciado avanzado";
            abrirAvanzado.TextColor = Color.White;
            abrirAvanzado.WarningColor = Color.FromArgb(230, 162, 60);
            abrirAvanzado.Click += abrirAvanzado_Click;
            // 
            // VistaPrevia
            // 
            VistaPrevia.BorderColor = Color.Transparent;
            VistaPrevia.ButtonType = ReaLTaiizor.Util.HopeButtonType.Warning;
            VistaPrevia.DangerColor = Color.FromArgb(245, 108, 108);
            VistaPrevia.DefaultColor = Color.FromArgb(255, 255, 255);
            VistaPrevia.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            VistaPrevia.HoverTextColor = Color.FromArgb(48, 49, 51);
            VistaPrevia.InfoColor = Color.FromArgb(144, 147, 153);
            VistaPrevia.Location = new Point(321, 515);
            VistaPrevia.Margin = new Padding(3, 2, 3, 2);
            VistaPrevia.Name = "VistaPrevia";
            VistaPrevia.PrimaryColor = Color.FromArgb(64, 158, 255);
            VistaPrevia.Size = new Size(758, 28);
            VistaPrevia.SuccessColor = Color.FromArgb(103, 194, 58);
            VistaPrevia.TabIndex = 53;
            VistaPrevia.Text = "Ver vista previa";
            VistaPrevia.TextColor = Color.White;
            VistaPrevia.WarningColor = Color.FromArgb(230, 162, 60);
            VistaPrevia.Click += VistaPrevia_Click;
            // 
            // crearLista
            // 
            crearLista.BackColor = Color.Transparent;
            crearLista.BorderColor = Color.Transparent;
            crearLista.EnteredBorderColor = Color.Transparent;
            crearLista.EnteredColor = SystemColors.GradientInactiveCaption;
            crearLista.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crearLista.Image = null;
            crearLista.ImageAlign = ContentAlignment.MiddleLeft;
            crearLista.InactiveColor = SystemColors.GradientActiveCaption;
            crearLista.Location = new Point(21, 80);
            crearLista.Margin = new Padding(3, 2, 3, 2);
            crearLista.Name = "crearLista";
            crearLista.PressedBorderColor = Color.Transparent;
            crearLista.PressedColor = SystemColors.GradientActiveCaption;
            crearLista.Size = new Size(131, 43);
            crearLista.TabIndex = 54;
            crearLista.Text = "Crear Lista";
            crearLista.TextAlignment = StringAlignment.Center;
            crearLista.Click += crearLista_Click;
            // 
            // cambiarBDD
            // 
            cambiarBDD.BackColor = Color.Transparent;
            cambiarBDD.BorderColor = Color.Transparent;
            cambiarBDD.EnteredBorderColor = Color.Transparent;
            cambiarBDD.EnteredColor = SystemColors.GradientInactiveCaption;
            cambiarBDD.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cambiarBDD.Image = null;
            cambiarBDD.ImageAlign = ContentAlignment.MiddleLeft;
            cambiarBDD.InactiveColor = SystemColors.GradientActiveCaption;
            cambiarBDD.Location = new Point(164, 80);
            cambiarBDD.Margin = new Padding(3, 2, 3, 2);
            cambiarBDD.Name = "cambiarBDD";
            cambiarBDD.PressedBorderColor = Color.Transparent;
            cambiarBDD.PressedColor = SystemColors.GradientActiveCaption;
            cambiarBDD.Size = new Size(131, 43);
            cambiarBDD.TabIndex = 55;
            cambiarBDD.Text = "Cambiar Lista";
            cambiarBDD.TextAlignment = StringAlignment.Center;
            cambiarBDD.Click += cambiarBDD_Click;
            // 
            // abrirImagen
            // 
            abrirImagen.BackColor = Color.Transparent;
            abrirImagen.BorderColor = Color.Transparent;
            abrirImagen.EnteredBorderColor = Color.Transparent;
            abrirImagen.EnteredColor = Color.FromArgb(255, 128, 128);
            abrirImagen.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            abrirImagen.Image = null;
            abrirImagen.ImageAlign = ContentAlignment.MiddleLeft;
            abrirImagen.InactiveColor = Color.FromArgb(255, 192, 192);
            abrirImagen.Location = new Point(711, 414);
            abrirImagen.Margin = new Padding(3, 2, 3, 2);
            abrirImagen.Name = "abrirImagen";
            abrirImagen.PressedBorderColor = Color.Transparent;
            abrirImagen.PressedColor = Color.Red;
            abrirImagen.Size = new Size(360, 30);
            abrirImagen.TabIndex = 57;
            abrirImagen.Text = "Abrir Imagen";
            abrirImagen.TextAlignment = StringAlignment.Center;
            abrirImagen.Click += abrirImagen_Click_1;
            // 
            // AlterarBDD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1091, 561);
            Controls.Add(abrirImagen);
            Controls.Add(cambiarBDD);
            Controls.Add(crearLista);
            Controls.Add(VistaPrevia);
            Controls.Add(abrirAvanzado);
            Controls.Add(imagenEnunciado);
            Controls.Add(textoEnunciado);
            Controls.Add(NombreEnunciado);
            Controls.Add(NombreLista);
            Controls.Add(resultadoEnunciado);
            Controls.Add(borrarEnunciado);
            Controls.Add(listBoxEnunciados);
            Controls.Add(nuevoEnunciado);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AlterarBDD";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ListBox listBoxEnunciados;
        private TextBox NombreLista;
        private Label label3;
        private TextBox resultadoEnunciado2;
        private RichTextBox textoEnunciado;
        private TextBox resultadoEnunciado;
        private TextBox NombreEnunciado;
        private PictureBox imagenEnunciado;
        private ReaLTaiizor.Controls.HopeButton abrirAvanzado;
        private ReaLTaiizor.Controls.HopeButton VistaPrevia;
        private ReaLTaiizor.Controls.Button crearLista;
        private ReaLTaiizor.Controls.Button cambiarBDD;
        private ReaLTaiizor.Controls.Button abrirImagen;
    }
}