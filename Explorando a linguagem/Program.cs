using ExemploExplorando.Models;


LeituraArquivo arquivo = new LeituraArquivo();

// (bool sucesso, string[] linhasArquivos, int QuantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
var (sucesso, linhasArquivos, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine($"Quantidade Linhas Arquivos: {quantidadeLinhas}");
    foreach (var linha in linhasArquivos)
    {
        Console.WriteLine(linha);
    }
}
else{
    Console.WriteLine("Não foi possível ler o arquivo");
}
