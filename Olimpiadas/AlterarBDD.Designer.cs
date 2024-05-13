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
            cambiarBDD = new Button();
            crearLista = new Button();
            listBoxEnunciados = new ListBox();
            label4 = new Label();
            NombreLista = new TextBox();
            label3 = new Label();
            resultadoEnunciado2 = new TextBox();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            abrirAvanzado = new Button();
            VistaPrevia = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            textoEnunciado = new RichTextBox();
            label8 = new Label();
            imagenEnunciado = new PictureBox();
            abrirImagen = new Button();
            label6 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            label9 = new Label();
            resultadoEnunciado = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            NombreEnunciado = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).BeginInit();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // nuevoEnunciado
            // 
            nuevoEnunciado.BackColor = Color.FromArgb(245, 203, 0);
            nuevoEnunciado.Dock = DockStyle.Fill;
            nuevoEnunciado.FlatStyle = FlatStyle.Flat;
            nuevoEnunciado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            nuevoEnunciado.Location = new Point(3, 381);
            nuevoEnunciado.Margin = new Padding(3, 4, 3, 4);
            nuevoEnunciado.Name = "nuevoEnunciado";
            nuevoEnunciado.Size = new Size(334, 53);
            nuevoEnunciado.TabIndex = 1;
            nuevoEnunciado.Text = "Nuevo enunciado";
            nuevoEnunciado.UseVisualStyleBackColor = false;
            nuevoEnunciado.Click += nuevoEnunciado_Click;
            // 
            // borrarEnunciado
            // 
            borrarEnunciado.BackColor = Color.FromArgb(245, 203, 0);
            borrarEnunciado.Dock = DockStyle.Fill;
            borrarEnunciado.FlatStyle = FlatStyle.Flat;
            borrarEnunciado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            borrarEnunciado.Location = new Point(3, 442);
            borrarEnunciado.Margin = new Padding(3, 4, 3, 4);
            borrarEnunciado.Name = "borrarEnunciado";
            borrarEnunciado.Size = new Size(334, 54);
            borrarEnunciado.TabIndex = 2;
            borrarEnunciado.Text = "Eliminar seleccionado";
            borrarEnunciado.UseVisualStyleBackColor = false;
            borrarEnunciado.Click += borrarEnunciado_Click;
            // 
            // cambiarBDD
            // 
            cambiarBDD.BackColor = SystemColors.GradientInactiveCaption;
            cambiarBDD.Dock = DockStyle.Fill;
            cambiarBDD.FlatStyle = FlatStyle.Popup;
            cambiarBDD.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            cambiarBDD.Location = new Point(3, 4);
            cambiarBDD.Margin = new Padding(3, 4, 3, 4);
            cambiarBDD.Name = "cambiarBDD";
            cambiarBDD.Size = new Size(164, 48);
            cambiarBDD.TabIndex = 45;
            cambiarBDD.Text = "Cambiar lista";
            cambiarBDD.UseVisualStyleBackColor = false;
            cambiarBDD.Click += cambiarBDD_Click;
            // 
            // crearLista
            // 
            crearLista.BackColor = SystemColors.GradientInactiveCaption;
            crearLista.Dock = DockStyle.Fill;
            crearLista.FlatStyle = FlatStyle.Popup;
            crearLista.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            crearLista.Location = new Point(173, 4);
            crearLista.Margin = new Padding(3, 4, 3, 4);
            crearLista.Name = "crearLista";
            crearLista.Size = new Size(164, 48);
            crearLista.TabIndex = 46;
            crearLista.Text = "Crear lista";
            crearLista.UseVisualStyleBackColor = false;
            crearLista.Click += crearLista_Click;
            // 
            // listBoxEnunciados
            // 
            listBoxEnunciados.BackColor = SystemColors.GradientInactiveCaption;
            listBoxEnunciados.Dock = DockStyle.Fill;
            listBoxEnunciados.Enabled = false;
            listBoxEnunciados.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxEnunciados.FormattingEnabled = true;
            listBoxEnunciados.ItemHeight = 37;
            listBoxEnunciados.Location = new Point(3, 40);
            listBoxEnunciados.Name = "listBoxEnunciados";
            listBoxEnunciados.Size = new Size(334, 334);
            listBoxEnunciados.TabIndex = 47;
            listBoxEnunciados.SelectedIndexChanged += listBoxEnunciados_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(340, 37);
            label4.TabIndex = 48;
            label4.Text = "Nombre de la lista:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NombreLista
            // 
            NombreLista.BackColor = SystemColors.GradientInactiveCaption;
            NombreLista.Dock = DockStyle.Top;
            NombreLista.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreLista.Location = new Point(3, 53);
            NombreLista.Name = "NombreLista";
            NombreLista.ReadOnly = true;
            NombreLista.Size = new Size(340, 43);
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
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(334, 37);
            label7.TabIndex = 53;
            label7.Text = "Lista de Enunciados";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9602757F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.03973F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.8299866F));
            tableLayoutPanel1.Size = new Size(1262, 673);
            tableLayoutPanel1.TabIndex = 54;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(NombreLista, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel9, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8571434F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1428566F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 505F));
            tableLayoutPanel2.Size = new Size(346, 667);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(crearLista, 1, 0);
            tableLayoutPanel3.Controls.Add(cambiarBDD, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 102);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(340, 56);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(label7, 0, 0);
            tableLayoutPanel9.Controls.Add(borrarEnunciado, 0, 3);
            tableLayoutPanel9.Controls.Add(nuevoEnunciado, 0, 2);
            tableLayoutPanel9.Controls.Add(listBoxEnunciados, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 164);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 9.919571F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 90.08043F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel9.Size = new Size(340, 500);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(355, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(904, 667);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6169968F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 3;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 476F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 127F));
            tableLayoutPanel10.Size = new Size(898, 661);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(abrirAvanzado, 0, 0);
            tableLayoutPanel8.Controls.Add(VistaPrevia, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 537);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 51.23967F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 48.76033F));
            tableLayoutPanel8.Size = new Size(892, 121);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // abrirAvanzado
            // 
            abrirAvanzado.AutoSize = true;
            abrirAvanzado.BackColor = Color.FromArgb(164, 114, 214);
            abrirAvanzado.Dock = DockStyle.Fill;
            abrirAvanzado.Enabled = false;
            abrirAvanzado.FlatStyle = FlatStyle.Flat;
            abrirAvanzado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            abrirAvanzado.Location = new Point(3, 4);
            abrirAvanzado.Margin = new Padding(3, 4, 3, 4);
            abrirAvanzado.Name = "abrirAvanzado";
            abrirAvanzado.Size = new Size(886, 54);
            abrirAvanzado.TabIndex = 35;
            abrirAvanzado.Text = "Editar enunciado avanzado";
            abrirAvanzado.UseVisualStyleBackColor = false;
            abrirAvanzado.Click += button5_Click;
            // 
            // VistaPrevia
            // 
            VistaPrevia.BackColor = Color.FromArgb(164, 114, 214);
            VistaPrevia.Dock = DockStyle.Fill;
            VistaPrevia.Enabled = false;
            VistaPrevia.FlatStyle = FlatStyle.Flat;
            VistaPrevia.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            VistaPrevia.ImageAlign = ContentAlignment.MiddleRight;
            VistaPrevia.Location = new Point(3, 66);
            VistaPrevia.Margin = new Padding(3, 4, 3, 4);
            VistaPrevia.Name = "VistaPrevia";
            VistaPrevia.Size = new Size(886, 51);
            VistaPrevia.TabIndex = 27;
            VistaPrevia.Text = "Vista Previa";
            VistaPrevia.UseVisualStyleBackColor = false;
            VistaPrevia.Click += actualizarEnunciado_Click;
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
            tableLayoutPanel7.Location = new Point(3, 61);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7913666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 89.20863F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel7.Size = new Size(892, 470);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // textoEnunciado
            // 
            textoEnunciado.BackColor = SystemColors.GradientInactiveCaption;
            textoEnunciado.Dock = DockStyle.Fill;
            textoEnunciado.Enabled = false;
            textoEnunciado.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textoEnunciado.Location = new Point(3, 49);
            textoEnunciado.Margin = new Padding(3, 4, 3, 4);
            textoEnunciado.Name = "textoEnunciado";
            textoEnunciado.Size = new Size(440, 368);
            textoEnunciado.TabIndex = 15;
            textoEnunciado.Text = "";
            textoEnunciado.TextChanged += textoEnunciado_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.Location = new Point(449, 0);
            label8.Name = "label8";
            label8.Size = new Size(440, 45);
            label8.TabIndex = 51;
            label8.Text = "Imagen (Opcional)";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imagenEnunciado
            // 
            imagenEnunciado.Dock = DockStyle.Fill;
            imagenEnunciado.Location = new Point(449, 49);
            imagenEnunciado.Margin = new Padding(3, 4, 3, 4);
            imagenEnunciado.Name = "imagenEnunciado";
            imagenEnunciado.Size = new Size(440, 368);
            imagenEnunciado.TabIndex = 33;
            imagenEnunciado.TabStop = false;
            // 
            // abrirImagen
            // 
            abrirImagen.BackColor = SystemColors.GradientInactiveCaption;
            abrirImagen.Dock = DockStyle.Fill;
            abrirImagen.Enabled = false;
            abrirImagen.FlatStyle = FlatStyle.Flat;
            abrirImagen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            abrirImagen.Location = new Point(449, 425);
            abrirImagen.Margin = new Padding(3, 4, 3, 4);
            abrirImagen.Name = "abrirImagen";
            abrirImagen.Size = new Size(440, 41);
            abrirImagen.TabIndex = 31;
            abrirImagen.Text = "Cargar Imagen";
            abrirImagen.UseVisualStyleBackColor = false;
            abrirImagen.Click += abrirImagen_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(440, 45);
            label6.TabIndex = 14;
            label6.Text = "Enunciado";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.1839066F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.81609F));
            tableLayoutPanel11.Controls.Add(label9, 0, 0);
            tableLayoutPanel11.Controls.Add(resultadoEnunciado, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 424);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(440, 43);
            tableLayoutPanel11.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(135, 43);
            label9.TabIndex = 52;
            label9.Text = "Resultado";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultadoEnunciado
            // 
            resultadoEnunciado.BackColor = SystemColors.GradientInactiveCaption;
            resultadoEnunciado.Dock = DockStyle.Fill;
            resultadoEnunciado.Enabled = false;
            resultadoEnunciado.Font = new Font("Segoe UI", 16F);
            resultadoEnunciado.Location = new Point(144, 3);
            resultadoEnunciado.Name = "resultadoEnunciado";
            resultadoEnunciado.Size = new Size(293, 43);
            resultadoEnunciado.TabIndex = 50;
            resultadoEnunciado.TextChanged += resultadoEnunciado_TextChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5237579F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.47624F));
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(NombreEnunciado, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(892, 51);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 51);
            label1.TabIndex = 3;
            label1.Text = "Nombre enunciado";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NombreEnunciado
            // 
            NombreEnunciado.BackColor = SystemColors.GradientInactiveCaption;
            NombreEnunciado.Dock = DockStyle.Fill;
            NombreEnunciado.Enabled = false;
            NombreEnunciado.Font = new Font("Segoe UI", 16F);
            NombreEnunciado.Location = new Point(293, 4);
            NombreEnunciado.Margin = new Padding(3, 4, 3, 4);
            NombreEnunciado.Name = "NombreEnunciado";
            NombreEnunciado.Size = new Size(596, 43);
            NombreEnunciado.TabIndex = 4;
            // 
            // AlterarBDD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1262, 673);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AlterarBDD";
            Text = "AlterarBDD";
            FormClosed += AlterarBDD_FormClosed;
            Load += AlterarBDD_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenEnunciado).EndInit();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button nuevoEnunciado;
        private Button borrarEnunciado;
        private Button cambiarBDD;
        private Button crearLista;
        private ListBox listBoxEnunciados;
        private Label label4;
        private TextBox NombreLista;
        private Label label3;
        private TextBox resultadoEnunciado2;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel8;
        private Button abrirAvanzado;
        private Button VistaPrevia;
        private TableLayoutPanel tableLayoutPanel7;
        private RichTextBox textoEnunciado;
        private Label label8;
        private PictureBox imagenEnunciado;
        private Button abrirImagen;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label9;
        private TextBox resultadoEnunciado;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private TextBox NombreEnunciado;
    }
}