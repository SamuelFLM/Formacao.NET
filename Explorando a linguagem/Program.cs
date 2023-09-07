
using ExemploExplorando.Models;

Stack<int> pilha = new Stack<int>();

pilha.Push(10);
pilha.Push(11);
pilha.Push(12);

Console.WriteLine($"Removendo: {pilha.Pop()}");

foreach(int item in pilha){System.Console.WriteLine(item);}

// Pessoa p = new Pessoa(nome: "Samuel", sobrenome: "Lima");

// Pessoa p2 = new Pessoa(nome: "Ana", sobrenome: "clara");

// Curso curso = new Curso("Dev");

// curso.AdicionarAluno(p);
// curso.AdicionarAluno(p2);
// curso.ListarAlunos();
