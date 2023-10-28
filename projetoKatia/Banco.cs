using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoKatia
{
    internal class Banco
    {
    }
    public class ContaBancaria
    {
        public string cliente { get; set; }
        public int num_conta { get; set; }
        public float saldo { get; set; }
        public string depositar()
        {
            return cliente;
        }
    }

    public class ContaPoupanca : ContaBancaria
    {
        public int dia_rendimento { get; set; }
        public string calcularNovoSaldo()
        {
            return cliente;
        }
    }

    public class ContaEspecial : ContaBancaria
    {
        public float limite { get; set; }
        public string sacar()
        {
            return cliente;
        }
    }
}
