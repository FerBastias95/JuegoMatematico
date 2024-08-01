namespace Ejercicios {
    partial class CustomBox {
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
            button1 = new ReaLTaiizor.Controls.Button();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.Transparent;
            button1.EnteredColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.Transparent;
            button1.Location = new Point(0, 172);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.Transparent;
            button1.PressedColor = Color.Transparent;
            button1.Size = new Size(771, 54);
            button1.TabIndex = 1;
            button1.Text = "Volver";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            button1.KeyPress += button1_KeyPress;
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 3F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.White;
            cyberTextBox1.ColorBackground_Pen = Color.Transparent;
            cyberTextBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox1.Enabled = false;
            cyberTextBox1.Font = new Font("Segoe UI", 43F, FontStyle.Bold);
            cyberTextBox1.ForeColor = Color.Black;
            cyberTextBox1.Lighting = true;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(0, 0);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = true;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 10;
            cyberTextBox1.Size = new Size(771, 172);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cyberTextBox1.TabIndex = 2;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "RESPUESTA CORRECTA";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // CustomBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(771, 227);
            Controls.Add(button1);
            Controls.Add(cyberTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomBox";
            Text = "CustomBox";
            Load += CustomBox_Load;
            KeyPress += CustomBox_KeyPress;
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
    }
}