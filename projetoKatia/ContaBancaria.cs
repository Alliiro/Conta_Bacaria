using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoKatia
{
    public class ContaBancaria
    {   
        public string cliente { get; set; }
        public int num_conta { get; set; }
        public float saldo { get; set; }

        public string depositar()
        {

        }
    }

    public class ContaPoupança : ContaBancaria
    {
        public int dia_rendimento { get; set; }

        public string calcularNovoSaldo()
        {

        }   
    }

    public class ContaEspecial : ContaBancaria
    {
        public float limite { get; set; }

        public string sacar()
        {

        }
    }
}
