namespace Olimpiadas
{
    partial class Inicio
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            botonCrear = new Button();
            botonModificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 27);
            label1.Name = "label1";
            label1.Size = new Size(251, 20);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido al editor de enunciados!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 47);
            label2.Name = "label2";
            label2.Size = new Size(299, 20);
            label2.TabIndex = 1;
            label2.Text = "¿Desea crear una nueva lista de enunciados,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 67);
            label3.Name = "label3";
            label3.Size = new Size(227, 20);
            label3.TabIndex = 2;
            label3.Text = "o desea modificar una existente?";
            // 
            // botonCrear
            // 
            botonCrear.Location = new Point(54, 115);
            botonCrear.Name = "botonCrear";
            botonCrear.Size = new Size(142, 29);
            botonCrear.TabIndex = 3;
            botonCrear.Text = "Crear";
            botonCrear.UseVisualStyleBackColor = true;
            botonCrear.Click += botonCrear_Click;
            // 
            // botonModificar
            // 
            botonModificar.Location = new Point(225, 115);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(142, 29);
            botonModificar.TabIndex = 4;
            botonModificar.Text = "Modificar";
            botonModificar.UseVisualStyleBackColor = true;
            botonModificar.Click += botonModificar_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 169);
            Controls.Add(botonModificar);
            Controls.Add(botonCrear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button botonCrear;
        private Button botonModificar;
    }
}