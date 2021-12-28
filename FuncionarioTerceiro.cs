using System;
using System.Collections.Generic;
using System.Text;

namespace avaliacao_final
{
    public class FuncionarioTerceiro: Funcionario
    private string empresaOrigem {get; set;}
    private double taxaSerico {get; set;}

    public FuncionarioTerceiro(string nome, int cargaHoraria, double valorHora): base(nome, cargaHoraria, valorHora){empresaOrigem = "empresa terceira"; taxaServico = 1}

    public FuncionarioTerceiro()
    {

    }

    public FuncionarioTerceiro(string empOri, double taxaS)
    {
        empresaOrigem = empOri;
        taxaServico = taxaS;
    }

    public double CalculadoraSalario(int cargaHoraria, double valorHora, double taxaServico)
    {
        double salario = (cargaHoraria * valorHora) * taxaServico;

        return salario;
    }

    public void ImprimeDados()
    {
        double salario = CalculaSalario(this.GetCargaHoraria(), this.GetValorHora(), this.taxaServico);
        Console.WriteLine("Funcionário: {0}" +
        "\n Salario: {1} \n Empresa: {2}", this.GetNome(), salario, this.empresaOrigem);
    }
}
