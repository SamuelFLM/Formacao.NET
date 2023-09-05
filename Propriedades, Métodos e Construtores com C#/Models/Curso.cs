using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public Curso() { }
        public Curso(string nome)
        {
            this.Nome = nome;
            this.Alunos = new List<Pessoa>();
        }

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"\nAlunos do curso de: {Nome}\n\nAlunos:\n");

            for (int i = 0; i < Alunos.Count; i++)
            {
                int numero = i + 1;
                Console.WriteLine($"\t Aluno {numero} - {Alunos[i].NomeCompleto}\n");
            }
        }
    }
}