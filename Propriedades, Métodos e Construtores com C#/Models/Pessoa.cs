using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
        public Pessoa(string nome, string sobrenome, int idade)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
        }
        private string _nome; // Utilizado para armazenar o nome - Se chama campo
        private int _idade; // Utilizado para armazenar a idade
        private string Nome // se chama propriedade, porque? pois tem get e set
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        private string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        private int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }

        public void Apresentar() => Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");

    }


}