using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace atv_poo
{
    public class atv
    {

        public double Media;
        public string Matricula { get; }
        public string? Nome { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public static int _contador { get; set; }


        public atv(string nome, double p1, double p2)
        {
            _contador++;
            Matricula = "157048222300" + _contador;
            Nome = nome;
            P1 = p1;
            P2 = p2;
            Media = Calcular_Media();
        }
        

        public double Calcular_Media(){
            return Media = (P1 + P2) / 2;
        }

        public void Mostrar_Atributos(){
            System.Console.Write($"Matricula: {Matricula} \tNome: {Nome} \tP1: {P1} \tP2: {P2} \tMédia: {Media}\n");
        }

    }
}