using System;
using System.Collections.Generic;

namespace atv_poo4
{
    public class ContaCorrente
    {   
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set;}

        public ContaCorrente(double saldo, double chequeEspecial)
        {
            Saldo = saldo;
            ChequeEspecial = chequeEspecial;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException("Valor insuficiente.");
            }
            else
            {
                Saldo = Saldo + valor;
            }
        }

        public void Sacar(double valor)
        {
            if (Saldo <= 0)
            {
                throw new ArgumentOutOfRangeException("Saldo insuficiente.");
            }
            else
            {
                Saldo = Saldo - valor;
            }
        }

        public void GerarExtrato()
        {
            Console.Write($"Saldo: R${Saldo}\tCheque Especial: R$ {ChequeEspecial}\n");
        }
    }

    public class Poupanca
    {
        public double Saldo { get; private set; }
        
        public Poupanca(double saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException("Valor insuficiente.");
            }
            else
            {
                Saldo = Saldo + valor;
            }
        }

        public void Sacar(double valor)
        {
            if (Saldo <= 0)
            {
                throw new ArgumentOutOfRangeException("Saldo insuficiente.");
            }
            else
            {
                Saldo = Saldo - valor;
            }
        }

        public void GerarRendimento()
        {
            Saldo += 0.05*Saldo;
        }
    }

    public class Banco
    {
        public List<Poupanca> Poupancas {get; set;}
        public List<ContaCorrente> Contas { get; set;}

        public Banco()
        {
            Contas = new List<ContaCorrente>();
            Poupancas = new List<Poupanca>();
        }

        public void IniciarBanco()
        {  
            System.Console.Write("Carregando...\n\n");

            ContaCorrente cc1 = new ContaCorrente(100, 100);
            Contas.Add(cc1);

            ContaCorrente cc2 = new ContaCorrente(200, 200);
            Contas.Add(cc2);

            ContaCorrente cc3 = new ContaCorrente(300, 300);
            Contas.Add(cc3);


            Poupanca p1 = new Poupanca(100);
            Poupancas.Add(p1);
            Poupanca p2 = new Poupanca(200);
            Poupancas.Add(p2);
            Poupanca p3 = new Poupanca(300);
            Poupancas.Add(p3);


            MostrarAtributos();
        }


        public double Somar_Saldo_Contas()
        {
            double saldo = 0.0;
            foreach (ContaCorrente conta in Contas)
            {
                saldo += conta.Saldo;
            }

            return saldo;
        }


        public double Somar_Saldo_Polpanca()
        {
            double saldo = 0.0;
            foreach (Poupanca poupanca in Poupancas)
            {
                saldo += poupanca.Saldo;
            }
            return saldo;
        }


        public void MostrarAtributos(){

            if(Contas == null || Poupancas == null)
            {
                System.Console.WriteLine("---- XXX ----");
            }
            else{
                System.Console.WriteLine("--------------------- Banco ---------------------\n");
                
                foreach (var conta in Contas)
                {
                    Console.WriteLine($"Conta Corrente - Saldo: R${conta.Saldo}");
                }
                
                double saldoContas = Somar_Saldo_Contas();
                System.Console.WriteLine($"- Total em Conta Correntes: {saldoContas:c}");

                System.Console.WriteLine();

                foreach (var poupanca in Poupancas)
                {
                    Console.WriteLine($"Poupança - Saldo: R${poupanca.Saldo}");
                }
                double saldoPoupancas = Somar_Saldo_Polpanca();
                System.Console.WriteLine($"- Total na Poupança: {saldoPoupancas:c}");

                System.Console.WriteLine();

                double saldoTotal = saldoContas+saldoPoupancas;
                System.Console.WriteLine("---------------------------------------------------------------------");
                System.Console.WriteLine($"Saldo Total: {saldoTotal:c}");
                System.Console.WriteLine("---------------------------------------------------------------------\n");


            }
            

        }
    }
}
