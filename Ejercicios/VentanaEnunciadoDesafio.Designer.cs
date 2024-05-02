namespace Ejercicios {
    partial class VentanaEnunciadoDesafio {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            Enunciado1 = new RichTextBox();
            RespuestaP1 = new TextBox();
            label1 = new Label();
            botonP1 = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            labelTiempo = new Label();
            labelCorrectas = new Label();
            labelIncorrectas = new Label();
            valorTiempo = new Label();
            valorCorrectas = new Label();
            valorIncorrectas = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // Enunciado1
            // 
            Enunciado1.Dock = DockStyle.Fill;
            Enunciado1.Font = new Font("Segoe UI", 11F);
            Enunciado1.Location = new Point(3, 4);
            Enunciado1.Margin = new Padding(3, 4, 3, 4);
            Enunciado1.Name = "Enunciado1";
            Enunciado1.ReadOnly = true;
            Enunciado1.Size = new Size(338, 272);
            Enunciado1.TabIndex = 1;
            Enunciado1.Text = "";
            // 
            // RespuestaP1
            // 
            RespuestaP1.Dock = DockStyle.Fill;
            RespuestaP1.Enabled = false;
            RespuestaP1.Font = new Font("Segoe UI", 12F);
            RespuestaP1.Location = new Point(147, 4);
            RespuestaP1.Margin = new Padding(3, 4, 3, 4);
            RespuestaP1.Name = "RespuestaP1";
            RespuestaP1.Size = new Size(544, 34);
            RespuestaP1.TabIndex = 2;
            RespuestaP1.KeyPress += RespuestaP1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 40);
            label1.TabIndex = 3;
            label1.Text = "Su respuesta:";
            // 
            // botonP1
            // 
            botonP1.Dock = DockStyle.Fill;
            botonP1.Font = new Font("Segoe UI", 12F);
            botonP1.Location = new Point(3, 50);
            botonP1.Margin = new Padding(3, 4, 3, 4);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(694, 74);
            botonP1.TabIndex = 4;
            botonP1.Text = "Enviar respuesta";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(347, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 274);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.02797F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.9720287F));
            tableLayoutPanel1.Size = new Size(706, 477);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(700, 337);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5951662F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 86.40483F));
            tableLayoutPanel5.Size = new Size(694, 331);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel6.Controls.Add(Enunciado1, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 48);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(688, 280);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 6;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.8666649F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.1333351F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
            tableLayoutPanel7.Controls.Add(labelTiempo, 0, 0);
            tableLayoutPanel7.Controls.Add(labelCorrectas, 2, 0);
            tableLayoutPanel7.Controls.Add(labelIncorrectas, 4, 0);
            tableLayoutPanel7.Controls.Add(valorTiempo, 1, 0);
            tableLayoutPanel7.Controls.Add(valorCorrectas, 3, 0);
            tableLayoutPanel7.Controls.Add(valorIncorrectas, 5, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(688, 39);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.Dock = DockStyle.Fill;
            labelTiempo.Font = new Font("Segoe UI", 12F);
            labelTiempo.Location = new Point(3, 0);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(86, 39);
            labelTiempo.TabIndex = 0;
            labelTiempo.Text = "Tiempo:";
            labelTiempo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCorrectas
            // 
            labelCorrectas.AutoSize = true;
            labelCorrectas.Dock = DockStyle.Fill;
            labelCorrectas.Font = new Font("Segoe UI", 12F);
            labelCorrectas.Location = new Point(222, 0);
            labelCorrectas.Name = "labelCorrectas";
            labelCorrectas.Size = new Size(112, 39);
            labelCorrectas.TabIndex = 1;
            labelCorrectas.Text = "Correctas:";
            labelCorrectas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelIncorrectas
            // 
            labelIncorrectas.AutoSize = true;
            labelIncorrectas.Dock = DockStyle.Fill;
            labelIncorrectas.Font = new Font("Segoe UI", 12F);
            labelIncorrectas.Location = new Point(433, 0);
            labelIncorrectas.Name = "labelIncorrectas";
            labelIncorrectas.Size = new Size(154, 39);
            labelIncorrectas.TabIndex = 2;
            labelIncorrectas.Text = "Incorrectas:";
            labelIncorrectas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valorTiempo
            // 
            valorTiempo.AutoSize = true;
            valorTiempo.Dock = DockStyle.Fill;
            valorTiempo.Font = new Font("Segoe UI", 12F);
            valorTiempo.Location = new Point(95, 0);
            valorTiempo.Name = "valorTiempo";
            valorTiempo.Size = new Size(121, 39);
            valorTiempo.TabIndex = 3;
            valorTiempo.Text = "label2";
            valorTiempo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valorCorrectas
            // 
            valorCorrectas.AutoSize = true;
            valorCorrectas.Dock = DockStyle.Fill;
            valorCorrectas.Font = new Font("Segoe UI", 12F);
            valorCorrectas.Location = new Point(340, 0);
            valorCorrectas.Name = "valorCorrectas";
            valorCorrectas.Size = new Size(87, 39);
            valorCorrectas.TabIndex = 4;
            valorCorrectas.Text = "0";
            valorCorrectas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valorIncorrectas
            // 
            valorIncorrectas.AutoSize = true;
            valorIncorrectas.Dock = DockStyle.Fill;
            valorIncorrectas.Font = new Font("Segoe UI", 12F);
            valorIncorrectas.Location = new Point(593, 0);
            valorIncorrectas.Name = "valorIncorrectas";
            valorIncorrectas.Size = new Size(92, 39);
            valorIncorrectas.TabIndex = 5;
            valorIncorrectas.Text = "0";
            valorIncorrectas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(botonP1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 346);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 36.52174F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 63.47826F));
            tableLayoutPanel3.Size = new Size(700, 128);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7547169F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.245285F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(RespuestaP1, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(694, 40);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // VentanaEnunciadoDesafio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 477);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VentanaEnunciadoDesafio";
            Text = "Ventana Enunciado";
            Load += Problema_1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox Enunciado1;
        private TextBox RespuestaP1;
        private Label label1;
        private Button botonP1;

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label labelTiempo;
        private Label labelCorrectas;
        private Label labelIncorrectas;
        private System.Windows.Forms.Timer timer1;
        private Label valorTiempo;
        private Label valorCorrectas;
        private Label valorIncorrectas;
    }
}