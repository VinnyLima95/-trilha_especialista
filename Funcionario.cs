using System;
using System.Text;
using System.Collections.Generic;

namespace avaliacao_final
{
    public class Funcionario
    {
        private string nome{get; set;}
        private int cargaHoraria {get;set;}
        private double valorHora{get;set;}

        public Funcionario()
        {

        }
        public Funcionario(string n, int ch, double vh)
        {
            nome = n;
            cargaHoraria = ch;
            valorHora = vh;
        }

        public int GetCargaHoraria()
        {
            return this.cargaHoraria;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public double GetValorHora()
        {
            return this.valorHora;
        }
        public double CalcularSalario(int cargaHoraria, double valorHora)
        {
            double salario = cargaHoraria * valorHora;

            return salario;
        }
        public void ImprimeDados(double salario)
        {
            Console.WriteLine("Funcionário: {0}" +
            "\n Salario: {1}", this.nome, salario);
        }
    }
}
