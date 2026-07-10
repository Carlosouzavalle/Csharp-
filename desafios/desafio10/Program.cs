Console.WriteLine("Digite um valor: ");
double valor = double.Parse(Console.ReadLine());

double dolar = 5.25;
Console.WriteLine($"O valor de {valor} você pode comprar {valor / dolar:F2} dólares");