using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa2ven
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //RegistroToolStripMenuItem.Enabled= false;
            cargar();
            cargarpersonal();
            cargarusuarios();
            cargarimagenes();
        }
        private void cargarimagenes()
        {
            img1.Image = Image.FromFile("USU.png");
            img2.Image = Image.FromFile("trabajo.png");
            img3.Image = Image.FromFile("caja.png");
        }
        private void cargarpersonal() {
            {
                string linea;
                int con = 0;
                MessageBox.Show(buscarArchivo());

                if (File.Exists(buscarArchivo()))
                {
                    StreamReader petra = File.OpenText(buscarArchivo());
                    do
                    {
                        linea = petra.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            con++;
                        }
                    } while (linea != null);
                    petra.Close();
                    lblPersonalDash.Text = con.ToString();
                }
            }
        }

        private string buscarArchivo()
        {
            string linea, ruta="";
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
                            ruta = linea;
                        }
                    }
                } while (linea != null);
                petra.Close();
            }
            return ruta;

        }
        private void cargarusuarios()
        {
            string linea;
            int con = 0;
            if (File.Exists("acceso.txt"))
            {
                StreamReader petra = File.OpenText("acceso.txt");
                do
                {
                    linea = petra.ReadLine();
                    if (!String.IsNullOrEmpty(linea))
                    {
                        string c = linea.Substring(linea.Length - 4);
                        if (c != ".txt")
                        {
                            con++;
                        }
                    }
                }while (linea != null);
                petra.Close();   
                lblUsuarioDash.Text = con.ToString();
            }
        }
        private void cargar()
        {
            string linea;
            if (File.Exists("acceso.txt"))
            {
                StreamReader petra = File.OpenText("acceso.txt");
                do
                {
                    linea = petra.ReadLine();
                    if (!String.IsNullOrEmpty(linea))
                    {
                        string c = linea.Substring(linea.Length - 4);
                        if (c == ".txt")
                        {
                            setingToolStripMenuItem.Enabled = false;
                            RegistroToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            setingToolStripMenuItem.Enabled = true;
                            RegistroToolStripMenuItem.Enabled = false;
                        }
                    }
                }while(linea != null);
                petra.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.ShowDialog();
        }

        private void setingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = saveFileDialog1.ShowDialog();
           
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
                StreamWriter fichero;
                string nombre = saveFileDialog1.FileName;

                if (File.Exists("acceso.txt"))
                {
                    fichero = File.AppendText("acceso.txt");
                    fichero.WriteLine(nombre);
                    fichero.Close();
                    RegistroToolStripMenuItem.Enabled = true;
                    setingToolStripMenuItem.Enabled = false;
                }

            }
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnproductosDash_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.ShowDialog();
        }

        private void btnAgregarDash_Click(object sender, EventArgs e)
        {

        }
    }
}
