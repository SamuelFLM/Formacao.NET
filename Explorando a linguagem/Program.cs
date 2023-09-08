using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Samuel", "Felipe");

(string nome, string sobrenome) = p1;

Console.WriteLine(nome + sobrenome);

// LeituraArquivo arquivo = new LeituraArquivo();

// // (bool sucesso, string[] linhasArquivos, int QuantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// var (sucesso, linhasArquivos, _ ) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     //Console.WriteLine($"Quantidade Linhas Arquivos: {quantidadeLinhas}");
//     foreach (var linha in linhasArquivos)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }
