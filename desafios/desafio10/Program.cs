Console.WriteLine("Quantos dolares você quer comprar? ");
string entrada = Console.ReadLine();



if(decimal.TryParse(entrada, out decimal real))
{
    decimal dolar = 5.25m;
    decimal valorEmDolar = real / dolar;

    Console.WriteLine($"{real.ToString("C", new System.Globalization.CultureInfo("pt-BR"))} compram {valorEmDolar.ToString("C", System.Globalization.CultureInfo.InvariantCulture)} dólares");
}
else
{
    Console.WriteLine("Valor inválido, tente novamente.");
}



Console.ReadKey();