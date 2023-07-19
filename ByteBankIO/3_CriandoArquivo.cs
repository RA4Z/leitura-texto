﻿using System.Text;
using ByteBankIO;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";
            
            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }
    static void CriarArquivoComWriter()
    {
        //FileMode.Create SUBSTITUI O ARQUIVO NO CAMINHO
        //FileMode.CreateNew SOMENTE CRIA UM NOVO ARQUIVO CASO O MESMO NÃO EXISTA NO DIRETÓRIO ALVO
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("456, 7895, 4789.40, Robert Zimmermann");
        }
    }
    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush();   //Despeja o buffer para o Stream

                Console.WriteLine($"Linha {i} foi escrita no arquivo .Tecle enter...");
                Console.ReadLine();
            }
        }

    }
}
