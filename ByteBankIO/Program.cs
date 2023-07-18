﻿using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
        var buffer = new byte[1024];    // 1KB

        while(numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

        // public override int Read(byte[] array, int offset, int count);

        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer)
    {
        foreach (byte b in buffer)
        {
            Console.Write(b);
            Console.Write(' ');
        }
    }
}