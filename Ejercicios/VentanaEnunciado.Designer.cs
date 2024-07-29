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
            SuspendLayout();
            // 
            // Enunciado1
            // 
            Enunciado1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            Enunciado1.Location = new Point(11, 12);
            Enunciado1.Margin = new Padding(2, 3, 2, 3);
            Enunciado1.Name = "Enunciado1";
            Enunciado1.ReadOnly = true;
            Enunciado1.Size = new Size(1245, 454);
            Enunciado1.TabIndex = 1;
            Enunciado1.Text = "";
            // 
            // RespuestaP1
            // 
            RespuestaP1.Font = new Font("Segoe UI", 16F);
            RespuestaP1.Location = new Point(205, 477);
            RespuestaP1.Margin = new Padding(2, 3, 2, 3);
            RespuestaP1.Name = "RespuestaP1";
            RespuestaP1.Size = new Size(1048, 36);
            RespuestaP1.TabIndex = 2;
            RespuestaP1.KeyPress += RespuestaP1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.25F, FontStyle.Bold);
            label1.Location = new Point(11, 475);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 36);
            label1.TabIndex = 3;
            label1.Text = "Su respuesta:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // botonP1
            // 
            botonP1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonP1.Location = new Point(11, 525);
            botonP1.Margin = new Padding(2, 3, 2, 3);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(1245, 69);
            botonP1.TabIndex = 4;
            botonP1.Text = "Enviar respuesta";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            // 
            // VentanaEnunciado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1264, 608);
            Controls.Add(Enunciado1);
            Controls.Add(RespuestaP1);
            Controls.Add(label1);
            Controls.Add(botonP1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "VentanaEnunciado";
            Text = "Enunciado";
            Load += Problema_1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Enunciado1;
        private TextBox RespuestaP1;
        private Label label1;
        private Button botonP1;
    }
}