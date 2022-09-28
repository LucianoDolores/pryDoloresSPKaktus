namespace pryDoloresSPKaktus
{
    partial class frmVendedor
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
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtIDvendedor = new System.Windows.Forms.TextBox();
            this.btnRegistrarVen = new System.Windows.Forms.Button();
            this.ckbActivo = new System.Windows.Forms.CheckBox();
            this.ckbComision = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(12, 20);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 0;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(12, 72);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(70, 13);
            this.lblVendedorID.TabIndex = 1;
            this.lblVendedorID.Text = "Vendedor ID:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(88, 17);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(118, 20);
            this.txtVendedor.TabIndex = 2;
            // 
            // txtIDvendedor
            // 
            this.txtIDvendedor.Location = new System.Drawing.Point(88, 69);
            this.txtIDvendedor.Name = "txtIDvendedor";
            this.txtIDvendedor.Size = new System.Drawing.Size(81, 20);
            this.txtIDvendedor.TabIndex = 3;
            // 
            // btnRegistrarVen
            // 
            this.btnRegistrarVen.Location = new System.Drawing.Point(329, 107);
            this.btnRegistrarVen.Name = "btnRegistrarVen";
            this.btnRegistrarVen.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarVen.TabIndex = 4;
            this.btnRegistrarVen.Text = "Registrar";
            this.btnRegistrarVen.UseVisualStyleBackColor = true;
            this.btnRegistrarVen.Click += new System.EventHandler(this.btnRegistrarVen_Click);
            // 
            // ckbActivo
            // 
            this.ckbActivo.AutoSize = true;
            this.ckbActivo.Location = new System.Drawing.Point(6, 19);
            this.ckbActivo.Name = "ckbActivo";
            this.ckbActivo.Size = new System.Drawing.Size(56, 17);
            this.ckbActivo.TabIndex = 5;
            this.ckbActivo.Text = "Activo";
            this.ckbActivo.UseVisualStyleBackColor = true;
            // 
            // ckbComision
            // 
            this.ckbComision.AutoSize = true;
            this.ckbComision.Location = new System.Drawing.Point(6, 51);
            this.ckbComision.Name = "ckbComision";
            this.ckbComision.Size = new System.Drawing.Size(68, 17);
            this.ckbComision.TabIndex = 6;
            this.ckbComision.Text = "Comision";
            this.ckbComision.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbActivo);
            this.groupBox1.Controls.Add(this.ckbComision);
            this.groupBox1.Location = new System.Drawing.Point(231, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendedor";
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 146);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrarVen);
            this.Controls.Add(this.txtIDvendedor);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.lblVendedor);
            this.Name = "frmVendedor";
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtIDvendedor;
        private System.Windows.Forms.Button btnRegistrarVen;
        private System.Windows.Forms.CheckBox ckbActivo;
        private System.Windows.Forms.CheckBox ckbComision;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}