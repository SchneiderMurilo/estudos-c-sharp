using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            numeroConta = NumeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("O Valor desejado é maior que o saldo disponivel");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O Saldo da conta é de R$ {saldo}");
        }
    }
}