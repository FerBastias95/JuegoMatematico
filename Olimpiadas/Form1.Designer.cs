namespace Olimpiadas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonP1 = new Button();
            botonP2 = new Button();
            botonP3 = new Button();
            botonP4 = new Button();
            botonP5 = new Button();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            LabelP1 = new Label();
            LabelP2 = new Label();
            LabelP3 = new Label();
            LabelP4 = new Label();
            LabelP5 = new Label();
            labelVidas = new Label();
            LabelResueltos = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // botonP1
            // 
            botonP1.Location = new Point(36, 146);
            botonP1.Name = "botonP1";
            botonP1.Size = new Size(75, 23);
            botonP1.TabIndex = 0;
            botonP1.Text = "Problema 1";
            botonP1.UseVisualStyleBackColor = true;
            botonP1.Click += botonP1_Click;
            // 
            // botonP2
            // 
            botonP2.Location = new Point(117, 146);
            botonP2.Name = "botonP2";
            botonP2.Size = new Size(75, 23);
            botonP2.TabIndex = 1;
            botonP2.Text = "Problema 2";
            botonP2.UseVisualStyleBackColor = true;
            botonP2.Click += botonP2_Click;
            // 
            // botonP3
            // 
            botonP3.Location = new Point(198, 146);
            botonP3.Name = "botonP3";
            botonP3.Size = new Size(75, 23);
            botonP3.TabIndex = 2;
            botonP3.Text = "Problema 3";
            botonP3.UseVisualStyleBackColor = true;
            botonP3.Click += botonP3_Click;
            // 
            // botonP4
            // 
            botonP4.Location = new Point(279, 146);
            botonP4.Name = "botonP4";
            botonP4.Size = new Size(75, 23);
            botonP4.TabIndex = 3;
            botonP4.Text = "Problema 4";
            botonP4.UseVisualStyleBackColor = true;
            botonP4.Click += botonP4_Click;
            // 
            // botonP5
            // 
            botonP5.Location = new Point(360, 146);
            botonP5.Name = "botonP5";
            botonP5.Size = new Size(75, 23);
            botonP5.TabIndex = 4;
            botonP5.Text = "Problema 5";
            botonP5.UseVisualStyleBackColor = true;
            botonP5.Click += botonP5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 198);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Vidas restantes: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 222);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 6;
            label2.Text = "Problemas resueltos:";
            // 
            // button6
            // 
            button6.Location = new Point(238, 254);
            button6.Name = "button6";
            button6.Size = new Size(197, 23);
            button6.TabIndex = 7;
            button6.Text = "Obtener recompensa";
            button6.UseVisualStyleBackColor = true;
            // 
            // LabelP1
            // 
            LabelP1.AutoSize = true;
            LabelP1.ForeColor = Color.LimeGreen;
            LabelP1.Location = new Point(60, 130);
            LabelP1.Name = "LabelP1";
            LabelP1.Size = new Size(29, 15);
            LabelP1.TabIndex = 8;
            LabelP1.Text = "¡OK!";
            // 
            // LabelP2
            // 
            LabelP2.AutoSize = true;
            LabelP2.ForeColor = Color.Red;
            LabelP2.Location = new Point(140, 130);
            LabelP2.Name = "LabelP2";
            LabelP2.Size = new Size(23, 15);
            LabelP2.TabIndex = 9;
            LabelP2.Text = "No";
            // 
            // LabelP3
            // 
            LabelP3.AutoSize = true;
            LabelP3.ForeColor = Color.Red;
            LabelP3.Location = new Point(222, 130);
            LabelP3.Name = "LabelP3";
            LabelP3.Size = new Size(23, 15);
            LabelP3.TabIndex = 10;
            LabelP3.Text = "No";
            // 
            // LabelP4
            // 
            LabelP4.AutoSize = true;
            LabelP4.ForeColor = Color.Red;
            LabelP4.Location = new Point(302, 130);
            LabelP4.Name = "LabelP4";
            LabelP4.Size = new Size(23, 15);
            LabelP4.TabIndex = 11;
            LabelP4.Text = "No";
            // 
            // LabelP5
            // 
            LabelP5.AutoSize = true;
            LabelP5.ForeColor = Color.Red;
            LabelP5.Location = new Point(382, 130);
            LabelP5.Name = "LabelP5";
            LabelP5.Size = new Size(23, 15);
            LabelP5.TabIndex = 12;
            LabelP5.Text = "No";
            // 
            // labelVidas
            // 
            labelVidas.AutoSize = true;
            labelVidas.Location = new Point(155, 198);
            labelVidas.Name = "labelVidas";
            labelVidas.Size = new Size(13, 15);
            labelVidas.TabIndex = 13;
            labelVidas.Text = "0";
            // 
            // LabelResueltos
            // 
            LabelResueltos.AutoSize = true;
            LabelResueltos.Location = new Point(155, 222);
            LabelResueltos.Name = "LabelResueltos";
            LabelResueltos.Size = new Size(13, 15);
            LabelResueltos.TabIndex = 14;
            LabelResueltos.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(36, 254);
            button1.Name = "button1";
            button1.Size = new Size(196, 23);
            button1.TabIndex = 15;
            button1.Text = "Editar enunciados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(477, 302);
            Controls.Add(button1);
            Controls.Add(LabelResueltos);
            Controls.Add(labelVidas);
            Controls.Add(LabelP5);
            Controls.Add(LabelP4);
            Controls.Add(LabelP3);
            Controls.Add(LabelP2);
            Controls.Add(LabelP1);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonP5);
            Controls.Add(botonP4);
            Controls.Add(botonP3);
            Controls.Add(botonP2);
            Controls.Add(botonP1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonP1;
        private Button botonP2;
        private Button botonP3;
        private Button botonP4;
        private Button botonP5;
        private Label label1;
        private Label label2;
        private Button button6;
        private Label LabelP1;
        private Label LabelP2;
        private Label LabelP3;
        private Label LabelP4;
        private Label LabelP5;
        private Label labelVidas;
        private Label LabelResueltos;
        private Button button1;
    }
}
