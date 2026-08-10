using System;

class Program2
{

    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public double Preco { get; set; }

        public Livro(string titulo, string autor, double preco)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Preco = preco;
        }

        public void MostrarResultados()
        {
            Console.WriteLine(Titulo);
            Console.WriteLine(Autor);
            Console.WriteLine(Preco);
        }
    }

    static void Main(string[] args)
    {
        Livro livro = new Livro("O Hobbit",  "J.R.R. Tolkien",  39.90);
        livro.MostrarResultados();
    }
}