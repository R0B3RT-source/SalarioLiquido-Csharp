using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salarioLiquidoeBruto
{
    public partial class Form1 : Form
    {
        double hora, valor, desconto, salbruto, salliquido, pd;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDesconto.Text = "";
            txtHoras.Text = "";
            txtValor.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                hora = Convert.ToDouble(txtHoras.Text);
                valor = Convert.ToDouble(txtValor.Text);
                desconto = Convert.ToDouble(txtDesconto.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao Converter Valores!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            salbruto = hora * valor;
            pd = (desconto / 100) * salbruto;
            salliquido = salbruto - pd;

            MessageBox.Show("O Seu Salário Bruto é: " + salbruto);
            MessageBox.Show("O seu Salário Liquido é: " + salliquido);
         
        }
    }
}
