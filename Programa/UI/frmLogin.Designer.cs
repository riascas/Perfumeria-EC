namespace UI
{
    partial class frmLogin
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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            tboxUsuario = new System.Windows.Forms.TextBox();
            tboxClave = new System.Windows.Forms.TextBox();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.DarkKhaki;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 177);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 21);
            label2.TabIndex = 1;
            label2.Text = "Perfumeria \"Cosmos\"";
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.DarkKhaki;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(202, 274);
            label1.TabIndex = 0;
            label1.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.DarkKhaki;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(12, 198);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 21);
            label3.TabIndex = 2;
            label3.Text = "Sistema de Gestion";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.DarkKhaki;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Computer;
            iconPictureBox1.IconColor = System.Drawing.Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 109;
            iconPictureBox1.Location = new System.Drawing.Point(40, 57);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new System.Drawing.Size(109, 117);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(253, 44);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 20);
            label4.TabIndex = 4;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(253, 121);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 20);
            label5.TabIndex = 5;
            label5.Text = "Clave:";
            // 
            // tboxUsuario
            // 
            tboxUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tboxUsuario.Location = new System.Drawing.Point(253, 67);
            tboxUsuario.Name = "tboxUsuario";
            tboxUsuario.Size = new System.Drawing.Size(223, 27);
            tboxUsuario.TabIndex = 6;
            // 
            // tboxClave
            // 
            tboxClave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tboxClave.Location = new System.Drawing.Point(253, 144);
            tboxClave.Name = "tboxClave";
            tboxClave.PasswordChar = '*';
            tboxClave.Size = new System.Drawing.Size(223, 27);
            tboxClave.TabIndex = 7;
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnIngresar.IconColor = System.Drawing.Color.DarkGreen;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.Location = new System.Drawing.Point(270, 204);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(90, 40);
            btnIngresar.TabIndex = 8;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnSalir.IconColor = System.Drawing.Color.Red;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new System.Drawing.Point(391, 204);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(85, 40);
            btnSalir.TabIndex = 9;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(542, 274);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(tboxClave);
            Controls.Add(tboxUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(iconPictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxUsuario;
        private System.Windows.Forms.TextBox tboxClave;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}