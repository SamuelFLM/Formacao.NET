using ExemploExplorando.Models;


//Maneira mais recomendada
(int Id, string Nome, string Sobrenome) tupla = (1, "samuel", "felipe");

Console.WriteLine(tupla); // Todos valores
Console.WriteLine(tupla.Id); // peguei o primeiro valor da tupla
Console.WriteLine(tupla.Nome); 
Console.WriteLine(tupla.Sobrenome); 