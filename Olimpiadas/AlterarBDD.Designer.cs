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
            nuevoEnunciado = new Button();
            borrarEnunciado = new Button();
            label1 = new Label();
            NombreEnunciado = new TextBox();
            label6 = new Label();
            textoEnunciado = new RichTextBox();
            VistaPrevia = new Button();
            abrirImagen = new Button();
            abrirAvanzado = new Button();
            imagenEnunciado = new PictureBox();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            SuspendLayout();
            // 
            // nuevoEnunciado
            // 
            nuevoEnunciado.Dock = DockStyle.Fill;
            nuevoEnunciado.Font = new Font("Segoe UI", 12F);
            nuevoEnunciado.Location = new Point(3, 609);
            nuevoEnunciado.Margin = new Padding(3, 4, 3, 4);
            nuevoEnunciado.Name = "nuevoEnunciado";
            nuevoEnunciado.Size = new Size(343, 42);
            nuevoEnunciado.TabIndex = 1;
            nuevoEnunciado.Text = "Nuevo enunciado";
            nuevoEnunciado.UseVisualStyleBackColor = true;
            nuevoEnunciado.Click += nuevoEnunciado_Click;
            // 
            // borrarEnunciado
            // 
            borrarEnunciado.Dock = DockStyle.Fill;
            borrarEnunciado.Font = new Font("Segoe UI", 12F);
            borrarEnunciado.Location = new Point(3, 659);
            borrarEnunciado.Margin = new Padding(3, 4, 3, 4);
            borrarEnunciado.Name = "borrarEnunciado";
            borrarEnunciado.Size = new Size(343, 42);
            borrarEnunciado.TabIndex = 2;
            borrarEnunciado.Text = "Eliminar seleccionado";
            borrarEnunciado.UseVisualStyleBackColor = true;
            borrarEnunciado.Click += borrarEnunciado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(995, 34);
            label1.TabIndex = 3;
            label1.Text = "Nombre enunciado";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // NombreEnunciado
            // 
            NombreEnunciado.Dock = DockStyle.Fill;
            NombreEnunciado.Enabled = false;
            NombreEnunciado.Font = new Font("Segoe UI", 13.8F);
            NombreEnunciado.Location = new Point(3, 38);
            NombreEnunciado.Margin = new Padding(3, 4, 3, 4);
            NombreEnunciado.Name = "NombreEnunciado";
            NombreEnunciado.Size = new Size(995, 38);
            NombreEnunciado.TabIndex = 4;
            NombreEnunciado.TextChanged += NombreEnunciado_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(494, 50);
            label6.TabIndex = 14;
            label6.Text = "Enunciado";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textoEnunciado
            // 
            textoEnunciado.Dock = DockStyle.Fill;
            textoEnunciado.Enabled = false;
            textoEnunciado.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textoEnunciado.Location = new Point(3, 54);
            textoEnunciado.Margin = new Padding(3, 4, 3, 4);
            textoEnunciado.Name = "textoEnunciado";
            textoEnunciado.Size = new Size(494, 553);
            textoEnunciado.TabIndex = 15;
            textoEnunciado.Text = "";
            textoEnunciado.TextChanged += textoEnunciado_TextChanged;
            // 
            // VistaPrevia
            // 
            VistaPrevia.Dock = DockStyle.Fill;
            VistaPrevia.Enabled = false;
            VistaPrevia.Font = new Font("Segoe UI", 12F);
            VistaPrevia.ImageAlign = ContentAlignment.MiddleRight;
            VistaPrevia.Location = new Point(3, 54);
            VistaPrevia.Margin = new Padding(3, 4, 3, 4);
            VistaPrevia.Name = "VistaPrevia";
            VistaPrevia.Size = new Size(995, 43);
            VistaPrevia.TabIndex = 27;
            VistaPrevia.Text = "Vista Previa";
            VistaPrevia.UseVisualStyleBackColor = true;
            VistaPrevia.Click += actualizarEnunciado_Click;
            // 
            // abrirImagen
            // 
            abrirImagen.Dock = DockStyle.Fill;
            abrirImagen.Enabled = false;
            abrirImagen.Font = new Font("Microsoft Sans Serif", 12F);
            abrirImagen.Location = new Point(503, 615);
            abrirImagen.Margin = new Padding(3, 4, 3, 4);
            abrirImagen.Name = "abrirImagen";
            abrirImagen.Size = new Size(495, 45);
            abrirImagen.TabIndex = 31;
            abrirImagen.Text = "Cargar Imagen";
            abrirImagen.UseVisualStyleBackColor = true;
            abrirImagen.Click += abrirImagen_Click;
            // 
            // abrirAvanzado
            // 
            abrirAvanzado.AutoSize = true;
            abrirAvanzado.Dock = DockStyle.Fill;
            abrirAvanzado.Enabled = false;
            abrirAvanzado.Font = new Font("Segoe UI", 12F);
            abrirAvanzado.Location = new Point(3, 4);
            abrirAvanzado.Margin = new Padding(3, 4, 3, 4);
            abrirAvanzado.Name = "abrirAvanzado";
            abrirAvanzado.Size = new Size(995, 42);
            abrirAvanzado.TabIndex = 35;
            abrirAvanzado.Text = "Editar enunciado avanzado";
            abrirAvanzado.UseVisualStyleBackColor = true;
            abrirAvanzado.Click += button5_Click;
            // 
            // imagenEnunciado
            // 
            imagenEnunciado.Dock = DockStyle.Fill;
            imagenEnunciado.Location = new Point(503, 54);
            imagenEnunciado.Margin = new Padding(3, 4, 3, 4);
            imagenEnunciado.Name = "imagenEnunciado";
            imagenEnunciado.Size = new Size(495, 553);
            imagenEnunciado.TabIndex = 33;
            imagenEnunciado.TabStop = false;
            // 
            // cambiarBDD
            // 
            cambiarBDD.Dock = DockStyle.Fill;
            cambiarBDD.Font = new Font("Segoe UI", 12F);
            cambiarBDD.Location = new Point(3, 4);
            cambiarBDD.Margin = new Padding(3, 4, 3, 4);
            cambiarBDD.Name = "cambiarBDD";
            cambiarBDD.Size = new Size(168, 38);
            cambiarBDD.TabIndex = 45;
            cambiarBDD.Text = "Cambiar lista";
            cambiarBDD.UseVisualStyleBackColor = true;
            cambiarBDD.Click += cambiarBDD_Click;
            // 
            // crearLista
            // 
            crearLista.Dock = DockStyle.Fill;
            crearLista.Font = new Font("Segoe UI", 12F);
            crearLista.Location = new Point(177, 4);
            crearLista.Margin = new Padding(3, 4, 3, 4);
            crearLista.Name = "crearLista";
            crearLista.Size = new Size(169, 38);
            crearLista.TabIndex = 46;
            crearLista.Text = "Crear lista";
            crearLista.UseVisualStyleBackColor = true;
            crearLista.Click += crearLista_Click;
            // 
            // listBoxEnunciados
            // 
            listBoxEnunciados.Dock = DockStyle.Fill;
            listBoxEnunciados.Enabled = false;
            listBoxEnunciados.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxEnunciados.FormattingEnabled = true;
            listBoxEnunciados.ItemHeight = 31;
            listBoxEnunciados.Location = new Point(3, 36);
            listBoxEnunciados.Name = "listBoxEnunciados";
            listBoxEnunciados.Size = new Size(343, 566);
            listBoxEnunciados.TabIndex = 47;
            listBoxEnunciados.SelectedIndexChanged += listBoxEnunciados_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(349, 39);
            label4.TabIndex = 48;
            label4.Text = "Nombre de la lista:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NombreLista
            // 
            NombreLista.Dock = DockStyle.Fill;
            NombreLista.Font = new Font("Segoe UI", 14F);
            NombreLista.Location = new Point(3, 42);
            NombreLista.Name = "NombreLista";
            NombreLista.ReadOnly = true;
            NombreLista.Size = new Size(349, 39);
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
            resultadoEnunciado.Dock = DockStyle.Fill;
            resultadoEnunciado.Enabled = false;
            resultadoEnunciado.Font = new Font("Segoe UI", 14F);
            resultadoEnunciado.Location = new Point(161, 3);
            resultadoEnunciado.Name = "resultadoEnunciado";
            resultadoEnunciado.Size = new Size(330, 39);
            resultadoEnunciado.TabIndex = 50;
            resultadoEnunciado.TextChanged += resultadoEnunciado_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(503, 0);
            label8.Name = "label8";
            label8.Size = new Size(495, 50);
            label8.TabIndex = 51;
            label8.Text = "Imagen (Opcional)";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(152, 47);
            label9.TabIndex = 52;
            label9.Text = "Resultado";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(343, 33);
            label7.TabIndex = 53;
            label7.Text = "Lista de Enunciados";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3213539F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.67865F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.1027145F));
            tableLayoutPanel1.Size = new Size(1374, 871);
            tableLayoutPanel1.TabIndex = 54;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(NombreLista, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel9, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.2352943F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.7647057F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 710F));
            tableLayoutPanel2.Size = new Size(355, 865);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(crearLista, 1, 0);
            tableLayoutPanel3.Controls.Add(cambiarBDD, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 105);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(349, 46);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(borrarEnunciado, 0, 3);
            tableLayoutPanel9.Controls.Add(nuevoEnunciado, 0, 2);
            tableLayoutPanel9.Controls.Add(listBoxEnunciados, 0, 1);
            tableLayoutPanel9.Controls.Add(label7, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 157);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 5.4545455F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 94.5454559F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel9.Size = new Size(349, 705);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(364, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 670F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel4.Size = new Size(1007, 865);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(VistaPrevia, 0, 1);
            tableLayoutPanel8.Controls.Add(abrirAvanzado, 0, 0);
            tableLayoutPanel8.Location = new Point(3, 761);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(1001, 101);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6169968F));
            tableLayoutPanel10.Controls.Add(label1, 0, 0);
            tableLayoutPanel10.Controls.Add(NombreEnunciado, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel10.Size = new Size(1001, 82);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(textoEnunciado, 0, 1);
            tableLayoutPanel7.Controls.Add(label8, 1, 0);
            tableLayoutPanel7.Controls.Add(imagenEnunciado, 1, 1);
            tableLayoutPanel7.Controls.Add(abrirImagen, 1, 2);
            tableLayoutPanel7.Controls.Add(label6, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel11, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 91);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 8.185054F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 91.81495F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel7.Size = new Size(1001, 664);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1839066F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.81609F));
            tableLayoutPanel11.Controls.Add(label9, 0, 0);
            tableLayoutPanel11.Controls.Add(resultadoEnunciado, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 614);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(494, 47);
            tableLayoutPanel11.TabIndex = 52;
            // 
            // AlterarBDD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 871);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AlterarBDD";
            Text = "AlterarBDD";
            FormClosed += AlterarBDD_FormClosed;
            Load += AlterarBDD_Load;
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button nuevoEnunciado;
        private Button borrarEnunciado;
        private Label label1;
        private TextBox NombreEnunciado;
        private Label label6;
        private RichTextBox textoEnunciado;
        private Button VistaPrevia;
        private Button abrirImagen;
        private Button abrirAvanzado;
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
    }
}