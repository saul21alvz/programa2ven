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
        }
    }
}
