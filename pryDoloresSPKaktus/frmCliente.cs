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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            StreamWriter Cliente = new StreamWriter("./Clientes.txt", true);
            Cliente.WriteLine(Convert.ToString(txtClienteID.Text + " " + txtCliente.Text));
            Cliente.Close();

            MessageBox.Show("Registrado Correctamente!");

            txtCliente.Text = "";
            txtClienteID.Text = "";
            txtCliente.Focus();
        }
    }
}
