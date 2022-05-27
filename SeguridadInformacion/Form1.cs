using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguridadInformacion
{
    public partial class Form1 : Form
    {
        private Form activo = null;
        public Form1()
        {
            InitializeComponent();
            openChildForm(new login(this));
            FormEncriptado a = new FormEncriptado();
            a.Show();
            this.Hide();
        }
        private void openChildForm(Form segundo) {
            if (activo != null)
                activo.Close();
            activo = segundo;
            segundo.TopLevel = false;
            segundo.FormBorderStyle = FormBorderStyle.None;
            segundo.Dock = DockStyle.Fill;
            vistaPrincipal.Controls.Add(segundo);
            vistaPrincipal.Tag = segundo;
            segundo.BringToFront();
            segundo.Show();
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            openChildForm(new registro());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            openChildForm(new login(this));
        }
    }
}
