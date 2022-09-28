namespace pryDoloresSPKaktus
{
    partial class frmVentas
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
            this.gpbFacturas = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.cbTipoFactura = new System.Windows.Forms.ComboBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.gpbIDs = new System.Windows.Forms.GroupBox();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblIDvendedor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIDcliente = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gpbFacturas.SuspendLayout();
            this.gpbIDs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFacturas
            // 
            this.gpbFacturas.Controls.Add(this.txtMonto);
            this.gpbFacturas.Controls.Add(this.txtNroFactura);
            this.gpbFacturas.Controls.Add(this.cbTipoFactura);
            this.gpbFacturas.Controls.Add(this.lblMonto);
            this.gpbFacturas.Controls.Add(this.lblNroFactura);
            this.gpbFacturas.Controls.Add(this.lblTipoFactura);
            this.gpbFacturas.Location = new System.Drawing.Point(12, 12);
            this.gpbFacturas.Name = "gpbFacturas";
            this.gpbFacturas.Size = new System.Drawing.Size(186, 130);
            this.gpbFacturas.TabIndex = 0;
            this.gpbFacturas.TabStop = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(110, 92);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(62, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(110, 59);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(62, 20);
            this.txtNroFactura.TabIndex = 4;
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Items.AddRange(new object[] {
            "A",
            "F",
            "C",
            "X",
            "G",
            "C"});
            this.cbTipoFactura.Location = new System.Drawing.Point(110, 25);
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(62, 21);
            this.cbTipoFactura.TabIndex = 3;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(6, 96);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto:";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Location = new System.Drawing.Point(6, 62);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(98, 13);
            this.lblNroFactura.TabIndex = 1;
            this.lblNroFactura.Text = "Numero de factura:";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(6, 28);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(82, 13);
            this.lblTipoFactura.TabIndex = 0;
            this.lblTipoFactura.Text = "Tipo de factura:";
            // 
            // gpbIDs
            // 
            this.gpbIDs.Controls.Add(this.cbVendedor);
            this.gpbIDs.Controls.Add(this.cbCliente);
            this.gpbIDs.Controls.Add(this.dtpFecha);
            this.gpbIDs.Controls.Add(this.lblIDvendedor);
            this.gpbIDs.Controls.Add(this.lblFecha);
            this.gpbIDs.Controls.Add(this.lblIDcliente);
            this.gpbIDs.Location = new System.Drawing.Point(204, 12);
            this.gpbIDs.Name = "gpbIDs";
            this.gpbIDs.Size = new System.Drawing.Size(263, 130);
            this.gpbIDs.TabIndex = 1;
            this.gpbIDs.TabStop = false;
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(81, 60);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(62, 21);
            this.cbVendedor.TabIndex = 7;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(79, 24);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(62, 21);
            this.cbCliente.TabIndex = 6;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(79, 96);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(152, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblIDvendedor
            // 
            this.lblIDvendedor.AutoSize = true;
            this.lblIDvendedor.Location = new System.Drawing.Point(6, 62);
            this.lblIDvendedor.Name = "lblIDvendedor";
            this.lblIDvendedor.Size = new System.Drawing.Size(69, 13);
            this.lblIDvendedor.TabIndex = 4;
            this.lblIDvendedor.Text = "ID vendedor:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 99);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblIDcliente
            // 
            this.lblIDcliente.AutoSize = true;
            this.lblIDcliente.Location = new System.Drawing.Point(6, 25);
            this.lblIDcliente.Name = "lblIDcliente";
            this.lblIDcliente.Size = new System.Drawing.Size(55, 13);
            this.lblIDcliente.TabIndex = 3;
            this.lblIDcliente.Text = "ID cliente:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(392, 148);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 178);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gpbIDs);
            this.Controls.Add(this.gpbFacturas);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gpbFacturas.ResumeLayout(false);
            this.gpbFacturas.PerformLayout();
            this.gpbIDs.ResumeLayout(false);
            this.gpbIDs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFacturas;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.ComboBox cbTipoFactura;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.GroupBox gpbIDs;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblIDvendedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblIDcliente;
        private System.Windows.Forms.Button btnRegistrar;
    }
}