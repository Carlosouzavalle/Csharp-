using System;

namespace ConceitosBasicos
{
    class Program
    {
        
        class Pessoa
        {
            
            // public string Nome { get; set ; } = string.Empty; 
            private string nome = string.Empty;
            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }
            public int Idade { get; set; }
            public String Endereco { get; set; } = string.Empty;

            // public string Nome;
            // public int Idade;
            // public String Endereco;

            // public Pessoa(string nome, int idade, string endereco)
            // {
            //     Nome = nome;
            //     Idade = idade;
            //     Endereco = endereco;
            // }

            public void MostrarResultados()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Idade: {Idade}");
                Console.WriteLine($"Endereço: {Endereco}");
            }
        }

        

        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa {
                Nome = "Carlos",
                Idade = 28,
                Endereco = "Rua ABC123"
            };
            pessoa.MostrarResultados();


            pessoa.Nome = "James";
            pessoa.MostrarResultados();

            // Pessoa pessoa = new Pessoa("Carlos", 28, "Rua ABC123");
            // pessoa.MostrarResultados();

        }

    }
}