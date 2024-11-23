namespace Laboratorio_12._2
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
            txtNota3 = new TextBox();
            lblNota3 = new Label();
            lblPromedio = new Label();
            txtNotaPromedio = new TextBox();
            btnSalir = new Button();
            btnReset = new Button();
            btnPromedio = new Button();
            txtNota2 = new TextBox();
            txtNota1 = new TextBox();
            lblNota2 = new Label();
            lblNota1 = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(198, 172);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(125, 27);
            txtNota3.TabIndex = 23;
            txtNota3.TextChanged += txtNota3_TextChanged;
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(102, 179);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(82, 20);
            lblNota3.TabIndex = 22;
            lblNota3.Text = "NOTA No.3";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(102, 326);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(111, 20);
            lblPromedio.TabIndex = 21;
            lblPromedio.Text = "Nota Promedio";
            // 
            // txtNotaPromedio
            // 
            txtNotaPromedio.Location = new Point(219, 323);
            txtNotaPromedio.Name = "txtNotaPromedio";
            txtNotaPromedio.Size = new Size(125, 27);
            txtNotaPromedio.TabIndex = 20;
            txtNotaPromedio.TextChanged += txtNotaPromedio_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(353, 251);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(229, 251);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(101, 251);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(94, 29);
            btnPromedio.TabIndex = 17;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(198, 125);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(125, 27);
            txtNota2.TabIndex = 16;
            txtNota2.TextChanged += txtNota2_TextChanged;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(198, 77);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(125, 27);
            txtNota1.TabIndex = 15;
            txtNota1.TextChanged += txtNota1_TextChanged;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(102, 132);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(82, 20);
            lblNota2.TabIndex = 14;
            lblNota2.Text = "NOTA No.2";
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(102, 84);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(82, 20);
            lblNota1.TabIndex = 13;
            lblNota1.Text = "NOTA No.1";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(198, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(111, 20);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Nota Promedio";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(txtNota3);
            Controls.Add(lblNota3);
            Controls.Add(lblPromedio);
            Controls.Add(txtNotaPromedio);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnPromedio);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota3;
        private Label lblNota3;
        private Label lblPromedio;
        private TextBox txtNotaPromedio;
        private Button btnSalir;
        private Button btnReset;
        private Button btnPromedio;
        private TextBox txtNota2;
        private TextBox txtNota1;
        private Label lblNota2;
        private Label lblNota1;
        private Label lblTitulo;
    }
}
