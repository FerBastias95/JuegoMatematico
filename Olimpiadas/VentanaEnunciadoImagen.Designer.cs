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
            RespuestaP1 = new TextBox();
            label1 = new Label();
            botonP1 = new Button();
            pictureBox1 = new PictureBox();
            Enunciado1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RespuestaP1
            // 
            RespuestaP1.Font = new Font("Segoe UI", 20F);
            RespuestaP1.Location = new Point(194, 591);
            RespuestaP1.Name = "RespuestaP1";
            RespuestaP1.Size = new Size(1058, 43);
            RespuestaP1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.25F, FontStyle.Bold);
            label1.Location = new Point(12, 591);
            label1.Name = "label1";
            label1.Size = new Size(176, 36);
            label1.TabIndex = 3;
            label1.Text = "Su respuesta:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // botonP1
            // 
            botonP1.Font = new Font("Segoe UI", 12F);
            botonP1.Location = new Point(12, 655);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(1240, 47);
            botonP1.TabIndex = 4;
            botonP1.Text = "Enviar respuesta";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(640, 12);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(612, 559);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Enunciado1
            // 
            Enunciado1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enunciado1.Location = new Point(12, 12);
            Enunciado1.Name = "Enunciado1";
            Enunciado1.ReadOnly = true;
            Enunciado1.Size = new Size(612, 557);
            Enunciado1.TabIndex = 1;
            Enunciado1.Text = "";
            // 
            // VentanaEnunciadoImagen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 714);
            Controls.Add(pictureBox1);
            Controls.Add(Enunciado1);
            Controls.Add(label1);
            Controls.Add(RespuestaP1);
            Controls.Add(botonP1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VentanaEnunciadoImagen";
            Text = "Ventana Enunciado";
            Load += Problema_1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox RespuestaP1;
        private Label label1;
        private Button botonP1;
        private PictureBox pictureBox1;
        private RichTextBox Enunciado1;
    }
}