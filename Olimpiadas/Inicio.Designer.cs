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
        private void InitializeComponent() {
            label1 = new Label();
            label3 = new Label();
            botonCrear = new Button();
            botonModificar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(3, 34);
            label1.Name = "label1";
            label1.Size = new Size(568, 25);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido al editor de enunciados!";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(568, 25);
            label3.TabIndex = 2;
            label3.Text = "o desea modificar una existente?";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // botonCrear
            // 
            botonCrear.Dock = DockStyle.Fill;
            botonCrear.Font = new Font("Segoe UI", 12F);
            botonCrear.Location = new Point(3, 2);
            botonCrear.Margin = new Padding(3, 2, 3, 2);
            botonCrear.Name = "botonCrear";
            botonCrear.Size = new Size(278, 49);
            botonCrear.TabIndex = 3;
            botonCrear.Text = "Crear";
            botonCrear.UseVisualStyleBackColor = true;
            botonCrear.Click += botonCrear_Click;
            // 
            // botonModificar
            // 
            botonModificar.Dock = DockStyle.Fill;
            botonModificar.Font = new Font("Segoe UI", 12F);
            botonModificar.Location = new Point(287, 2);
            botonModificar.Margin = new Padding(3, 2, 3, 2);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(278, 49);
            botonModificar.TabIndex = 4;
            botonModificar.Text = "Modificar";
            botonModificar.UseVisualStyleBackColor = true;
            botonModificar.Click += botonModificar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.2676048F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.7323952F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(574, 207);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(botonCrear, 0, 0);
            tableLayoutPanel2.Controls.Add(botonModificar, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 152);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(568, 53);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(568, 37);
            label2.TabIndex = 3;
            label2.Text = "¿Desea crear una nueva lista de enunciados,";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 207);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button botonCrear;
        private Button botonModificar;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
    }
}