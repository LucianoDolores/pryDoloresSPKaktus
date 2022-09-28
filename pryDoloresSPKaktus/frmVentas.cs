using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryDoloresSPKaktus
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            StreamReader LeerClientes = new StreamReader("./Clientes.txt");
            StreamReader LeerVendedor = new StreamReader("./Vendedor.txt");

            char Separador = Convert.ToChar(" ");

            while (!LeerClientes.EndOfStream)
            {
                string[] Clientes = LeerClientes.ReadLine().Split(Separador);
                cbCliente.Items.Add(Clientes[0]);

            }
            while (!LeerVendedor.EndOfStream)
            {
                string[] Vendedor = LeerVendedor.ReadLine().Split(Separador);
                cbVendedor.Items.Add(Vendedor[0]);
            }
            LeerClientes.Close();
            LeerVendedor.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            StreamWriter Ventas = new StreamWriter("./Ventas.txt", true);
            Ventas.WriteLine(Convert.ToString(cbTipoFactura.Text + " " + txtNroFactura.Text + " " + txtMonto.Text + " " + cbCliente.Text + " " + cbVendedor.Text + " " + dtpFecha.Text ));
            Ventas.Close();
        }
    }
}
