﻿using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var caminhoNovoArquivo = "TestaEscrita.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.WriteLine(true);
            escritor.WriteLine(false);
            escritor.WriteLine(45454545454545);
        }

        Console.WriteLine("Aplicação Finalizada...");
        
        Console.ReadLine();
    }
}