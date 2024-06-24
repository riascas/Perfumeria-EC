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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            btnguardar = new System.Windows.Forms.Button();
            btneditar = new System.Windows.Forms.Button();
            btneliminar = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            textidRol = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label7 = new System.Windows.Forms.Label();
            idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            Nrodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(223, 624);
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
            // btnguardar
            // 
            btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnguardar.ForeColor = System.Drawing.Color.White;
            btnguardar.Location = new System.Drawing.Point(27, 482);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new System.Drawing.Size(165, 29);
            btnguardar.TabIndex = 21;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            // 
            // btneditar
            // 
            btneditar.BackColor = System.Drawing.Color.RoyalBlue;
            btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btneditar.ForeColor = System.Drawing.Color.White;
            btneditar.Location = new System.Drawing.Point(27, 521);
            btneditar.Name = "btneditar";
            btneditar.Size = new System.Drawing.Size(165, 29);
            btneditar.TabIndex = 22;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = System.Drawing.Color.Firebrick;
            btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btneliminar.ForeColor = System.Drawing.Color.White;
            btneliminar.Location = new System.Drawing.Point(27, 560);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new System.Drawing.Size(165, 29);
            btneliminar.TabIndex = 23;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label6.Font = new System.Drawing.Font("Sans Serif Collection", 11.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(12, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(197, 41);
            label6.TabIndex = 24;
            label6.Text = "Detalle usuario";
            // 
            // textidRol
            // 
            textidRol.Location = new System.Drawing.Point(169, 54);
            textidRol.Name = "textidRol";
            textidRol.Size = new System.Drawing.Size(24, 23);
            textidRol.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idUsuario, btnseleccionar, Nrodocumento, Nombrecompleto, Correo, Clave, IdRol, Rol, Estado, EstadoValor });
            dataGridView1.Location = new System.Drawing.Point(262, 125);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new System.Drawing.Size(811, 446);
            dataGridView1.TabIndex = 26;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.White;
            label7.Font = new System.Drawing.Font("Sans Serif Collection", 11.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(262, 57);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(811, 37);
            label7.TabIndex = 27;
            label7.Text = "Lista de usuarios:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idUsuario
            // 
            idUsuario.HeaderText = "idUsuario";
            idUsuario.Name = "idUsuario";
            idUsuario.ReadOnly = true;
            idUsuario.Visible = false;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 30;
            // 
            // Nrodocumento
            // 
            Nrodocumento.HeaderText = "Nro documento";
            Nrodocumento.Name = "Nrodocumento";
            Nrodocumento.ReadOnly = true;
            Nrodocumento.Width = 150;
            // 
            // Nombrecompleto
            // 
            Nombrecompleto.HeaderText = "Nombre completo";
            Nombrecompleto.Name = "Nombrecompleto";
            Nombrecompleto.ReadOnly = true;
            Nombrecompleto.Width = 180;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "Estado Valor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1130, 624);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(textidRol);
            Controls.Add(label6);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(btnguardar);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textidRol;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nrodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrecompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}