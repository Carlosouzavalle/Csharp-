// namespace ConceitosBasicos
// {
//     using System;

//     class Pessoa
//     {
//         public string nome = string.Empty;
//         public int idade;

//         public void Apresentar()
//         {
//             Console.WriteLine($"Nome: {nome} Idade: {idade}");
//         }

//         public Pessoa(string nome, int idade)
//         {
//             this.nome = nome;
//             this.idade = idade;
//         }
//     }


//     class Aluno : Pessoa
//     {
//         public string? Curso;
//         // public void Apresentaraluno()
//         // {
//         //     base.Apresentar();
//         //     Console.WriteLine("Novo aluno");
//         // }


//         public Aluno(string nome, int idade) 
//             : base(nome, idade)
//         {
//         }
//     }


//     class Program5
//     {
//         static void Main()
//         {
//             {
//                 Aluno a = new Aluno("Samanta", 27);

//                 // a.nome = "Carlos";
//                 // a.idade = 27;
//                 a.Curso = "Software Engeenier";

//                 a.Apresentar();

                
//             }
//         }
//     }
// }