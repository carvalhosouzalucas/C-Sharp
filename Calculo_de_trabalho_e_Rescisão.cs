using System;

class CalculoDeTrabalho
{
    string inicio;
    string final;
    string motivo;

    static void Main()
    {
        CalculoDeTrabalho trabalho = new CalculoDeTrabalho();
        trabalho.ObterDados();
        trabalho.CalcularDuracao();
    }

    public void ObterDados()
    {
        Console.WriteLine("Insira a data de início da relação de trabalho (formato dd/MM/yyyy): ");
        inicio = Console.ReadLine();

        Console.WriteLine("Insira a data de demissão (formato dd/MM/yyyy): ");
        final = Console.ReadLine();

        Console.WriteLine("Digite o motivo da demissão: ");
        motivo = Console.ReadLine();
    }



    