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
        private void InitializeComponent()
        {
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
            abrirEnunciados = new ReaLTaiizor.Controls.Button();
            botonOpciones = new ReaLTaiizor.Controls.Button();
            labelP6 = new Label();
            labelP7 = new Label();
            labelP8 = new Label();
            labelP9 = new Label();
            labelP10 = new Label();
            cambiarVariables = new ReaLTaiizor.Controls.Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            label4 = new Label();
            botonP1 = new ReaLTaiizor.Controls.Button();
            botonP2 = new ReaLTaiizor.Controls.Button();
            botonP3 = new ReaLTaiizor.Controls.Button();
            botonP4 = new ReaLTaiizor.Controls.Button();
            botonP5 = new ReaLTaiizor.Controls.Button();
            botonP6 = new ReaLTaiizor.Controls.Button();
            botonP7 = new ReaLTaiizor.Controls.Button();
            botonP8 = new ReaLTaiizor.Controls.Button();
            botonP9 = new ReaLTaiizor.Controls.Button();
            botonP10 = new ReaLTaiizor.Controls.Button();
            button1 = new ReaLTaiizor.Controls.Button();
            cambiarEnunciados = new ReaLTaiizor.Controls.Button();
            backColor = new RichTextBox();
            abrirEnunciados2 = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold);
            label1.Location = new Point(128, 407);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 5;
            label1.Text = "Vidas Restantes: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold);
            label2.Location = new Point(129, 447);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 6;
            label2.Text = "Resueltos:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelP1
            // 
            LabelP1.AutoSize = true;
            LabelP1.BackColor = Color.Transparent;
            LabelP1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP1.ForeColor = Color.LimeGreen;
            LabelP1.Location = new Point(107, 67);
            LabelP1.Name = "LabelP1";
            LabelP1.Size = new Size(42, 19);
            LabelP1.TabIndex = 8;
            LabelP1.Text = "¡OK!";
            LabelP1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelP2
            // 
            LabelP2.AutoSize = true;
            LabelP2.BackColor = Color.Transparent;
            LabelP2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP2.ForeColor = Color.Red;
            LabelP2.Location = new Point(255, 67);
            LabelP2.Name = "LabelP2";
            LabelP2.Size = new Size(31, 19);
            LabelP2.TabIndex = 9;
            LabelP2.Text = "No";
            LabelP2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelP3
            // 
            LabelP3.AutoSize = true;
            LabelP3.BackColor = Color.Transparent;
            LabelP3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP3.ForeColor = Color.Red;
            LabelP3.Location = new Point(403, 67);
            LabelP3.Name = "LabelP3";
            LabelP3.Size = new Size(31, 19);
            LabelP3.TabIndex = 10;
            LabelP3.Text = "No";
            LabelP3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelP4
            // 
            LabelP4.AutoSize = true;
            LabelP4.BackColor = Color.Transparent;
            LabelP4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP4.ForeColor = Color.Red;
            LabelP4.Location = new Point(552, 67);
            LabelP4.Name = "LabelP4";
            LabelP4.Size = new Size(31, 19);
            LabelP4.TabIndex = 11;
            LabelP4.Text = "No";
            LabelP4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LabelP5
            // 
            LabelP5.AutoSize = true;
            LabelP5.BackColor = Color.Transparent;
            LabelP5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            LabelP5.ForeColor = Color.Red;
            LabelP5.Location = new Point(698, 67);
            LabelP5.Name = "LabelP5";
            LabelP5.Size = new Size(31, 19);
            LabelP5.TabIndex = 12;
            LabelP5.Text = "No";
            LabelP5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelVidas
            // 
            labelVidas.AutoSize = true;
            labelVidas.BackColor = SystemColors.InactiveCaption;
            labelVidas.BorderStyle = BorderStyle.Fixed3D;
            labelVidas.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold);
            labelVidas.Location = new Point(318, 407);
            labelVidas.Name = "labelVidas";
            labelVidas.Size = new Size(28, 32);
            labelVidas.TabIndex = 13;
            labelVidas.Text = "0";
            labelVidas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelResueltos
            // 
            LabelResueltos.AutoSize = true;
            LabelResueltos.BackColor = SystemColors.InactiveCaption;
            LabelResueltos.BorderStyle = BorderStyle.Fixed3D;
            LabelResueltos.Font = new Font("Segoe UI", 16.25F, FontStyle.Bold);
            LabelResueltos.Location = new Point(318, 445);
            LabelResueltos.Name = "LabelResueltos";
            LabelResueltos.Size = new Size(28, 32);
            LabelResueltos.TabIndex = 14;
            LabelResueltos.Text = "0";
            LabelResueltos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // abrirEnunciados
            // 
            abrirEnunciados.BackColor = SystemColors.GradientActiveCaption;
            abrirEnunciados.BorderColor = Color.FromArgb(32, 34, 37);
            abrirEnunciados.EnteredBorderColor = Color.Black;
            abrirEnunciados.EnteredColor = SystemColors.ActiveCaption;
            abrirEnunciados.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            abrirEnunciados.Image = null;
            abrirEnunciados.ImageAlign = ContentAlignment.MiddleLeft;
            abrirEnunciados.InactiveColor = SystemColors.InactiveCaption;
            abrirEnunciados.Location = new Point(363, 407);
            abrirEnunciados.Name = "abrirEnunciados";
            abrirEnunciados.PressedBorderColor = SystemColors.Highlight;
            abrirEnunciados.PressedColor = SystemColors.Highlight;
            abrirEnunciados.Size = new Size(472, 35);
            abrirEnunciados.TabIndex = 15;
            abrirEnunciados.Text = "Practicar";
            abrirEnunciados.TextAlignment = StringAlignment.Center;
            abrirEnunciados.Click += button1_Click;
            // 
            // botonOpciones
            // 
            botonOpciones.BackColor = SystemColors.GradientActiveCaption;
            botonOpciones.BorderColor = Color.FromArgb(32, 34, 37);
            botonOpciones.Enabled = false;
            botonOpciones.EnteredBorderColor = Color.Black;
            botonOpciones.EnteredColor = SystemColors.ActiveCaption;
            botonOpciones.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            botonOpciones.Image = null;
            botonOpciones.ImageAlign = ContentAlignment.MiddleLeft;
            botonOpciones.InactiveColor = SystemColors.InactiveCaption;
            botonOpciones.Location = new Point(363, 447);
            botonOpciones.Margin = new Padding(3, 2, 3, 2);
            botonOpciones.Name = "botonOpciones";
            botonOpciones.PressedBorderColor = SystemColors.Highlight;
            botonOpciones.PressedColor = SystemColors.Highlight;
            botonOpciones.Size = new Size(472, 35);
            botonOpciones.TabIndex = 16;
            botonOpciones.Text = "Ajustar Dificultad";
            botonOpciones.TextAlignment = StringAlignment.Center;
            botonOpciones.Click += botonOpciones_Click;
            // 
            // labelP6
            // 
            labelP6.AutoSize = true;
            labelP6.BackColor = Color.Transparent;
            labelP6.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP6.Location = new Point(107, 194);
            labelP6.Name = "labelP6";
            labelP6.Size = new Size(59, 19);
            labelP6.TabIndex = 0;
            labelP6.Text = "label3";
            labelP6.TextAlign = ContentAlignment.BottomCenter;
            labelP6.Visible = false;
            // 
            // labelP7
            // 
            labelP7.AutoSize = true;
            labelP7.BackColor = Color.Transparent;
            labelP7.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP7.Location = new Point(255, 194);
            labelP7.Name = "labelP7";
            labelP7.Size = new Size(59, 19);
            labelP7.TabIndex = 1;
            labelP7.Text = "label4";
            labelP7.TextAlign = ContentAlignment.BottomCenter;
            labelP7.Visible = false;
            // 
            // labelP8
            // 
            labelP8.AutoSize = true;
            labelP8.BackColor = Color.Transparent;
            labelP8.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP8.Location = new Point(403, 194);
            labelP8.Name = "labelP8";
            labelP8.Size = new Size(59, 19);
            labelP8.TabIndex = 2;
            labelP8.Text = "label5";
            labelP8.TextAlign = ContentAlignment.BottomCenter;
            labelP8.Visible = false;
            // 
            // labelP9
            // 
            labelP9.AutoSize = true;
            labelP9.BackColor = Color.Transparent;
            labelP9.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP9.Location = new Point(552, 194);
            labelP9.Name = "labelP9";
            labelP9.Size = new Size(59, 19);
            labelP9.TabIndex = 3;
            labelP9.Text = "label6";
            labelP9.TextAlign = ContentAlignment.BottomCenter;
            labelP9.Visible = false;
            // 
            // labelP10
            // 
            labelP10.AutoSize = true;
            labelP10.BackColor = Color.Transparent;
            labelP10.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelP10.Location = new Point(698, 194);
            labelP10.Name = "labelP10";
            labelP10.Size = new Size(59, 19);
            labelP10.TabIndex = 4;
            labelP10.Text = "label7";
            labelP10.TextAlign = ContentAlignment.BottomCenter;
            labelP10.Visible = false;
            // 
            // cambiarVariables
            // 
            cambiarVariables.BackColor = SystemColors.GradientActiveCaption;
            cambiarVariables.BorderColor = Color.Black;
            cambiarVariables.Enabled = false;
            cambiarVariables.EnteredBorderColor = Color.Black;
            cambiarVariables.EnteredColor = SystemColors.ActiveCaption;
            cambiarVariables.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            cambiarVariables.Image = null;
            cambiarVariables.ImageAlign = ContentAlignment.MiddleLeft;
            cambiarVariables.InactiveColor = SystemColors.InactiveCaption;
            cambiarVariables.Location = new Point(117, 357);
            cambiarVariables.Margin = new Padding(3, 2, 3, 2);
            cambiarVariables.Name = "cambiarVariables";
            cambiarVariables.PressedBorderColor = SystemColors.Highlight;
            cambiarVariables.PressedColor = SystemColors.Highlight;
            cambiarVariables.Size = new Size(718, 44);
            cambiarVariables.TabIndex = 6;
            cambiarVariables.Text = "Cambiar Variables";
            cambiarVariables.TextAlignment = StringAlignment.Center;
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
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 208);
            label3.Name = "label3";
            label3.Size = new Size(702, 50);
            label3.TabIndex = 17;
            label3.Text = "SELECCIONE UNA LISTA DE EJERCICIOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(298, 147);
            label4.Name = "label4";
            label4.Size = new Size(340, 56);
            label4.TabIndex = 18;
            label4.Text = "PARA INICIAR";
            // 
            // botonP1
            // 
            botonP1.BackColor = Color.Transparent;
            botonP1.BorderColor = Color.White;
            botonP1.EnteredBorderColor = Color.Black;
            botonP1.EnteredColor = SystemColors.ActiveCaption;
            botonP1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP1.Image = null;
            botonP1.ImageAlign = ContentAlignment.MiddleLeft;
            botonP1.InactiveColor = SystemColors.InactiveCaption;
            botonP1.Location = new Point(117, 93);
            botonP1.Margin = new Padding(3, 2, 3, 2);
            botonP1.Name = "botonP1";
            botonP1.PressedBorderColor = SystemColors.Highlight;
            botonP1.PressedColor = SystemColors.Highlight;
            botonP1.Size = new Size(115, 80);
            botonP1.TabIndex = 19;
            botonP1.Text = "Problema 1";
            botonP1.TextAlignment = StringAlignment.Center;
            botonP1.Click += botonP1_Click;
            // 
            // botonP2
            // 
            botonP2.BackColor = Color.Transparent;
            botonP2.BorderColor = Color.White;
            botonP2.EnteredBorderColor = Color.Black;
            botonP2.EnteredColor = SystemColors.ActiveCaption;
            botonP2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP2.Image = null;
            botonP2.ImageAlign = ContentAlignment.MiddleLeft;
            botonP2.InactiveColor = SystemColors.InactiveCaption;
            botonP2.Location = new Point(264, 93);
            botonP2.Margin = new Padding(3, 2, 3, 2);
            botonP2.Name = "botonP2";
            botonP2.PressedBorderColor = SystemColors.Highlight;
            botonP2.PressedColor = SystemColors.Highlight;
            botonP2.Size = new Size(115, 80);
            botonP2.TabIndex = 20;
            botonP2.Text = "Problema 2";
            botonP2.TextAlignment = StringAlignment.Center;
            botonP2.Click += botonP2_Click;
            // 
            // botonP3
            // 
            botonP3.BackColor = Color.Transparent;
            botonP3.BorderColor = Color.White;
            botonP3.EnteredBorderColor = Color.Black;
            botonP3.EnteredColor = SystemColors.ActiveCaption;
            botonP3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP3.Image = null;
            botonP3.ImageAlign = ContentAlignment.MiddleLeft;
            botonP3.InactiveColor = SystemColors.InactiveCaption;
            botonP3.Location = new Point(412, 93);
            botonP3.Margin = new Padding(3, 2, 3, 2);
            botonP3.Name = "botonP3";
            botonP3.PressedBorderColor = SystemColors.Highlight;
            botonP3.PressedColor = SystemColors.Highlight;
            botonP3.Size = new Size(115, 80);
            botonP3.TabIndex = 21;
            botonP3.Text = "Problema 3";
            botonP3.TextAlignment = StringAlignment.Center;
            botonP3.Click += botonP3_Click;
            // 
            // botonP4
            // 
            botonP4.BackColor = Color.Transparent;
            botonP4.BorderColor = Color.White;
            botonP4.EnteredBorderColor = Color.Black;
            botonP4.EnteredColor = SystemColors.ActiveCaption;
            botonP4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP4.Image = null;
            botonP4.ImageAlign = ContentAlignment.MiddleLeft;
            botonP4.InactiveColor = SystemColors.InactiveCaption;
            botonP4.Location = new Point(563, 93);
            botonP4.Margin = new Padding(3, 2, 3, 2);
            botonP4.Name = "botonP4";
            botonP4.PressedBorderColor = SystemColors.Highlight;
            botonP4.PressedColor = SystemColors.Highlight;
            botonP4.Size = new Size(115, 80);
            botonP4.TabIndex = 22;
            botonP4.Text = "Problema 4";
            botonP4.TextAlignment = StringAlignment.Center;
            botonP4.Click += botonP4_Click;
            // 
            // botonP5
            // 
            botonP5.BackColor = Color.Transparent;
            botonP5.BorderColor = Color.White;
            botonP5.EnteredBorderColor = Color.Black;
            botonP5.EnteredColor = SystemColors.ActiveCaption;
            botonP5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP5.Image = null;
            botonP5.ImageAlign = ContentAlignment.MiddleLeft;
            botonP5.InactiveColor = SystemColors.InactiveCaption;
            botonP5.Location = new Point(707, 93);
            botonP5.Margin = new Padding(3, 2, 3, 2);
            botonP5.Name = "botonP5";
            botonP5.PressedBorderColor = SystemColors.Highlight;
            botonP5.PressedColor = SystemColors.Highlight;
            botonP5.Size = new Size(115, 80);
            botonP5.TabIndex = 23;
            botonP5.Text = "Problema 5";
            botonP5.TextAlignment = StringAlignment.Center;
            botonP5.Click += botonP5_Click;
            // 
            // botonP6
            // 
            botonP6.BackColor = Color.Transparent;
            botonP6.BorderColor = Color.White;
            botonP6.EnteredBorderColor = Color.Black;
            botonP6.EnteredColor = SystemColors.ActiveCaption;
            botonP6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP6.Image = null;
            botonP6.ImageAlign = ContentAlignment.MiddleLeft;
            botonP6.InactiveColor = SystemColors.InactiveCaption;
            botonP6.Location = new Point(117, 221);
            botonP6.Margin = new Padding(3, 2, 3, 2);
            botonP6.Name = "botonP6";
            botonP6.PressedBorderColor = SystemColors.Highlight;
            botonP6.PressedColor = SystemColors.Highlight;
            botonP6.Size = new Size(115, 80);
            botonP6.TabIndex = 24;
            botonP6.Text = "Problema 6";
            botonP6.TextAlignment = StringAlignment.Center;
            botonP6.Click += botonP6_Click;
            // 
            // botonP7
            // 
            botonP7.BackColor = Color.Transparent;
            botonP7.BorderColor = Color.White;
            botonP7.EnteredBorderColor = Color.Black;
            botonP7.EnteredColor = SystemColors.ActiveCaption;
            botonP7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP7.Image = null;
            botonP7.ImageAlign = ContentAlignment.MiddleLeft;
            botonP7.InactiveColor = SystemColors.InactiveCaption;
            botonP7.Location = new Point(264, 220);
            botonP7.Margin = new Padding(3, 2, 3, 2);
            botonP7.Name = "botonP7";
            botonP7.PressedBorderColor = SystemColors.Highlight;
            botonP7.PressedColor = SystemColors.Highlight;
            botonP7.Size = new Size(115, 80);
            botonP7.TabIndex = 25;
            botonP7.Text = "Problema 7";
            botonP7.TextAlignment = StringAlignment.Center;
            botonP7.Click += botonP7_Click;
            // 
            // botonP8
            // 
            botonP8.BackColor = Color.Transparent;
            botonP8.BorderColor = Color.White;
            botonP8.EnteredBorderColor = Color.Black;
            botonP8.EnteredColor = SystemColors.ActiveCaption;
            botonP8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP8.Image = null;
            botonP8.ImageAlign = ContentAlignment.MiddleLeft;
            botonP8.InactiveColor = SystemColors.InactiveCaption;
            botonP8.Location = new Point(412, 221);
            botonP8.Margin = new Padding(3, 2, 3, 2);
            botonP8.Name = "botonP8";
            botonP8.PressedBorderColor = SystemColors.Highlight;
            botonP8.PressedColor = SystemColors.Highlight;
            botonP8.Size = new Size(115, 80);
            botonP8.TabIndex = 26;
            botonP8.Text = "Problema 8";
            botonP8.TextAlignment = StringAlignment.Center;
            botonP8.Click += botonP8_Click;
            // 
            // botonP9
            // 
            botonP9.BackColor = Color.Transparent;
            botonP9.BorderColor = Color.White;
            botonP9.EnteredBorderColor = Color.Black;
            botonP9.EnteredColor = SystemColors.ActiveCaption;
            botonP9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP9.Image = null;
            botonP9.ImageAlign = ContentAlignment.MiddleLeft;
            botonP9.InactiveColor = SystemColors.InactiveCaption;
            botonP9.Location = new Point(563, 220);
            botonP9.Margin = new Padding(3, 2, 3, 2);
            botonP9.Name = "botonP9";
            botonP9.PressedBorderColor = SystemColors.Highlight;
            botonP9.PressedColor = SystemColors.Highlight;
            botonP9.Size = new Size(115, 80);
            botonP9.TabIndex = 27;
            botonP9.Text = "Problema 9";
            botonP9.TextAlignment = StringAlignment.Center;
            botonP9.Click += botonP9_Click;
            // 
            // botonP10
            // 
            botonP10.BackColor = Color.Transparent;
            botonP10.BorderColor = Color.White;
            botonP10.EnteredBorderColor = Color.Black;
            botonP10.EnteredColor = SystemColors.ActiveCaption;
            botonP10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            botonP10.Image = null;
            botonP10.ImageAlign = ContentAlignment.MiddleLeft;
            botonP10.InactiveColor = SystemColors.InactiveCaption;
            botonP10.Location = new Point(707, 221);
            botonP10.Margin = new Padding(3, 2, 3, 2);
            botonP10.Name = "botonP10";
            botonP10.PressedBorderColor = SystemColors.Highlight;
            botonP10.PressedColor = SystemColors.Highlight;
            botonP10.Size = new Size(115, 80);
            botonP10.TabIndex = 28;
            botonP10.Text = "Problema 10";
            botonP10.TextAlignment = StringAlignment.Center;
            botonP10.Click += botonP10_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.White;
            button1.EnteredBorderColor = Color.Black;
            button1.EnteredColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = SystemColors.InactiveCaption;
            button1.Location = new Point(117, 98);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.PressedBorderColor = SystemColors.Highlight;
            button1.PressedColor = SystemColors.Highlight;
            button1.Size = new Size(718, 203);
            button1.TabIndex = 29;
            button1.Text = "Modo Desafío";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click_1;
            // 
            // cambiarEnunciados
            // 
            cambiarEnunciados.BackColor = Color.Transparent;
            cambiarEnunciados.BorderColor = Color.FromArgb(32, 34, 37);
            cambiarEnunciados.EnteredBorderColor = Color.Black;
            cambiarEnunciados.EnteredColor = SystemColors.ActiveCaption;
            cambiarEnunciados.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cambiarEnunciados.Image = null;
            cambiarEnunciados.ImageAlign = ContentAlignment.MiddleLeft;
            cambiarEnunciados.InactiveColor = SystemColors.InactiveCaption;
            cambiarEnunciados.Location = new Point(117, 357);
            cambiarEnunciados.Name = "cambiarEnunciados";
            cambiarEnunciados.PressedBorderColor = SystemColors.Highlight;
            cambiarEnunciados.PressedColor = SystemColors.Highlight;
            cambiarEnunciados.Size = new Size(229, 44);
            cambiarEnunciados.TabIndex = 30;
            cambiarEnunciados.Text = "Cambiar Enunciados";
            cambiarEnunciados.TextAlignment = StringAlignment.Center;
            cambiarEnunciados.Visible = false;
            cambiarEnunciados.Click += cambiarEnunciados_Click;
            // 
            // backColor
            // 
            backColor.BackColor = SystemColors.InactiveCaption;
            backColor.Location = new Point(118, 407);
            backColor.Name = "backColor";
            backColor.Size = new Size(229, 71);
            backColor.TabIndex = 31;
            backColor.Text = "";
            backColor.Visible = false;
            // 
            // abrirEnunciados2
            // 
            abrirEnunciados2.BackColor = SystemColors.GradientActiveCaption;
            abrirEnunciados2.BorderColor = Color.FromArgb(32, 34, 37);
            abrirEnunciados2.EnteredBorderColor = Color.Black;
            abrirEnunciados2.EnteredColor = SystemColors.ActiveCaption;
            abrirEnunciados2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            abrirEnunciados2.Image = null;
            abrirEnunciados2.ImageAlign = ContentAlignment.MiddleLeft;
            abrirEnunciados2.InactiveColor = SystemColors.InactiveCaption;
            abrirEnunciados2.Location = new Point(480, 374);
            abrirEnunciados2.Name = "abrirEnunciados2";
            abrirEnunciados2.PressedBorderColor = SystemColors.Highlight;
            abrirEnunciados2.PressedColor = SystemColors.Highlight;
            abrirEnunciados2.Size = new Size(353, 75);
            abrirEnunciados2.TabIndex = 32;
            abrirEnunciados2.Text = "Olimpiadas";
            abrirEnunciados2.TextAlignment = StringAlignment.Center;
            abrirEnunciados2.Click += abrirEnunciados2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(947, 490);
            Controls.Add(abrirEnunciados2);
            Controls.Add(cambiarEnunciados);
            Controls.Add(label4);
            Controls.Add(label3);
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
            Controls.Add(button1);
            Controls.Add(backColor);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ReaLTaiizor.Controls.Button abrirEnunciados;
        private ReaLTaiizor.Controls.Button botonOpciones;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelP6;
        private Label labelP7;
        private Label labelP8;
        private Label labelP9;
        private Label labelP10;
        private ReaLTaiizor.Controls.Button cambiarVariables;
        private ToolTip toolTip1;
        private Label label3;
        private Label label4;
        private ReaLTaiizor.Controls.Button botonP1;
        private ReaLTaiizor.Controls.Button botonP2;
        private ReaLTaiizor.Controls.Button botonP3;
        private ReaLTaiizor.Controls.Button botonP4;
        private ReaLTaiizor.Controls.Button botonP5;
        private ReaLTaiizor.Controls.Button botonP6;
        private ReaLTaiizor.Controls.Button botonP7;
        private ReaLTaiizor.Controls.Button botonP8;
        private ReaLTaiizor.Controls.Button botonP9;
        private ReaLTaiizor.Controls.Button botonP10;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button cambiarEnunciados;
        private RichTextBox backColor;
        private ReaLTaiizor.Controls.Button abrirEnunciados2;
    }
}
