using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa2ven
{
    public partial class datos : Form
    {
        string u, p;
        public datos()
        {
            InitializeComponent();
        }

        private void lblregi_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnacep_Click(object sender, EventArgs e)
        {
            u = txtusuario2.Text;
            p = txtpass2.Text;
            getUsuario();
            getPass();
            this.Hide();
        }
        public string getUsuario()
        {
            return u;
        }
        public string getPass()
        {
            return p;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 97 && e.KeyChar <= 120 || e.KeyChar >= 65 && e.KeyChar <= 90)
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }

        private void txtusuario2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 47 && e.KeyChar <= 58)
            {
                e.Handled = true;
                MessageBox.Show("Solo letras");
            }
        }

        private void datos_Load(object sender, EventArgs e)
        {

        }
    }
}
