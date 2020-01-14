using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class lab01Form : Form
    {
        public lab01Form()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = 0, quadrado = 0;

                numero = Convert.ToInt32(valorTextBox.Text);

                quadrado = numero * numero;

                resultadoLabel.Text = $"Quadrado de {numero} é: {quadrado.ToString("N0")}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor digitar apenas números");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Número informado extenso demais para calculo");
            }
            finally
            {
                valorTextBox.Focus();
                valorTextBox.SelectAll();
            }
        }
    }
}
