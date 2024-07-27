namespace Ejercicios
{
    partial class VentanaEnunciado
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
            Enunciado1 = new RichTextBox();
            RespuestaP1 = new TextBox();
            label1 = new Label();
            botonP1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // Enunciado1
            // 
            Enunciado1.Dock = DockStyle.Fill;
            Enunciado1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            Enunciado1.Location = new Point(2, 3);
            Enunciado1.Margin = new Padding(2, 3, 2, 3);
            Enunciado1.Name = "Enunciado1";
            Enunciado1.ReadOnly = true;
            Enunciado1.Size = new Size(1260, 559);
            Enunciado1.TabIndex = 1;
            Enunciado1.Text = "";
            // 
            // RespuestaP1
            // 
            RespuestaP1.Dock = DockStyle.Fill;
            RespuestaP1.Font = new Font("Segoe UI", 11F);
            RespuestaP1.Location = new Point(397, 3);
            RespuestaP1.Margin = new Padding(2, 3, 2, 3);
            RespuestaP1.Name = "RespuestaP1";
            RespuestaP1.Size = new Size(857, 27);
            RespuestaP1.TabIndex = 2;
            RespuestaP1.KeyPress += RespuestaP1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(391, 33);
            label1.TabIndex = 3;
            label1.Text = "Su respuesta:";
            // 
            // botonP1
            // 
            botonP1.Dock = DockStyle.Fill;
            botonP1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonP1.Location = new Point(2, 40);
            botonP1.Margin = new Padding(2, 3, 2, 3);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(1256, 69);
            botonP1.TabIndex = 4;
            botonP1.Text = "Enviar respuesta";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Enunciado1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.9662247F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0337734F));
            tableLayoutPanel1.Size = new Size(1264, 681);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(botonP1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 567);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0357132F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.96429F));
            tableLayoutPanel2.Size = new Size(1260, 112);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.4814816F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.51852F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(RespuestaP1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(2, 2);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1256, 33);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // VentanaEnunciado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "VentanaEnunciado";
            Text = "Enunciado";
            Load += Problema_1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox Enunciado1;
        private TextBox RespuestaP1;
        private Label label1;
        private Button botonP1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}