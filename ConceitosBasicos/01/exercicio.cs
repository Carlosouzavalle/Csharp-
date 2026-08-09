using System;

namespace ConceitosBasicos
{
    class Program1
    {
        class Produto
        {
            private int estoque;

            public string Nome { get; set; } = string.Empty;
            public double Preco { get; set; }
            public int Estoque
            {
                get { return estoque; }
                set
                {
                    if(value >= 0)
                    {
                        estoque = value;
                    }
                }
            }

            public void MostrarResultado()
            {
                Console.WriteLine($"{Nome}");
                Console.WriteLine($"{Preco}");
                Console.WriteLine($"{Estoque}");
            }
        }



        class Exercicio
        {
            static void Main(string[] args)
            {
                Produto p = new Produto();  
                p.Nome = "Camisa";
                p.Preco = 25.00;
                p.Estoque = -3;


                p.MostrarResultado();
            }
        }   
    }
}
