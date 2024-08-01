namespace Ejercicios {
    partial class Resultados {
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
            botonP1 = new Button();
            Correctas = new RichTextBox();
            Incorrectas = new RichTextBox();
            SuspendLayout();
            // 
            // botonP1
            // 
            botonP1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonP1.Location = new Point(12, 592);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(1240, 110);
            botonP1.TabIndex = 4;
            botonP1.Text = "Cerrar";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            botonP1.KeyPress += botonP1_KeyPress;
            // 
            // Correctas
            // 
            Correctas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Correctas.Location = new Point(12, 12);
            Correctas.Name = "Correctas";
            Correctas.ReadOnly = true;
            Correctas.Size = new Size(612, 557);
            Correctas.TabIndex = 1;
            Correctas.Text = "";
            // 
            // Incorrectas
            // 
            Incorrectas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Incorrectas.Location = new Point(643, 12);
            Incorrectas.Name = "Incorrectas";
            Incorrectas.ReadOnly = true;
            Incorrectas.Size = new Size(609, 557);
            Incorrectas.TabIndex = 5;
            Incorrectas.Text = "";
            // 
            // Resultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 714);
            Controls.Add(Incorrectas);
            Controls.Add(Correctas);
            Controls.Add(botonP1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Resultados";
            Text = "Ventana Enunciado";
            Load += Resultados_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button botonP1;
        private RichTextBox Correctas;
        private RichTextBox Incorrectas;
    }
}