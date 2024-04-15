using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaCorrente1
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set;}


        public ContaCorrente(double Saldo, double ChequeEspecial)
        {
            this.Saldo = Saldo;
            this.ChequeEspecial = ChequeEspecial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }  
            else
            {
                System.Console.WriteLine("Valor inválido!");
            }
        }

        public void Sacar(double valor)
        {
            if (this.Saldo > 0)
            {
                this.Saldo = this.Saldo - valor;
            }
            else
            {
                System.Console.WriteLine("Saldo inválido!");
            }
        }

        public void GerarExtrato()
        {
            System.Console.WriteLine("\n--------------- Informações da Conta ---------------\n");
            System.Console.WriteLine($"[-] Saldo Conta Corrente: R${this.Saldo}");
            System.Console.WriteLine($"[-] Saldo Cheque Especial: R${this.ChequeEspecial}\n");
            System.Console.WriteLine("--------------- Saldo Total ---------------\n");
            System.Console.WriteLine($"Saldo Total: R${this.Saldo + this.ChequeEspecial}\n");
        }
    }
}