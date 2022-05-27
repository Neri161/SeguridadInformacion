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
    public partial class FormEncriptado : Form
    {
        public Encriptado encriptador = new Encriptado();
        public FormEncriptado()
        {
            InitializeComponent();
            leerArchivo();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            rtbCodificado.Text = "";
            encriptador.Mensaje = txtMensaje.Text;
            encriptador.EncriptarMensaje();
            
            if (!encriptador.Estado)
            {
                MessageBox.Show("Error", "Mensaje no valido");
            }
            txtMensaje.Text = "";
            foreach (int a in encriptador.encriptado)
            {
                rtbCodificado.Text += $"{a} ";
            }
            encriptador.encriptado.Clear();
            
        }

        private void leerArchivo()
        {
            String linea;
            byte numeroLinea = 0;
            byte numeroAlfabeto = 0;
            StreamReader sr = new StreamReader("mensaje.txt");
            linea = sr.ReadLine();
            while (linea != null)
            {
                switch (numeroLinea)
                {
                    case 0:
                        String[] numero = linea.Split('\t');
                        for (int i = 0; i < numero.Length; i++)
                        {
                            String[] aux = numero[i].Split(' ');
                            for (int j = 0; j < aux.Length; j++)
                            {
                                encriptador.A[i, j] = int.Parse(aux[j]);
                            }
                        }
                        break;
                    case 1:
                        String[] numero2 = linea.Split('\t');
                        for (int i = 0; i < numero2.Length; i++)
                        {
                            String[] aux = numero2[i].Split(' ');
                            for (int j = 0; j < aux.Length; j++)
                            {
                                encriptador.A1[i, j] = double.Parse(aux[j]);
                            }
                        }
                        break;
                    case 2:
                        numeroAlfabeto = byte.Parse(linea);
                        break;
                }
                if (numeroLinea > 2 && numeroLinea < (numeroAlfabeto + 2))
                {
                    String[] codigo = linea.Split('\t');
                    encriptador.Abc.Add(new Codigo(codigo[0], int.Parse(codigo[1])));
                }
                numeroLinea++;
                linea = sr.ReadLine();
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb2.Text = "";
            encriptador.DesEncriptarMensaje(txtM2.Text);
            rtb2.Text = encriptador.DesEncriptadoMensaje;

        }
    }
}
