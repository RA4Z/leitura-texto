using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine();    LÊ A PRIMEIRA LINHA DO ARQUIVO

            //var texto = leitor.ReadToEnd();   LÊ O ARQUIVO INTEIRO DE UMA VEZ

            //var numero = leitor.Read();       TRAZ O PRIMEIRO CÓDIGO DO ARQUIVO

            while(!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }

        }
        Console.ReadLine();
    }

}