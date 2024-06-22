namespace UI
{
    partial class frmPrincipal
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
            menuTitulo = new System.Windows.Forms.MenuStrip();
            iconoCompra = new FontAwesome.Sharp.IconMenuItem();
            iconoVenta = new FontAwesome.Sharp.IconMenuItem();
            iconoABM = new FontAwesome.Sharp.IconMenuItem();
            iconoEmpleados = new FontAwesome.Sharp.IconMenuItem();
            iconoReporte = new FontAwesome.Sharp.IconMenuItem();
            iconoCliente = new FontAwesome.Sharp.IconMenuItem();
            iconoProveedor = new FontAwesome.Sharp.IconMenuItem();
            menuTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = System.Drawing.Color.DarkKhaki;
            menuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { iconoEmpleados, iconoABM, iconoVenta, iconoCompra, iconoCliente, iconoProveedor, iconoReporte });
            menuTitulo.Location = new System.Drawing.Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            menuTitulo.Size = new System.Drawing.Size(800, 56);
            menuTitulo.TabIndex = 0;
            menuTitulo.Text = "menuStrip1";
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
            // 
            // iconoABM
            // 
            iconoABM.AutoSize = false;
            iconoABM.IconChar = FontAwesome.Sharp.IconChar.Tools;
            iconoABM.IconColor = System.Drawing.Color.Black;
            iconoABM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoABM.IconSize = 80;
            iconoABM.Name = "iconoABM";
            iconoABM.Size = new System.Drawing.Size(80, 50);
            iconoABM.Text = "ABM";
            iconoABM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuTitulo);
            MainMenuStrip = menuTitulo;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            menuTitulo.ResumeLayout(false);
            menuTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem iconoEmpleados;
        private FontAwesome.Sharp.IconMenuItem iconoABM;
        private FontAwesome.Sharp.IconMenuItem iconoVenta;
        private FontAwesome.Sharp.IconMenuItem iconoCompra;
        private FontAwesome.Sharp.IconMenuItem iconoCliente;
        private FontAwesome.Sharp.IconMenuItem iconoProveedor;
        private FontAwesome.Sharp.IconMenuItem iconoReporte;
    }
}