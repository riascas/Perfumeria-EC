namespace UI
{
    partial class frmPrincipal1
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
            lblEmpleadoLogin = new System.Windows.Forms.Label();
            menuStrip2 = new System.Windows.Forms.MenuStrip();
            menuTitulo = new System.Windows.Forms.MenuStrip();
            iconoEmpleados = new FontAwesome.Sharp.IconMenuItem();
            iconoABM = new FontAwesome.Sharp.IconMenuItem();
            subMenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            subMenuProducto = new FontAwesome.Sharp.IconMenuItem();
            iconoVenta = new FontAwesome.Sharp.IconMenuItem();
            iconoCompra = new FontAwesome.Sharp.IconMenuItem();
            iconoCliente = new FontAwesome.Sharp.IconMenuItem();
            iconoProveedor = new FontAwesome.Sharp.IconMenuItem();
            iconoReporte = new FontAwesome.Sharp.IconMenuItem();
            panelPantalla = new System.Windows.Forms.Panel();
            menuTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.DarkKhaki;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(599, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // lblEmpleadoLogin
            // 
            lblEmpleadoLogin.AutoSize = true;
            lblEmpleadoLogin.BackColor = System.Drawing.Color.DarkKhaki;
            lblEmpleadoLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEmpleadoLogin.ForeColor = System.Drawing.Color.White;
            lblEmpleadoLogin.Location = new System.Drawing.Point(655, 9);
            lblEmpleadoLogin.Name = "lblEmpleadoLogin";
            lblEmpleadoLogin.Size = new System.Drawing.Size(87, 15);
            lblEmpleadoLogin.TabIndex = 2;
            lblEmpleadoLogin.Text = "Usuario Actual";
            lblEmpleadoLogin.Click += label3_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = System.Drawing.Color.DarkKhaki;
            menuStrip2.Location = new System.Drawing.Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new System.Drawing.Size(798, 38);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = System.Drawing.Color.White;
            menuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { iconoEmpleados, iconoABM, iconoVenta, iconoCompra, iconoCliente, iconoProveedor, iconoReporte });
            menuTitulo.Location = new System.Drawing.Point(0, 38);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            menuTitulo.Size = new System.Drawing.Size(798, 56);
            menuTitulo.TabIndex = 5;
            menuTitulo.Text = "menuStrip1";
            // 
            // iconoEmpleados
            // 
            iconoEmpleados.AutoSize = false;
            iconoEmpleados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            iconoEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconoEmpleados.IconColor = System.Drawing.Color.Black;
            iconoEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoEmpleados.IconSize = 150;
            iconoEmpleados.Name = "iconoEmpleados";
            iconoEmpleados.Size = new System.Drawing.Size(90, 60);
            iconoEmpleados.Text = "Empleados";
            iconoEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconoEmpleados.Click += iconoEmpleados_Click;
            // 
            // iconoABM
            // 
            iconoABM.AutoSize = false;
            iconoABM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { subMenuCategoria, subMenuProducto });
            iconoABM.IconChar = FontAwesome.Sharp.IconChar.Tools;
            iconoABM.IconColor = System.Drawing.Color.Black;
            iconoABM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoABM.IconSize = 80;
            iconoABM.Name = "iconoABM";
            iconoABM.Size = new System.Drawing.Size(122, 50);
            iconoABM.Text = "ABM";
            iconoABM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuCategoria
            // 
            subMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuCategoria.IconColor = System.Drawing.Color.Black;
            subMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuCategoria.Name = "subMenuCategoria";
            subMenuCategoria.Size = new System.Drawing.Size(128, 22);
            subMenuCategoria.Text = "Categoria";
            subMenuCategoria.Click += iconMenuItem1_Click;
            // 
            // subMenuProducto
            // 
            subMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuProducto.IconColor = System.Drawing.Color.Black;
            subMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuProducto.Name = "subMenuProducto";
            subMenuProducto.Size = new System.Drawing.Size(128, 22);
            subMenuProducto.Text = "Productos";
            subMenuProducto.Click += subMenuProducto_Click;
            // 
            // iconoVenta
            // 
            iconoVenta.AutoSize = false;
            iconoVenta.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconoVenta.IconColor = System.Drawing.Color.Black;
            iconoVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoVenta.IconSize = 80;
            iconoVenta.Name = "iconoVenta";
            iconoVenta.Size = new System.Drawing.Size(80, 50);
            iconoVenta.Text = "Ventas";
            iconoVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconoVenta.Click += iconoVenta_Click;
            // 
            // iconoCompra
            // 
            iconoCompra.AutoSize = false;
            iconoCompra.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            iconoCompra.IconColor = System.Drawing.Color.Black;
            iconoCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoCompra.IconSize = 80;
            iconoCompra.Name = "iconoCompra";
            iconoCompra.Size = new System.Drawing.Size(80, 50);
            iconoCompra.Text = "Compras";
            iconoCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconoCompra.Click += iconoCompra_Click;
            // 
            // iconoCliente
            // 
            iconoCliente.AutoSize = false;
            iconoCliente.IconChar = FontAwesome.Sharp.IconChar.Smile;
            iconoCliente.IconColor = System.Drawing.Color.Black;
            iconoCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoCliente.IconSize = 80;
            iconoCliente.Name = "iconoCliente";
            iconoCliente.Size = new System.Drawing.Size(80, 50);
            iconoCliente.Text = "Clientes";
            iconoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconoCliente.Click += iconoCliente_Click;
            // 
            // iconoProveedor
            // 
            iconoProveedor.AutoSize = false;
            iconoProveedor.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            iconoProveedor.IconColor = System.Drawing.Color.Black;
            iconoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoProveedor.IconSize = 80;
            iconoProveedor.Name = "iconoProveedor";
            iconoProveedor.Size = new System.Drawing.Size(80, 50);
            iconoProveedor.Text = "Proveedores";
            iconoProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconoProveedor.Click += iconoProveedor_Click;
            // 
            // iconoReporte
            // 
            iconoReporte.AutoSize = false;
            iconoReporte.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            iconoReporte.IconColor = System.Drawing.Color.Black;
            iconoReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoReporte.IconSize = 80;
            iconoReporte.Name = "iconoReporte";
            iconoReporte.Size = new System.Drawing.Size(80, 50);
            iconoReporte.Text = "Reportes";
            iconoReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            iconoReporte.Click += iconoReporte_Click;
            // 
            // panelPantalla
            // 
            panelPantalla.Location = new System.Drawing.Point(0, 97);
            panelPantalla.Name = "panelPantalla";
            panelPantalla.Size = new System.Drawing.Size(798, 359);
            panelPantalla.TabIndex = 6;
            // 
            // frmPrincipal1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(798, 456);
            Controls.Add(panelPantalla);
            Controls.Add(menuTitulo);
            Controls.Add(lblEmpleadoLogin);
            Controls.Add(label2);
            Controls.Add(menuStrip2);
            Name = "frmPrincipal1";
            Text = "frmPrincipal1";
            Load += frmPrincipal1_Load;
            menuTitulo.ResumeLayout(false);
            menuTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpleadoLogin;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem iconoEmpleados;
        private FontAwesome.Sharp.IconMenuItem iconoABM;
        private FontAwesome.Sharp.IconMenuItem iconoVenta;
        private FontAwesome.Sharp.IconMenuItem iconoCompra;
        private FontAwesome.Sharp.IconMenuItem iconoCliente;
        private FontAwesome.Sharp.IconMenuItem iconoProveedor;
        private FontAwesome.Sharp.IconMenuItem iconoReporte;
        private FontAwesome.Sharp.IconMenuItem subMenuCategoria;
        private FontAwesome.Sharp.IconMenuItem subMenuProducto;
        private System.Windows.Forms.Panel panelPantalla;
    }
}