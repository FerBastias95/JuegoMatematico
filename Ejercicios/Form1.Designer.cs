namespace Ejercicios
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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            LabelP1 = new Label();
            LabelP2 = new Label();
            LabelP3 = new Label();
            LabelP4 = new Label();
            LabelP5 = new Label();
            labelVidas = new Label();
            LabelResueltos = new Label();
            abrirEnunciados = new Button();
            botonOpciones = new Button();
            labelP6 = new Label();
            labelP7 = new Label();
            labelP8 = new Label();
            labelP9 = new Label();
            labelP10 = new Label();
            cambiarVariables = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            label4 = new Label();
            botonP1 = new ReaLTaiizor.Controls.HopeButton();
            botonP2 = new ReaLTaiizor.Controls.HopeButton();
            botonP3 = new ReaLTaiizor.Controls.HopeButton();
            botonP4 = new ReaLTaiizor.Controls.HopeButton();
            botonP5 = new ReaLTaiizor.Controls.HopeButton();
            botonP6 = new ReaLTaiizor.Controls.HopeButton();
            botonP7 = new ReaLTaiizor.Controls.HopeButton();
            botonP8 = new ReaLTaiizor.Controls.HopeButton();
            botonP9 = new ReaLTaiizor.Controls.HopeButton();
            botonP10 = new ReaLTaiizor.Controls.HopeButton();
            button1 = new ReaLTaiizor.Controls.HopeButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(94, 542);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 5;
            label1.Text = "Vidas restantes: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(94, 589);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 6;
            label2.Text = "Resueltos:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelP1
            // 
            LabelP1.AutoSize = true;
            LabelP1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP1.ForeColor = Color.LimeGreen;
            LabelP1.Location = new Point(94, 146);
            LabelP1.Name = "LabelP1";
            LabelP1.Size = new Size(53, 24);
            LabelP1.TabIndex = 8;
            LabelP1.Text = "¡OK!";
            LabelP1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelP2
            // 
            LabelP2.AutoSize = true;
            LabelP2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP2.ForeColor = Color.Red;
            LabelP2.Location = new Point(271, 146);
            LabelP2.Name = "LabelP2";
            LabelP2.Size = new Size(37, 24);
            LabelP2.TabIndex = 9;
            LabelP2.Text = "No";
            LabelP2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelP3
            // 
            LabelP3.AutoSize = true;
            LabelP3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP3.ForeColor = Color.Red;
            LabelP3.Location = new Point(450, 146);
            LabelP3.Name = "LabelP3";
            LabelP3.Size = new Size(37, 24);
            LabelP3.TabIndex = 10;
            LabelP3.Text = "No";
            LabelP3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelP4
            // 
            LabelP4.AutoSize = true;
            LabelP4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP4.ForeColor = Color.Red;
            LabelP4.Location = new Point(629, 146);
            LabelP4.Name = "LabelP4";
            LabelP4.Size = new Size(37, 24);
            LabelP4.TabIndex = 11;
            LabelP4.Text = "No";
            LabelP4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelP5
            // 
            LabelP5.AutoSize = true;
            LabelP5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP5.ForeColor = Color.Red;
            LabelP5.Location = new Point(808, 146);
            LabelP5.Name = "LabelP5";
            LabelP5.Size = new Size(37, 24);
            LabelP5.TabIndex = 12;
            LabelP5.Text = "No";
            LabelP5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelVidas
            // 
            labelVidas.AutoSize = true;
            labelVidas.Font = new Font("Segoe UI", 11F);
            labelVidas.Location = new Point(248, 542);
            labelVidas.Name = "labelVidas";
            labelVidas.Size = new Size(22, 25);
            labelVidas.TabIndex = 13;
            labelVidas.Text = "0";
            labelVidas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelResueltos
            // 
            LabelResueltos.AutoSize = true;
            LabelResueltos.Font = new Font("Segoe UI", 11F);
            LabelResueltos.Location = new Point(248, 589);
            LabelResueltos.Name = "LabelResueltos";
            LabelResueltos.Size = new Size(22, 25);
            LabelResueltos.TabIndex = 14;
            LabelResueltos.Text = "0";
            LabelResueltos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // abrirEnunciados
            // 
            abrirEnunciados.BackColor = SystemColors.GradientActiveCaption;
            abrirEnunciados.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            abrirEnunciados.Location = new Point(314, 542);
            abrirEnunciados.Margin = new Padding(3, 4, 3, 4);
            abrirEnunciados.Name = "abrirEnunciados";
            abrirEnunciados.Size = new Size(667, 34);
            abrirEnunciados.TabIndex = 15;
            abrirEnunciados.Text = "Seleccionar Lista";
            abrirEnunciados.UseVisualStyleBackColor = false;
            abrirEnunciados.Click += button1_Click;
            // 
            // botonOpciones
            // 
            botonOpciones.BackColor = SystemColors.GradientActiveCaption;
            botonOpciones.Enabled = false;
            botonOpciones.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            botonOpciones.Location = new Point(314, 588);
            botonOpciones.Name = "botonOpciones";
            botonOpciones.Size = new Size(667, 37);
            botonOpciones.TabIndex = 16;
            botonOpciones.Text = "Ajustar Dificultad";
            botonOpciones.UseVisualStyleBackColor = false;
            botonOpciones.Click += botonOpciones_Click;
            // 
            // labelP6
            // 
            labelP6.AutoSize = true;
            labelP6.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP6.Location = new Point(94, 303);
            labelP6.Name = "labelP6";
            labelP6.Size = new Size(72, 24);
            labelP6.TabIndex = 0;
            labelP6.Text = "label3";
            labelP6.TextAlign = ContentAlignment.BottomCenter;
            labelP6.Visible = false;
            // 
            // labelP7
            // 
            labelP7.AutoSize = true;
            labelP7.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP7.Location = new Point(271, 303);
            labelP7.Name = "labelP7";
            labelP7.Size = new Size(72, 24);
            labelP7.TabIndex = 1;
            labelP7.Text = "label4";
            labelP7.TextAlign = ContentAlignment.BottomCenter;
            labelP7.Visible = false;
            // 
            // labelP8
            // 
            labelP8.AutoSize = true;
            labelP8.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP8.Location = new Point(450, 303);
            labelP8.Name = "labelP8";
            labelP8.Size = new Size(72, 24);
            labelP8.TabIndex = 2;
            labelP8.Text = "label5";
            labelP8.TextAlign = ContentAlignment.BottomCenter;
            labelP8.Visible = false;
            // 
            // labelP9
            // 
            labelP9.AutoSize = true;
            labelP9.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP9.Location = new Point(629, 303);
            labelP9.Name = "labelP9";
            labelP9.Size = new Size(72, 24);
            labelP9.TabIndex = 3;
            labelP9.Text = "label6";
            labelP9.TextAlign = ContentAlignment.BottomCenter;
            labelP9.Visible = false;
            // 
            // labelP10
            // 
            labelP10.AutoSize = true;
            labelP10.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP10.Location = new Point(808, 303);
            labelP10.Name = "labelP10";
            labelP10.Size = new Size(72, 24);
            labelP10.TabIndex = 4;
            labelP10.Text = "label7";
            labelP10.TextAlign = ContentAlignment.BottomCenter;
            labelP10.Visible = false;
            // 
            // cambiarVariables
            // 
            cambiarVariables.BackColor = SystemColors.GradientActiveCaption;
            cambiarVariables.Enabled = false;
            cambiarVariables.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            cambiarVariables.Location = new Point(94, 462);
            cambiarVariables.Name = "cambiarVariables";
            cambiarVariables.Size = new Size(887, 61);
            cambiarVariables.TabIndex = 6;
            cambiarVariables.Text = "Cambiar variables";
            cambiarVariables.UseVisualStyleBackColor = false;
            cambiarVariables.Click += cambiarVariables_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 28F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 231);
            label3.Name = "label3";
            label3.Size = new Size(896, 57);
            label3.TabIndex = 17;
            label3.Text = "SELECCIONE UNA LISTA DE EJERCICIOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(339, 298);
            label4.Name = "label4";
            label4.Size = new Size(422, 71);
            label4.TabIndex = 18;
            label4.Text = "PARA INICIAR";
            // 
            // botonP1
            // 
            botonP1.BorderColor = Color.FromArgb(220, 223, 230);
            botonP1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP1.DangerColor = Color.FromArgb(245, 108, 108);
            botonP1.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP1.Font = new Font("Segoe UI", 12F);
            botonP1.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP1.InfoColor = Color.FromArgb(144, 147, 153);
            botonP1.Location = new Point(94, 182);
            botonP1.Name = "botonP1";
            botonP1.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP1.Size = new Size(171, 106);
            botonP1.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP1.TabIndex = 19;
            botonP1.Text = "Problema 1";
            botonP1.TextColor = Color.White;
            botonP1.WarningColor = Color.FromArgb(230, 162, 60);
            botonP1.Click += botonP1_Click;
            // 
            // botonP2
            // 
            botonP2.BorderColor = Color.FromArgb(220, 223, 230);
            botonP2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP2.DangerColor = Color.FromArgb(245, 108, 108);
            botonP2.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP2.Font = new Font("Segoe UI", 12F);
            botonP2.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP2.InfoColor = Color.FromArgb(144, 147, 153);
            botonP2.Location = new Point(271, 182);
            botonP2.Name = "botonP2";
            botonP2.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP2.Size = new Size(173, 106);
            botonP2.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP2.TabIndex = 20;
            botonP2.Text = "Problema 2";
            botonP2.TextColor = Color.White;
            botonP2.WarningColor = Color.FromArgb(230, 162, 60);
            botonP2.Click += botonP2_Click;
            // 
            // botonP3
            // 
            botonP3.BorderColor = Color.FromArgb(220, 223, 230);
            botonP3.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP3.DangerColor = Color.FromArgb(245, 108, 108);
            botonP3.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP3.Font = new Font("Segoe UI", 12F);
            botonP3.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP3.InfoColor = Color.FromArgb(144, 147, 153);
            botonP3.Location = new Point(450, 182);
            botonP3.Name = "botonP3";
            botonP3.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP3.Size = new Size(173, 106);
            botonP3.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP3.TabIndex = 21;
            botonP3.Text = "Problema 3";
            botonP3.TextColor = Color.White;
            botonP3.WarningColor = Color.FromArgb(230, 162, 60);
            botonP3.Click += botonP3_Click;
            // 
            // botonP4
            // 
            botonP4.BorderColor = Color.FromArgb(220, 223, 230);
            botonP4.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP4.DangerColor = Color.FromArgb(245, 108, 108);
            botonP4.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP4.Font = new Font("Segoe UI", 12F);
            botonP4.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP4.InfoColor = Color.FromArgb(144, 147, 153);
            botonP4.Location = new Point(629, 182);
            botonP4.Name = "botonP4";
            botonP4.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP4.Size = new Size(173, 106);
            botonP4.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP4.TabIndex = 22;
            botonP4.Text = "Problema 4";
            botonP4.TextColor = Color.White;
            botonP4.WarningColor = Color.FromArgb(230, 162, 60);
            botonP4.Click += botonP4_Click;
            // 
            // botonP5
            // 
            botonP5.BorderColor = Color.FromArgb(220, 223, 230);
            botonP5.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP5.DangerColor = Color.FromArgb(245, 108, 108);
            botonP5.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP5.Font = new Font("Segoe UI", 12F);
            botonP5.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP5.InfoColor = Color.FromArgb(144, 147, 153);
            botonP5.Location = new Point(808, 182);
            botonP5.Name = "botonP5";
            botonP5.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP5.Size = new Size(173, 106);
            botonP5.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP5.TabIndex = 23;
            botonP5.Text = "Problema 5";
            botonP5.TextColor = Color.White;
            botonP5.WarningColor = Color.FromArgb(230, 162, 60);
            botonP5.Click += botonP5_Click;
            // 
            // botonP6
            // 
            botonP6.BorderColor = Color.FromArgb(220, 223, 230);
            botonP6.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP6.DangerColor = Color.FromArgb(245, 108, 108);
            botonP6.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP6.Font = new Font("Segoe UI", 12F);
            botonP6.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP6.InfoColor = Color.FromArgb(144, 147, 153);
            botonP6.Location = new Point(94, 339);
            botonP6.Name = "botonP6";
            botonP6.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP6.Size = new Size(171, 106);
            botonP6.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP6.TabIndex = 24;
            botonP6.Text = "Problema 6";
            botonP6.TextColor = Color.White;
            botonP6.WarningColor = Color.FromArgb(230, 162, 60);
            botonP6.Click += botonP6_Click;
            // 
            // botonP7
            // 
            botonP7.BorderColor = Color.FromArgb(220, 223, 230);
            botonP7.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP7.DangerColor = Color.FromArgb(245, 108, 108);
            botonP7.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP7.Font = new Font("Segoe UI", 12F);
            botonP7.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP7.InfoColor = Color.FromArgb(144, 147, 153);
            botonP7.Location = new Point(271, 339);
            botonP7.Name = "botonP7";
            botonP7.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP7.Size = new Size(173, 106);
            botonP7.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP7.TabIndex = 25;
            botonP7.Text = "Problema 7";
            botonP7.TextColor = Color.White;
            botonP7.WarningColor = Color.FromArgb(230, 162, 60);
            botonP7.Click += botonP7_Click;
            // 
            // botonP8
            // 
            botonP8.BorderColor = Color.FromArgb(220, 223, 230);
            botonP8.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP8.DangerColor = Color.FromArgb(245, 108, 108);
            botonP8.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP8.Font = new Font("Segoe UI", 12F);
            botonP8.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP8.InfoColor = Color.FromArgb(144, 147, 153);
            botonP8.Location = new Point(450, 339);
            botonP8.Name = "botonP8";
            botonP8.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP8.Size = new Size(173, 106);
            botonP8.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP8.TabIndex = 26;
            botonP8.Text = "Problema 8";
            botonP8.TextColor = Color.White;
            botonP8.WarningColor = Color.FromArgb(230, 162, 60);
            botonP8.Click += botonP8_Click;
            // 
            // botonP9
            // 
            botonP9.BorderColor = Color.FromArgb(220, 223, 230);
            botonP9.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP9.DangerColor = Color.FromArgb(245, 108, 108);
            botonP9.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP9.Font = new Font("Segoe UI", 12F);
            botonP9.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP9.InfoColor = Color.FromArgb(144, 147, 153);
            botonP9.Location = new Point(629, 339);
            botonP9.Name = "botonP9";
            botonP9.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP9.Size = new Size(173, 106);
            botonP9.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP9.TabIndex = 27;
            botonP9.Text = "Problema 9";
            botonP9.TextColor = Color.White;
            botonP9.WarningColor = Color.FromArgb(230, 162, 60);
            botonP9.Click += botonP9_Click;
            // 
            // botonP10
            // 
            botonP10.BorderColor = Color.FromArgb(220, 223, 230);
            botonP10.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            botonP10.DangerColor = Color.FromArgb(245, 108, 108);
            botonP10.DefaultColor = Color.FromArgb(255, 255, 255);
            botonP10.Font = new Font("Segoe UI", 12F);
            botonP10.HoverTextColor = Color.FromArgb(48, 49, 51);
            botonP10.InfoColor = Color.FromArgb(144, 147, 153);
            botonP10.Location = new Point(808, 339);
            botonP10.Name = "botonP10";
            botonP10.PrimaryColor = Color.FromArgb(64, 158, 255);
            botonP10.Size = new Size(173, 106);
            botonP10.SuccessColor = Color.FromArgb(103, 194, 58);
            botonP10.TabIndex = 28;
            botonP10.Text = "Problema 10";
            botonP10.TextColor = Color.White;
            botonP10.WarningColor = Color.FromArgb(230, 162, 60);
            botonP10.Click += botonP10_Click;
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
            button1.Location = new Point(92, 126);
            button1.Name = "button1";
            button1.PrimaryColor = Color.FromArgb(64, 158, 255);
            button1.Size = new Size(889, 319);
            button1.SuccessColor = Color.FromArgb(103, 194, 58);
            button1.TabIndex = 29;
            button1.Text = "Modo Desafío";
            button1.TextColor = Color.White;
            button1.WarningColor = Color.FromArgb(230, 162, 60);
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1082, 653);
            Controls.Add(botonP10);
            Controls.Add(botonP9);
            Controls.Add(botonP8);
            Controls.Add(botonP7);
            Controls.Add(botonP6);
            Controls.Add(botonP5);
            Controls.Add(botonP4);
            Controls.Add(botonP3);
            Controls.Add(botonP2);
            Controls.Add(botonP1);
            Controls.Add(label1);
            Controls.Add(labelVidas);
            Controls.Add(botonOpciones);
            Controls.Add(label2);
            Controls.Add(labelP6);
            Controls.Add(LabelResueltos);
            Controls.Add(abrirEnunciados);
            Controls.Add(LabelP2);
            Controls.Add(labelP7);
            Controls.Add(cambiarVariables);
            Controls.Add(labelP8);
            Controls.Add(labelP9);
            Controls.Add(LabelP5);
            Controls.Add(labelP10);
            Controls.Add(LabelP1);
            Controls.Add(LabelP4);
            Controls.Add(LabelP3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Resolución de Ejercicios";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label LabelP1;
        private Label LabelP2;
        private Label LabelP3;
        private Label LabelP4;
        private Label LabelP5;
        private Label labelVidas;
        private Label LabelResueltos;
        private Button abrirEnunciados;
        private Button botonOpciones;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelP6;
        private Label labelP7;
        private Label labelP8;
        private Label labelP9;
        private Label labelP10;
        private Button cambiarVariables;
        private ToolTip toolTip1;
        private Label label3;
        private Label label4;
        private ReaLTaiizor.Controls.HopeButton botonP1;
        private ReaLTaiizor.Controls.HopeButton botonP2;
        private ReaLTaiizor.Controls.HopeButton botonP3;
        private ReaLTaiizor.Controls.HopeButton botonP4;
        private ReaLTaiizor.Controls.HopeButton botonP5;
        private ReaLTaiizor.Controls.HopeButton botonP6;
        private ReaLTaiizor.Controls.HopeButton botonP7;
        private ReaLTaiizor.Controls.HopeButton botonP8;
        private ReaLTaiizor.Controls.HopeButton botonP9;
        private ReaLTaiizor.Controls.HopeButton botonP10;
        private ReaLTaiizor.Controls.HopeButton button1;
    }
}
