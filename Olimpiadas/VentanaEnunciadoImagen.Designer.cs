namespace Olimpiadas {
    partial class VentanaEnunciadoImagen {
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Enunciado1 = new RichTextBox();
            RespuestaP1 = new TextBox();
            label1 = new Label();
            botonP1 = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // Enunciado1
            // 
            Enunciado1.Dock = DockStyle.Fill;
            Enunciado1.Font = new Font("Segoe UI", 12F);
            Enunciado1.Location = new Point(3, 4);
            Enunciado1.Margin = new Padding(3, 4, 3, 4);
            Enunciado1.Name = "Enunciado1";
            Enunciado1.ReadOnly = true;
            Enunciado1.Size = new Size(315, 294);
            Enunciado1.TabIndex = 1;
            Enunciado1.Text = "";
            // 
            // RespuestaP1
            // 
            RespuestaP1.Dock = DockStyle.Fill;
            RespuestaP1.Enabled = false;
            RespuestaP1.Font = new Font("Segoe UI", 11F);
            RespuestaP1.Location = new Point(135, 4);
            RespuestaP1.Margin = new Padding(3, 4, 3, 4);
            RespuestaP1.Name = "RespuestaP1";
            RespuestaP1.Size = new Size(498, 32);
            RespuestaP1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 36);
            label1.TabIndex = 3;
            label1.Text = "Su respuesta:";
            // 
            // botonP1
            // 
            botonP1.Dock = DockStyle.Fill;
            botonP1.Enabled = false;
            botonP1.Font = new Font("Segoe UI", 12F);
            botonP1.Location = new Point(3, 46);
            botonP1.Margin = new Padding(3, 4, 3, 4);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(636, 65);
            botonP1.TabIndex = 4;
            botonP1.Text = "Enviar respuesta";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(324, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 296);
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
            tableLayoutPanel1.Size = new Size(648, 429);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(Enunciado1, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(642, 302);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(botonP1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 311);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 36.52174F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 63.47826F));
            tableLayoutPanel3.Size = new Size(642, 115);
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
            tableLayoutPanel4.Size = new Size(636, 36);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // VentanaEnunciadoImagen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 429);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VentanaEnunciadoImagen";
            Text = "Ventana Enunciado";
            Load += Problema_1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}