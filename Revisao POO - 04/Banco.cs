using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ContaCorrente1;
using Poupanca1;

namespace Banco1
{
    public class Banco
    {
        public List<Poupanca> Poupancas {get; set;}
        public List<ContaCorrente> ContasCorrentes {get; set;}

        public Banco()
        {
            ContasCorrentes = new List<ContaCorrente>();
            Poupancas = new List<Poupanca>();
        }

        public void IniciarBanco()
        {
            ContaCorrente contaCorrente1 = new ContaCorrente(0.0, 0.0);
            ContaCorrente contaCorrente2 = new ContaCorrente(0.0, 0.0);
            ContaCorrente contaCorrente3 = new ContaCorrente(0.0, 0.0);
            ContasCorrentes.Add(contaCorrente1);
            ContasCorrentes.Add(contaCorrente2);
            ContasCorrentes.Add(contaCorrente3);

            Poupanca poupanca1 = new Poupanca(0.0);
            Poupanca poupanca2 = new Poupanca(0.0);
            Poupanca poupanca3 = new Poupanca(0.0);
            Poupancas.Add(poupanca1);
            Poupancas.Add(poupanca2);
            Poupancas.Add(poupanca3);
        }

        public double AtualizarSaldoContasCorrentes()
        {
            double SaldoContaCorrente = 0;
            foreach (var conta in ContasCorrentes)
            {
                SaldoContaCorrente += conta.Saldo;
            }
            return SaldoContaCorrente;
        }

        public double AtualizarSaldoPoupanca()
        {
            double SaldoContaPoupanca = 0;
            foreach (var poupanca in Poupancas)
            {
                SaldoContaPoupanca += poupanca.Saldo;
            }
            return SaldoContaPoupanca;
        }


        ~Banco()
        {
            if (AtualizarSaldoPoupanca() == 0.0 || AtualizarSaldoPoupanca() == 0.0)
            {
                System.Console.WriteLine("O banco faliu!");
            }
        }
    }
}