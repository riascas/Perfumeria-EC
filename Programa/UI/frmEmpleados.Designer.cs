namespace UI
{
    partial class frmEmpleados
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            comboBox6 = new System.Windows.Forms.ComboBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            textBox6 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(203, 563);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(27, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(26, 109);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(26, 172);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(26, 239);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(26, 314);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(127, 15);
            label6.TabIndex = 5;
            label6.Text = "Confirmar Contraseña:";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new System.Drawing.Point(30, 404);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new System.Drawing.Size(146, 23);
            comboBox6.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(29, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(147, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(29, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(147, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(30, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(146, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(26, 257);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(150, 23);
            textBox5.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(26, 385);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 15);
            label7.TabIndex = 17;
            label7.Text = "Rol:";
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(29, 332);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(147, 23);
            textBox6.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(30, 463);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(45, 15);
            label8.TabIndex = 19;
            label8.Text = "Estado:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(30, 481);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(146, 23);
            comboBox1.TabIndex = 20;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(876, 563);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}