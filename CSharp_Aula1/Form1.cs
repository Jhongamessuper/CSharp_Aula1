using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConcatenacao_Click(object sender, EventArgs e)
        {
            string nome,sobrenome,nomeSobrenome;
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            nomeSobrenome = nome + " " + sobrenome;
            txtNomeSobrenome.Text = nomeSobrenome;

        }

        private void btnSE_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(txtN1.Text);
            int N2 = int.Parse(txtN2.Text);
            int Resultado = N1 + N2;
            if (Resultado > 10)
            {
                    txtResultado.Text = "O valor é : " + Resultado.ToString() + "  que é maior que 10.";
            }
            else
            {
                    if (Resultado < 10)
                    {
                        txtResultado.Text = "O valor é : " + Resultado.ToString() + "  que é menor que 10.";
                    }
                    else
                    {
                        txtResultado.Text = "O valor é : " + Resultado.ToString() + "  igual a 10.";
                    }

            }
        }
    }
}
