// // Herança + virtual + override

// namespace ConceitosBasicos
// {
//     class Program7
//     {

//         class Animal
//         {
//             public virtual void EmitirSom()
//             {
//                 Console.WriteLine("Animal emitindo som....");
//             }
//         }


//         class Cachorro : Animal
//         {
//             public override void EmitirSom()
//             {
//                 // base.EmitirSom();
//                 Console.WriteLine("AU AU!");
//             }
//         }

//         class Gato : Animal
//         {
//             public override void EmitirSom()
//             {
//                 Console.WriteLine("Miau!");
//             }
//         }
//         static void Main(string[] args)
//         {
//             Cachorro cachorro = new Cachorro();
//             Gato gato = new Gato();
//             gato.EmitirSom();
//             cachorro.EmitirSom();
//         }
//     }
// }