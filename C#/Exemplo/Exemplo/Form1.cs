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
            this.Close();

            string[] diasDaSemana = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta" };

            foreach (var diaSelecionado in diasDaSemana)
            {
                Class1 teste = new Class1();

                teste.Teste = "Rafael";
                teste.Teste2 = "Thomazelli";

                teste.Adicionar("Valor");


                if (EstadoCivil.CASADO == EstadoCivil.SOLTEIRO)
                {

                }
                
            }
        }
    }
}
