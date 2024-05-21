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
            RespuestaP1 = new TextBox();
            label1 = new Label();
            botonP1 = new Button();
            labelTiempo = new Label();
            labelCorrectas = new Label();
            labelIncorrectas = new Label();
            valorTiempo = new Label();
            valorCorrectas = new Label();
            valorIncorrectas = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Enunciado1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RespuestaP1
            // 
            RespuestaP1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RespuestaP1.Enabled = false;
            RespuestaP1.Font = new Font("Century Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            RespuestaP1.Location = new Point(210, 361);
            RespuestaP1.Margin = new Padding(3, 4, 3, 4);
            RespuestaP1.Name = "RespuestaP1";
            RespuestaP1.Size = new Size(515, 36);
            RespuestaP1.TabIndex = 2;
            RespuestaP1.KeyPress += RespuestaP1_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label1.Location = new Point(46, 364);
            label1.Name = "label1";
            label1.Size = new Size(158, 27);
            label1.TabIndex = 3;
            label1.Text = "Su respuesta:";
            // 
            // botonP1
            // 
            botonP1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botonP1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonP1.Location = new Point(46, 416);
            botonP1.Margin = new Padding(3, 4, 3, 4);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(679, 103);
            botonP1.TabIndex = 4;
            botonP1.Text = "Enviar respuesta";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            // 
            // labelTiempo
            // 
            labelTiempo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTiempo.AutoSize = true;
            labelTiempo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            labelTiempo.Location = new Point(69, 36);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(101, 27);
            labelTiempo.TabIndex = 0;
            labelTiempo.Text = "Tiempo:";
            labelTiempo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCorrectas
            // 
            labelCorrectas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCorrectas.AutoSize = true;
            labelCorrectas.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            labelCorrectas.Location = new Point(321, 36);
            labelCorrectas.Name = "labelCorrectas";
            labelCorrectas.Size = new Size(127, 27);
            labelCorrectas.TabIndex = 1;
            labelCorrectas.Text = "Correctas:";
            labelCorrectas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelIncorrectas
            // 
            labelIncorrectas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelIncorrectas.AutoSize = true;
            labelIncorrectas.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            labelIncorrectas.Location = new Point(527, 36);
            labelIncorrectas.Name = "labelIncorrectas";
            labelIncorrectas.Size = new Size(144, 27);
            labelIncorrectas.TabIndex = 2;
            labelIncorrectas.Text = "Incorrectas:";
            labelIncorrectas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valorTiempo
            // 
            valorTiempo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valorTiempo.AutoSize = true;
            valorTiempo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            valorTiempo.Location = new Point(176, 36);
            valorTiempo.Name = "valorTiempo";
            valorTiempo.Size = new Size(82, 27);
            valorTiempo.TabIndex = 3;
            valorTiempo.Text = "label2";
            valorTiempo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valorCorrectas
            // 
            valorCorrectas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valorCorrectas.AutoSize = true;
            valorCorrectas.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            valorCorrectas.Location = new Point(454, 36);
            valorCorrectas.Name = "valorCorrectas";
            valorCorrectas.Size = new Size(25, 27);
            valorCorrectas.TabIndex = 4;
            valorCorrectas.Text = "0";
            valorCorrectas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valorIncorrectas
            // 
            valorIncorrectas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valorIncorrectas.AutoSize = true;
            valorIncorrectas.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            valorIncorrectas.Location = new Point(677, 36);
            valorIncorrectas.Name = "valorIncorrectas";
            valorIncorrectas.Size = new Size(25, 27);
            valorIncorrectas.TabIndex = 5;
            valorIncorrectas.Text = "0";
            valorIncorrectas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Enunciado1
            // 
            Enunciado1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Enunciado1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enunciado1.Location = new Point(48, 85);
            Enunciado1.Margin = new Padding(3, 4, 3, 4);
            Enunciado1.Name = "Enunciado1";
            Enunciado1.ReadOnly = true;
            Enunciado1.Size = new Size(325, 250);
            Enunciado1.TabIndex = 1;
            Enunciado1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(400, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 250);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // VentanaEnunciadoDesafio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Enunciado1);
            Controls.Add(botonP1);
            Controls.Add(labelTiempo);
            Controls.Add(RespuestaP1);
            Controls.Add(labelCorrectas);
            Controls.Add(valorTiempo);
            Controls.Add(labelIncorrectas);
            Controls.Add(valorIncorrectas);
            Controls.Add(valorCorrectas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VentanaEnunciadoDesafio";
            Text = "Desafío Infinito";
            Load += Problema_1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox RespuestaP1;
        private Label label1;
        private Button botonP1;

#endregion
        private Label labelTiempo;
        private Label labelCorrectas;
        private Label labelIncorrectas;
        private System.Windows.Forms.Timer timer1;
        private Label valorTiempo;
        private Label valorCorrectas;
        private Label valorIncorrectas;
        private RichTextBox Enunciado1;
        private PictureBox pictureBox1;
    }
}