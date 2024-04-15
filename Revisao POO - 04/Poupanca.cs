using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Threading.Tasks;

namespace Poupanca1
{
    public class Poupanca
    {
        public double Saldo { get; set;}

        public Poupanca(double valor)
        {
            this.Saldo = valor;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            this.Saldo -= valor;
        }

        public void GerarRendimento()
        {
            this.Saldo += 0.05*this.Saldo;
        }
    }
}