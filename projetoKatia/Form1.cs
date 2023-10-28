using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoKatia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ContaBancaria> conta = new List<ContaBancaria>();
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            string Cliente = this.txtCliente.Text;
            int num_conta = int.Parse(this.txtCPF1.Text);
            int saldo = int.Parse(this.txtDeposito.Text);            
            conta.Add(new ContaBancaria() { cliente = Cliente, num_conta = num_conta, saldo = saldo });
            lblLimite1.Text = Cliente;
            lblInvestimento1.Text = num_conta.ToString();
            lblSaldo1.Text = saldo.ToString();
        }

        private void btnDepositar2_Click(object sender, EventArgs e)
        {
            string cpf = txtCPF2.Text;
            string saldoAtual = txtValor1.Text;
            if (cpf.Equals(conta[1]))
            {
                var novoSaldo = saldoAtual + lblSaldo1;
                lblSaldo2.Text = novoSaldo.ToString();
            }
            else
            {
                MessageBox.Show("Valor nulo");
            }

        }
    }
}
