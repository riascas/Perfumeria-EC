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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cborol = new System.Windows.Forms.ComboBox();
            cboestado = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            txtNrodocumento = new System.Windows.Forms.TextBox();
            textnombreCompleto = new System.Windows.Forms.TextBox();
            textCorreo = new System.Windows.Forms.TextBox();
            textClave = new System.Windows.Forms.TextBox();
            textconfirmarClave = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label10 = new System.Windows.Forms.Label();
            txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(309, 675);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(24, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Nro Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(24, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(24, 187);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(24, 247);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 15);
            label5.TabIndex = 7;
            label5.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(24, 308);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(125, 15);
            label6.TabIndex = 9;
            label6.Text = "Confirmar contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(24, 368);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(27, 15);
            label7.TabIndex = 11;
            label7.Text = "Rol:";
            // 
            // cborol
            // 
            cborol.FormattingEnabled = true;
            cborol.Location = new System.Drawing.Point(24, 386);
            cborol.Name = "cborol";
            cborol.Size = new System.Drawing.Size(219, 23);
            cborol.TabIndex = 12;
            // 
            // cboestado
            // 
            cboestado.FormattingEnabled = true;
            cboestado.Location = new System.Drawing.Point(24, 446);
            cboestado.Name = "cboestado";
            cboestado.Size = new System.Drawing.Size(219, 23);
            cboestado.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(24, 428);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(45, 15);
            label8.TabIndex = 13;
            label8.Text = "Estado:";
            // 
            // txtNrodocumento
            // 
            txtNrodocumento.Location = new System.Drawing.Point(24, 87);
            txtNrodocumento.Name = "txtNrodocumento";
            txtNrodocumento.Size = new System.Drawing.Size(219, 23);
            txtNrodocumento.TabIndex = 4;
            // 
            // textnombreCompleto
            // 
            textnombreCompleto.Location = new System.Drawing.Point(24, 145);
            textnombreCompleto.Name = "textnombreCompleto";
            textnombreCompleto.Size = new System.Drawing.Size(219, 23);
            textnombreCompleto.TabIndex = 5;
            // 
            // textCorreo
            // 
            textCorreo.Location = new System.Drawing.Point(24, 205);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new System.Drawing.Size(219, 23);
            textCorreo.TabIndex = 6;
            // 
            // textClave
            // 
            textClave.Location = new System.Drawing.Point(24, 265);
            textClave.Name = "textClave";
            textClave.Size = new System.Drawing.Size(219, 23);
            textClave.TabIndex = 8;
            // 
            // textconfirmarClave
            // 
            textconfirmarClave.Location = new System.Drawing.Point(24, 326);
            textconfirmarClave.Name = "textconfirmarClave";
            textconfirmarClave.Size = new System.Drawing.Size(219, 23);
            textconfirmarClave.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Location = new System.Drawing.Point(24, 513);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(219, 29);
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
            btnEditar.Location = new System.Drawing.Point(24, 562);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(219, 29);
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
            btnEliminar.Location = new System.Drawing.Point(24, 609);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(219, 29);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.White;
            label9.Font = new System.Drawing.Font("Sans Serif Collection", 14.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(24, 9);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(231, 49);
            label9.TabIndex = 18;
            label9.Text = "Detalle usuario";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { btnseleccionar, IdUsuario, Documento, NombreCompleto, Correo, Clave, IdRol, Rol, Estado, EstadoValor });
            dataGridView1.Location = new System.Drawing.Point(337, 145);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new System.Drawing.Size(808, 432);
            dataGridView1.TabIndex = 19;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 50;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
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
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // label10
            // 
            label10.BackColor = System.Drawing.Color.White;
            label10.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(337, 35);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(800, 45);
            label10.TabIndex = 20;
            label10.Text = "Lista de usuarios:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            txtid.Location = new System.Drawing.Point(212, 57);
            txtid.Name = "txtid";
            txtid.Size = new System.Drawing.Size(31, 23);
            txtid.TabIndex = 21;
            txtid.Visible = false;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1187, 675);
            Controls.Add(txtid);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(cboestado);
            Controls.Add(label8);
            Controls.Add(cborol);
            Controls.Add(label7);
            Controls.Add(textconfirmarClave);
            Controls.Add(label6);
            Controls.Add(textClave);
            Controls.Add(label5);
            Controls.Add(textCorreo);
            Controls.Add(textnombreCompleto);
            Controls.Add(txtNrodocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNrodocumento;
        private System.Windows.Forms.TextBox textnombreCompleto;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.TextBox textconfirmarClave;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.TextBox txtid;
    }
}