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
        private void InitializeComponent()
        {
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
            RespuestaP1.Font = new Font("Century Gothic", 18.8F, FontStyle.Italic);
            RespuestaP1.Location = new Point(213, 517);
            RespuestaP1.Name = "RespuestaP1";
            RespuestaP1.Size = new Size(1001, 38);
            RespuestaP1.TabIndex = 2;
            RespuestaP1.KeyPress += RespuestaP1_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label1.Location = new Point(42, 523);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 3;
            label1.Text = "Su respuesta:";
            // 
            // botonP1
            // 
            botonP1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botonP1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonP1.Location = new Point(40, 566);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(1174, 79);
            botonP1.TabIndex = 4;
            botonP1.Text = "Enviar respuesta";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            // 
            // labelTiempo
            // 
            labelTiempo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTiempo.AutoSize = true;
            labelTiempo.Font = new Font("Century Gothic", 17.8F, FontStyle.Bold);
            labelTiempo.Location = new Point(60, 27);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(104, 28);
            labelTiempo.TabIndex = 0;
            labelTiempo.Text = "Tiempo:";
            labelTiempo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCorrectas
            // 
            labelCorrectas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCorrectas.AutoSize = true;
            labelCorrectas.Font = new Font("Century Gothic", 17.8F, FontStyle.Bold);
            labelCorrectas.Location = new Point(361, 27);
            labelCorrectas.Name = "labelCorrectas";
            labelCorrectas.Size = new Size(133, 28);
            labelCorrectas.TabIndex = 1;
            labelCorrectas.Text = "Correctas:";
            labelCorrectas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelIncorrectas
            // 
            labelIncorrectas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelIncorrectas.AutoSize = true;
            labelIncorrectas.Font = new Font("Century Gothic", 17.8F, FontStyle.Bold);
            labelIncorrectas.Location = new Point(648, 27);
            labelIncorrectas.Name = "labelIncorrectas";
            labelIncorrectas.Size = new Size(150, 28);
            labelIncorrectas.TabIndex = 2;
            labelIncorrectas.Text = "Incorrectas:";
            labelIncorrectas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // valorTiempo
            // 
            valorTiempo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valorTiempo.AutoSize = true;
            valorTiempo.Font = new Font("Century Gothic", 17.8F, FontStyle.Bold);
            valorTiempo.Location = new Point(170, 27);
            valorTiempo.Name = "valorTiempo";
            valorTiempo.Size = new Size(84, 28);
            valorTiempo.TabIndex = 3;
            valorTiempo.Text = "label2";
            valorTiempo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valorCorrectas
            // 
            valorCorrectas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valorCorrectas.AutoSize = true;
            valorCorrectas.Font = new Font("Century Gothic", 17.8F, FontStyle.Bold);
            valorCorrectas.Location = new Point(500, 27);
            valorCorrectas.Name = "valorCorrectas";
            valorCorrectas.Size = new Size(25, 28);
            valorCorrectas.TabIndex = 4;
            valorCorrectas.Text = "0";
            valorCorrectas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valorIncorrectas
            // 
            valorIncorrectas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            valorIncorrectas.AutoSize = true;
            valorIncorrectas.Font = new Font("Century Gothic", 17.8F, FontStyle.Bold);
            valorIncorrectas.Location = new Point(804, 27);
            valorIncorrectas.Name = "valorIncorrectas";
            valorIncorrectas.Size = new Size(25, 28);
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
            Enunciado1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enunciado1.Location = new Point(42, 64);
            Enunciado1.Name = "Enunciado1";
            Enunciado1.ReadOnly = true;
            Enunciado1.Size = new Size(537, 422);
            Enunciado1.TabIndex = 1;
            Enunciado1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(648, 64);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 422);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // VentanaEnunciadoDesafio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 671);
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
            MaximizeBox = false;
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