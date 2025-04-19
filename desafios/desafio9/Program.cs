string valor = Console.ReadLine();

if(int.TryParse(valor, out int numero))
{
    for(int i = 1; i <= 10; i++)
    {
       Console.WriteLine($"{valor} x {i} - {i * numero}");
    }
}

Console.ReadKey();