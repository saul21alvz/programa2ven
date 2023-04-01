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
    public partial class Form1 : Form
    {
        Form2 ventana;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnacep_Click(object sender, EventArgs e)
        {
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
                        int pos = linea.IndexOf("-");
                        string usu = linea.Substring(0, pos);
                        string pas = linea.Substring(pos + 1);
                        if (usu.Equals(txtusuario.Text) && pas.Equals(txtpass.Text))
                        {
                            ban = true;
                        }
                    }                
                } while (linea != null);
                if (ban)
                {
                    //this.Hide();
                    petra.Close();
                    ventana = new Form2();
                    ventana.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El usuario no esta registrado");
                }
                
            }
            else
            {
                MessageBox.Show("No se han registrado ningun usuario");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblregi_Click(object sender, EventArgs e)
        {
           // string usuario = Microsoft.VisualBasic.Interaction.inputBox("Escribe el usuario");


            datos pedir;
            pedir = new datos();
            pedir.ShowDialog();

            string usuario2 = pedir.getUsuario();
            string password2 = pedir.getPass();
            MessageBox.Show(usuario2 + " " + password2);

            if (validarusu(usuario2))
            {
                MessageBox.Show("El usuario ya existe");
            }
            else
            {
                StreamWriter fichero;

                fichero = File.AppendText("acceso.txt");
                fichero.WriteLine(usuario2 + "-" + password2);
                fichero.Close();
                MessageBox.Show("El usuario se guardo correctamente");
            }

            
        }
        private bool validarusu(string u)
        {
            string linea;
            bool ban=false;
            if (File.Exists("acceso.txt"))
            {
                StreamReader petra = File.OpenText("acceso.txt");
                do
                {
                    linea = petra.ReadLine();
                    if (!String.IsNullOrEmpty(linea))
                    {
                        int pos = linea.IndexOf("-");
                        string usu = linea.Substring(0, pos);
                        if (usu.Equals(u))
                        {
                            ban = true;
                            break;
                        }
                    }
                } while (linea != null);
                petra.Close();
            }
            else
            {
                MessageBox.Show("El archivo de registro no existe");
            }
            return ban;
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 47 && e.KeyChar <= 58 )
            {
                e.Handled = true;
                MessageBox.Show("Solo letras");
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar>=97 && e.KeyChar <= 120 || e.KeyChar>= 65 && e.KeyChar <= 90)
            {
                e.Handled= true;
                MessageBox.Show("Solo Numeros");
            }
        }
    }
}
