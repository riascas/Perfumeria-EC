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
            txtNrodocumento = new System.Windows.Forms.TextBox();
            txtnombrecompleto = new System.Windows.Forms.TextBox();
            textcorreo = new System.Windows.Forms.TextBox();
            textclave = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            cboRol = new System.Windows.Forms.ComboBox();
            label10 = new System.Windows.Forms.Label();
            textconfirmacionclave = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            cboEstado = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(223, 563);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(24, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(23, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(22, 177);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(26, 234);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Contraseña:";
            // 
            // txtNrodocumento
            // 
            txtNrodocumento.Location = new System.Drawing.Point(26, 83);
            txtNrodocumento.Name = "txtNrodocumento";
            txtNrodocumento.Size = new System.Drawing.Size(167, 23);
            txtNrodocumento.TabIndex = 13;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new System.Drawing.Point(26, 142);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new System.Drawing.Size(167, 23);
            txtnombrecompleto.TabIndex = 14;
            // 
            // textcorreo
            // 
            textcorreo.Location = new System.Drawing.Point(26, 195);
            textcorreo.Name = "textcorreo";
            textcorreo.Size = new System.Drawing.Size(166, 23);
            textcorreo.TabIndex = 15;
            // 
            // textclave
            // 
            textclave.Location = new System.Drawing.Point(26, 252);
            textclave.Name = "textclave";
            textclave.Size = new System.Drawing.Size(170, 23);
            textclave.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(23, 288);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(127, 15);
            label9.TabIndex = 5;
            label9.Text = "Confirmar Contraseña:";
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new System.Drawing.Point(27, 362);
            cboRol.Name = "cboRol";
            cboRol.Size = new System.Drawing.Size(166, 23);
            cboRol.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(23, 343);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(27, 15);
            label10.TabIndex = 17;
            label10.Text = "Rol:";
            // 
            // textconfirmacionclave
            // 
            textconfirmacionclave.Location = new System.Drawing.Point(26, 306);
            textconfirmacionclave.Name = "textconfirmacionclave";
            textconfirmacionclave.Size = new System.Drawing.Size(167, 23);
            textconfirmacionclave.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(26, 403);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(45, 15);
            label11.TabIndex = 19;
            label11.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new System.Drawing.Point(26, 421);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new System.Drawing.Size(166, 23);
            cboEstado.TabIndex = 20;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(876, 563);
            Controls.Add(cboEstado);
            Controls.Add(label11);
            Controls.Add(textconfirmacionclave);
            Controls.Add(label10);
            Controls.Add(textclave);
            Controls.Add(textcorreo);
            Controls.Add(txtnombrecompleto);
            Controls.Add(cboRol);
            Controls.Add(txtNrodocumento);
            Controls.Add(label9);
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
        private System.Windows.Forms.TextBox txtNrodocumento;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox textcorreo;
        private System.Windows.Forms.TextBox textclave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textconfirmacionclave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboEstado;
    }
}