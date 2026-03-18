using System;
using System.Security.Cryptography.X509Certificates;

class Conta
{
    public string Nome;
    public void MostrarDados()
    {
        Console.WriteLine(Nome);
    }
}


class Program
{
    static void Main()
    {
        Conta cliente1 = new Conta();
        cliente1.Nome = "Carlos";
        cliente1.MostrarDados();
    }
}

