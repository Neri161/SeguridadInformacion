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
    public partial class registro : Form
    {
        Herramienta herramienta = new Herramienta();
        public registro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == null || txtNom.Text == "")
            {
                MessageBox.Show("Ingresa un correo");
                return;
            }
            if (txtPass.Text == null || txtPass.Text == "")
            {
                MessageBox.Show("Ingresa un contraseña");
                return;
            }
            try
            {
                StreamWriter archivo = new StreamWriter("BD.txt", true);
                String temp = $"{txtNom.Text}\t{herramienta.GetSHA256(txtPass.Text)}";
                archivo.WriteLine(temp);
                archivo.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
