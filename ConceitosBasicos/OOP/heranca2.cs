// // // base

// // namespace ConceitosBasicos
// // {
// //     class Program6
// //     {

// //         class Animal
// //         {
// //             public string? Nome { get; set;}     

// //             public void Comer()
// //             {
// //                 Console.WriteLine("O animal esta comendo");
// //             }
// //         }

// //         class Cachorro : Animal
// //         {
// //             public void Teste()
// //             {
// //                 base.Comer();
// //             }
// //         }


// //         static void Main(string[] args)
// //         {
// //             Animal animal = new Animal();
// //             animal.Comer();   
// //         }
// //     }
// // }



// // O mesmo codigo só que coom construtores 

// namespace ConceitosBasicos
// {

//     class Program6
//     {
//         class Animal
//         {
//             public string Nome { get; set; }

//             public Animal(string nome)
//             {
//                 Nome = nome;
//             }
//         }


//         class Cachorro : Animal
//         {
//             public string Raca { get; set; }

//             public Cachorro(string nome, string raca) : base(nome)
//             {
//                 Raca = raca;
//             }
//         }
    
    
    
//         static void Main(string[] args)
//         {
//             Cachorro cachorro = new Cachorro("Rex", "Pastor-Alemão");
//             Console.WriteLine(cachorro.Nome);
//             Console.WriteLine(cachorro.Raca);
//         }
    
//     }

// }