using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeguridadInformacion
{
    public class Encriptado
    {
        public Double[,] A = new Double[3, 3];
        public Double[,] A1 = new Double[3, 3];
        public String Mensaje { get; set; }
        public String DesEncriptadoMensaje { get; set; }
        public List<Codigo> Abc = new List<Codigo>();
        public List<Double> encriptado = new List<Double>();
         
        
        public bool Estado { get; set; }
        public void EncriptarMensaje()
        {
            String[] aux = Regex.Split(Mensaje, "");
            List<String> cadena = new List<String>();
            for (int i = 1; i < aux.Length - 1; i++)
                cadena.Add(aux[i]);

            while (true)
            {
                if (!(cadena.Count % 3 == 0))
                    cadena.Add(" ");
                else
                    break;
            }
            List<int> numeros = new List<int>();
            foreach (String a in cadena)
                foreach (Codigo b in Abc)
                    if (b.Letra == a)
                        numeros.Add(b.Numero);

            try
            {
                for (int i = 0; i < numeros.Count;)
                {
                    encriptado.Add((numeros[i] * A[0, 0]) + (numeros[i + 1] * A[1, 0]) + (numeros[i + 2] * A[2, 0]));
                    encriptado.Add((numeros[i] * A[0, 1]) + (numeros[i + 1] * A[1, 1]) + (numeros[i + 2] * A[2, 1]));
                    encriptado.Add((numeros[i] * A[0, 2]) + (numeros[i + 1] * A[1, 2]) + (numeros[i + 2] * A[2, 2]));
                    i += 3;
                }
                Estado = true;
            }
            catch (Exception e)
            {
                Estado = false;
            }
        }
        public void DesEncriptarMensaje(String mensaje)
        {
            DesEncriptadoMensaje = "";
            String[] aux = Regex.Split(mensaje, " ");
            List<Double> cadena = new List<Double>();
            for (int i = 0; i < aux.Length; i++)
                cadena.Add(double.Parse(aux[i]));
            List<int> desencriptado = new List<int>();
            try
            {
                for (int i = 0; i < cadena.Count;)
                {
                    desencriptado.Add((int)Math.Round((cadena[i] * A1[0, 0]) + (cadena[i + 1] * A1[1, 0]) + (cadena[i + 2] * A1[2, 0])));
                    desencriptado.Add((int)Math.Round((cadena[i] * A1[0, 1]) + (cadena[i + 1] * A1[1, 1]) + (cadena[i + 2] * A1[2, 1])));
                    desencriptado.Add((int)Math.Round((cadena[i] * A1[0, 2]) + (cadena[i + 1] * A1[1, 2]) + (cadena[i + 2] * A1[2, 2])));
                    i += 3;
                }
                Estado = true;
            }
            catch (Exception e)
            {
                Estado = false;
            }
            foreach (int a in desencriptado)
                foreach (Codigo b in Abc)
                    if (b.Numero == a)
                        DesEncriptadoMensaje+= b.Letra;

        }
    }
    public class Codigo
    {
        public String Letra { get; set; }
        public int Numero { get; set; }
        public Codigo(String Letra, int Numero)
        {
            this.Letra = Letra;
            this.Numero = Numero;
        }
    }
    public class Herramienta
    {
        public string GetSHA256(string str)
        {
            SHA256 sha256 = new SHA256Managed();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }


}

