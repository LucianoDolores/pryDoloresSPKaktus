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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarVen_Click(object sender, EventArgs e)
        {
            string varActivo = "no";
            string varComision = "no";

            if (ckbActivo.Checked == true)
            {
                varActivo = "si";
            }
            if (ckbComision.Checked == true)
            {
                varComision = "si";
            }
            
            StreamWriter Vendedor = new StreamWriter("./Vendedor.txt", true);
            Vendedor.WriteLine(Convert.ToString(txtIDvendedor.Text + " " + txtVendedor.Text + " " + varActivo + " " + varComision));
            Vendedor.Close();

            MessageBox.Show("Registrado.");

        }
    }
}
