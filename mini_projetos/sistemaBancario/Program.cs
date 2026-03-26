using System;

class Conta
{
    public string Nome;

    public Conta(string nome)
    {
        Nome = nome;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
    }
}


class Program
{
    static void Main()
    {
        Conta cliente1 = new Conta("Carlos");
        cliente1.MostrarDados();
    }
}

