using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo
{
    public enum EstadoCivil : byte
    {
        CASADO,
        SOLTEIRO,
        VIUVO

    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
        * MAIS 
        * DE
        * UMA
        * 
        * LINHA
        */
        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = "";
            try
            {
                
                int n1 = 10, n2 = 5;

                if(n2 == 0)
                {
                    throw new FormDivisaoZeroException("Não é possível dividir por zero");
                }

                int conta = n1 / n2;

                Console.WriteLine($"Resultado = {conta}");
                resultado = $"Resultado = {conta}";
            }
            catch (Exception)
            {
                Console.WriteLine("Não é possível dividir por zero");
                resultado = "Não é possível dividir por zero";
            }
            finally
            {
                MessageBox.Show(resultado);
            }
        }
    }
}
