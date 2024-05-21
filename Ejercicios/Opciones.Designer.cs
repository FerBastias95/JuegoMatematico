namespace Ejercicios {
    partial class Opciones {
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
            label2 = new Label();
            opcionesTiempo = new RichTextBox();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new ReaLTaiizor.Controls.HopeRoundButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(222, 150);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 4;
            label2.Text = "Tiempo límite";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // opcionesTiempo
            // 
            opcionesTiempo.Enabled = false;
            opcionesTiempo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opcionesTiempo.Location = new Point(368, 147);
            opcionesTiempo.Name = "opcionesTiempo";
            opcionesTiempo.Size = new Size(154, 36);
            opcionesTiempo.TabIndex = 5;
            opcionesTiempo.Text = "";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton3.Location = new Point(0, 148);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(175, 27);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Desafío Infinito";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton1.Location = new Point(0, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 27);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "5 Ejercicios";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton2.Location = new Point(0, 98);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(151, 27);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "10 Ejercicios";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 48);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 2;
            label1.Text = "Dificultad";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(opcionesTiempo);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(30, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 208);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BorderColor = Color.FromArgb(220, 223, 230);
            button1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            button1.DangerColor = Color.FromArgb(245, 108, 108);
            button1.DefaultColor = Color.FromArgb(255, 255, 255);
            button1.Font = new Font("Segoe UI", 12F);
            button1.HoverTextColor = Color.FromArgb(48, 49, 51);
            button1.InfoColor = Color.FromArgb(144, 147, 153);
            button1.Location = new Point(30, 348);
            button1.Name = "button1";
            button1.PrimaryColor = Color.FromArgb(64, 158, 255);
            button1.Size = new Size(551, 50);
            button1.SuccessColor = Color.FromArgb(103, 194, 58);
            button1.TabIndex = 8;
            button1.Text = "Aceptar Cambios";
            button1.TextColor = Color.White;
            button1.WarningColor = Color.FromArgb(230, 162, 60);
            button1.Click += button1_Click_1;
            // 
            // Opciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 433);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Opciones";
            Text = "Opciones";
            Load += Opciones_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private RichTextBox opcionesTiempo;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.HopeRoundButton button1;
    }
}