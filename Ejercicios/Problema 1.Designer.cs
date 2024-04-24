namespace Ejercicios
{
    partial class Problema_1
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
        private void InitializeComponent()
        {
            Enunciado1 = new RichTextBox();
            RespuestaP1 = new TextBox();
            label1 = new Label();
            botonP1 = new Button();
            SuspendLayout();
            // 
            // Enunciado1
            // 
            Enunciado1.Location = new Point(32, 31);
            Enunciado1.Name = "Enunciado1";
            Enunciado1.ReadOnly = true;
            Enunciado1.Size = new Size(373, 107);
            Enunciado1.TabIndex = 1;
            Enunciado1.Text = "";
            // 
            // RespuestaP1
            // 
            RespuestaP1.Location = new Point(130, 181);
            RespuestaP1.Name = "RespuestaP1";
            RespuestaP1.Size = new Size(164, 23);
            RespuestaP1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 163);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Su respuesta:";
            // 
            // botonP1
            // 
            botonP1.Location = new Point(130, 210);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(164, 23);
            botonP1.TabIndex = 4;
            botonP1.Text = "Enviar respuesta";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            // 
            // Problema_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 255);
            Controls.Add(botonP1);
            Controls.Add(label1);
            Controls.Add(RespuestaP1);
            Controls.Add(Enunciado1);
            Name = "Problema_1";
            Text = "Problema_1";
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