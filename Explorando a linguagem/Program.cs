
using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2022-04-27 18:00";

bool sucesso = DateTime.TryParseExact(dataString, // Propria data que deseja trabalhar
                        "yyyy-MM-dd HH:mm", // informa o formato que a data estar. (Tem que ser da mesma forma que está no DataString)
                        CultureInfo.InvariantCulture, // Colocando um padrao para definir o que voce espera.
                        DateTimeStyles.None, out DateTime data); // Se conseguir converter ou não coloca na variavel data


if (sucesso){
    Console.WriteLine($"Conversão com sucesso! Data : {data}");
}
else{
    Console.WriteLine($"{dataString} não e uma data valida.");
}



// Pessoa p = new Pessoa(nome: "Samuel", sobrenome: "Lima");

// Pessoa p2 = new Pessoa(nome: "Ana", sobrenome: "clara");

// Curso curso = new Curso("Dev");

// curso.AdicionarAluno(p);
// curso.AdicionarAluno(p2);
// curso.ListarAlunos();
