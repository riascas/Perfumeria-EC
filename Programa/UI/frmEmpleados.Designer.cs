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
            txtDocumento = new System.Windows.Forms.TextBox();
            txtnombreCompleto = new System.Windows.Forms.TextBox();
            txtcorreo = new System.Windows.Forms.TextBox();
            txtClave = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtconfirmarClave = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cborol = new System.Windows.Forms.ComboBox();
            cboestado = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(225, 605);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(24, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(24, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(24, 151);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(24, 51);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(100, 23);
            txtDocumento.TabIndex = 4;
            // 
            // txtnombreCompleto
            // 
            txtnombreCompleto.Location = new System.Drawing.Point(24, 109);
            txtnombreCompleto.Name = "txtnombreCompleto";
            txtnombreCompleto.Size = new System.Drawing.Size(100, 23);
            txtnombreCompleto.TabIndex = 5;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new System.Drawing.Point(24, 169);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new System.Drawing.Size(100, 23);
            txtcorreo.TabIndex = 6;
            // 
            // txtClave
            // 
            txtClave.Location = new System.Drawing.Point(24, 229);
            txtClave.Name = "txtClave";
            txtClave.Size = new System.Drawing.Size(100, 23);
            txtClave.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(24, 211);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 15);
            label5.TabIndex = 7;
            label5.Text = "Contraseña:";
            // 
            // txtconfirmarClave
            // 
            txtconfirmarClave.Location = new System.Drawing.Point(24, 290);
            txtconfirmarClave.Name = "txtconfirmarClave";
            txtconfirmarClave.Size = new System.Drawing.Size(100, 23);
            txtconfirmarClave.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(24, 272);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(125, 15);
            label6.TabIndex = 9;
            label6.Text = "Confirmar contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(24, 332);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 15);
            label7.TabIndex = 11;
            label7.Text = "Rol:";
            // 
            // cborol
            // 
            cborol.FormattingEnabled = true;
            cborol.Location = new System.Drawing.Point(24, 350);
            cborol.Name = "cborol";
            cborol.Size = new System.Drawing.Size(146, 23);
            cborol.TabIndex = 12;
            // 
            // cboestado
            // 
            cboestado.FormattingEnabled = true;
            cboestado.Location = new System.Drawing.Point(24, 410);
            cboestado.Name = "cboestado";
            cboestado.Size = new System.Drawing.Size(146, 23);
            cboestado.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(24, 392);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(45, 15);
            label8.TabIndex = 13;
            label8.Text = "Estado:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(24, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(146, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(24, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(146, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(24, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(146, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(24, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(146, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(24, 290);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(146, 23);
            textBox5.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(24, 477);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(146, 29);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.ForeColor = System.Drawing.Color.White;
            btnEditar.Location = new System.Drawing.Point(24, 526);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(146, 29);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.Location = new System.Drawing.Point(24, 573);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(146, 29);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(956, 605);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(cboestado);
            Controls.Add(label8);
            Controls.Add(cborol);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(txtconfirmarClave);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(txtClave);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(txtcorreo);
            Controls.Add(textBox2);
            Controls.Add(txtnombreCompleto);
            Controls.Add(textBox1);
            Controls.Add(txtDocumento);
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
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtnombreCompleto;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconfirmarClave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}