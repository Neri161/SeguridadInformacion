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

namespace SeguridadInformacion
{
    public partial class login : Form
    {
        Form madre = new Form();
        public login(Form aux)
        {
            InitializeComponent();
            madre = aux;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == null || txtMail.Text == "")
            {
                MessageBox.Show("ingresa un correo");
                return;
            }
            if (txtPass.Text == null || txtPass.Text == "")
            {
                MessageBox.Show("ingresa un contraseña");
                return;
            }
            Herramienta herramienta = new Herramienta();
            String linea;
            String pass = herramienta.GetSHA256(txtPass.Text);

            StreamReader sr = new StreamReader("BD.txt");
            linea = sr.ReadLine();
            while (linea != null)
            {
                String[] credenciales = linea.Split('\t');
                if (credenciales[0] == txtMail.Text && pass == credenciales[1])
                {
                    
                    sr.Close();
                    FormEncriptado form = new FormEncriptado();
                    form.Show();
                    madre.Hide();
                    return;
                }
                linea = sr.ReadLine();
            }
            if (linea == null)
            {
                MessageBox.Show("La cuenta no existe");
            }
            sr.Close();
            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }
    }
}
