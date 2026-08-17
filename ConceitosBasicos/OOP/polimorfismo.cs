namespace ConceitosBasicos
{
    class Program3
    {
        abstract class Animal
        {
            public abstract void EmitirSom();
        }

        class Cachorro : Animal
        {
            public override void EmitirSom()
            {
                Console.WriteLine("AUAU");
            }
        }

        class Gato : Animal
        {
            public override void EmitirSom()
            {
                Console.WriteLine("MIAU MIAU");
            }
        }


        class Vaca : Animal
        {
            public override void EmitirSom()
            {
                Console.WriteLine("Muuuuuu");
            }
        }


        static void Main(string[] args)
        {
            Animal[] animals =
            {
              new Cachorro(),
              new Gato(),
              new Vaca()  
            };

            foreach(Animal animal in animals)
            {
                animal.EmitirSom();
            }
        }
    }
}