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
    public partial class Productos : Form
    {
        StreamWriter fichero;
        public Productos()
        {
            InitializeComponent();
        }

        private string ruta;

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir= new OpenFileDialog();

            abrir.Filter = "JPEG(*.JPEG)|*.jpeg|BMP(*.BMP)|*.bmp|PNG(*.PNG)|*.png";
            if(abrir.ShowDialog() == DialogResult.OK)
            {
                ruta = abrir.FileName;
                pbfoto.Image = Image.FromFile(abrir.FileName);
            }
        }

        private void btnguarda_Click(object sender, EventArgs e)
        {
            string rutaCarpeta = @"imagenes";
            string rutaPad = @"\imagenes";
            if (!Directory.Exists(rutaCarpeta)) // si no encuentra la carpeta
            {
                Directory.CreateDirectory(rutaCarpeta);
                Directory.CreateDirectory(rutaCarpeta+rutaPad);
                MessageBox.Show("Se ha creado la carpeta");
            }
            else
            {
                MessageBox.Show("La carpeta ya existe");
            }
            string np = txtproducto.Text;
            string pp = txtprecio.Text;
            if (File.Exists("producto.txt"))
            {
                
                if (String.IsNullOrEmpty(np)|| String.IsNullOrEmpty(pp))
                {
                    MessageBox.Show("Faltan datos");
                }
                else
                {
                    
                    fichero = File.AppendText("producto.txt");
                    fichero.WriteLine(txtproducto.Text + "@" + txtprecio + "@" + ruta);
                    fichero.Close();
                }
            }
            else
            {
                if (String.IsNullOrEmpty(np) || String.IsNullOrEmpty(pp))
                {
                    MessageBox.Show("Faltan datos");
                }
                else
                {
                    fichero = File.AppendText("producto.txt");
                    fichero.WriteLine(txtproducto.Text + "@" + txtprecio + "@" + ruta);
                    fichero.Close();
                }
            }
        }

        private void pbfoto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
