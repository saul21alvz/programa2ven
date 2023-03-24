using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa2ven
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngua_Click(object sender, EventArgs e)
        {
            //DialogResult resultado = saveFileDialog1.ShowDialog();
            string n = txtNombre.Text;
            string d = txtDomicilio.Text;
            string t = txtTelefono.Text;
            string clave = "info";

            clave += n.Substring(0, 2);
            clave += d.Substring(0, 2);
            clave += "2013";


            string linea;
            bool ban = false;
            if (File.Exists("acceso.txt"))
            {
                StreamReader petra = File.OpenText("acceso.txt");
                do
                {
                    linea = petra.ReadLine();
                    if (!String.IsNullOrEmpty(linea))
                    {
                        MessageBox.Show(linea);
                        string c = linea.Substring(linea.Length - 4);
                        if (c == ".txt")
                        {
                            StreamWriter fichero;
                            fichero = File.AppendText(linea);
                            txtClave.Text = clave;
                            fichero.WriteLine(clave + "_" + n + "_" + d + "_" + t);
                            fichero.Close();
                        }
                    } 
                } while (linea != null);
                petra.Close();

            }
        }
    }
}
