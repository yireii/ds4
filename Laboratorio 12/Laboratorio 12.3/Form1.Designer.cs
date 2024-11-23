
namespace Laboratorio_12._3
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
            txtLadoA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLadoB = new TextBox();
            label3 = new Label();
            txtLadoC = new TextBox();
            btnSemi = new Button();
            btnArea = new Button();
            btnReset = new Button();
            btnSalida = new Button();
            label4 = new Label();
            txtCalcSemi = new TextBox();
            label5 = new Label();
            txtAreaTrian = new TextBox();
            SuspendLayout();
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(216, 44);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(125, 27);
            txtLadoA.TabIndex = 0;
            txtLadoA.TextChanged += txtLadoA_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 51);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingresar lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 97);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Ingresar lado B";
            label2.Click += label2_Click;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(216, 90);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(125, 27);
            txtLadoB.TabIndex = 2;
            txtLadoB.TextChanged += txtLadoB_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 148);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 5;
            label3.Text = "Ingresar lado C";
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(216, 141);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(125, 27);
            txtLadoC.TabIndex = 4;
            txtLadoC.TextChanged += txtLadoC_TextChanged;
            // 
            // btnSemi
            // 
            btnSemi.Location = new Point(88, 216);
            btnSemi.Name = "btnSemi";
            btnSemi.Size = new Size(119, 47);
            btnSemi.TabIndex = 6;
            btnSemi.Text = "Semiperimetro";
            btnSemi.UseVisualStyleBackColor = true;
            btnSemi.Click += btnSemi_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(222, 216);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(119, 47);
            btnArea.TabIndex = 7;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(359, 216);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(119, 47);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(502, 216);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(119, 47);
            btnSalida.TabIndex = 9;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 298);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 11;
            label4.Text = "Calcular Semiperimentro";
            // 
            // txtCalcSemi
            // 
            txtCalcSemi.Location = new Point(271, 295);
            txtCalcSemi.Name = "txtCalcSemi";
            txtCalcSemi.Size = new Size(125, 27);
            txtCalcSemi.TabIndex = 10;
            txtCalcSemi.TextChanged += txtCalcSemi_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 361);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 13;
            label5.Text = "Area Triangulo";
            // 
            // txtAreaTrian
            // 
            txtAreaTrian.Location = new Point(271, 358);
            txtAreaTrian.Name = "txtAreaTrian";
            txtAreaTrian.Size = new Size(125, 27);
            txtAreaTrian.TabIndex = 12;
            txtAreaTrian.TextChanged += txtAreaTrian_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtAreaTrian);
            Controls.Add(label4);
            Controls.Add(txtCalcSemi);
            Controls.Add(btnSalida);
            Controls.Add(btnReset);
            Controls.Add(btnArea);
            Controls.Add(btnSemi);
            Controls.Add(label3);
            Controls.Add(txtLadoC);
            Controls.Add(label2);
            Controls.Add(txtLadoB);
            Controls.Add(label1);
            Controls.Add(txtLadoA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtLadoA;
        private Label label1;
        private Label label2;
        private TextBox txtLadoB;
        private Label label3;
        private TextBox txtLadoC;
        private Button btnSemi;
        private Button btnArea;
        private Button btnReset;
        private Button btnSalida;
        private Label label4;
        private TextBox txtCalcSemi;
        private Label label5;
        private TextBox txtAreaTrian;
    }
}
