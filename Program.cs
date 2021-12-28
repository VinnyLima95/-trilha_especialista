using avaliacao_final;
using System;

namespace avaliacao_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1;
            FuncionarioTerceiro f2;
             f1 = new Funcionario("Alessandra", 6, 8.34);
             f2 = new FuncionarioTerceiro("Carlos", 8, 9.2);

             Console.WriteLine("O funcionário é terceirizado? " +
             "\n Responda 1 - para sim" +
             "\n Responda 2 - para não");
             Console.WriteLine();

             int seTerceiro = Int32.Parse(Console.ReadLine());

             if(seTerceiro == 1)
             {
                 f2.ImprimeDados();
             }
             else
             {
                 f1.ImprimeDados(f1.CalcularSalario(((byte)f1.GetCargaHoraria()), f1.GetValorHora()));
             }
             Console.ReadLine();
        }
    }
}