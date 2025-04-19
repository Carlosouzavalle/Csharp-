Console.WriteLine("Quantos dolares você quer comprar? ");
string entrada = Console.ReadLine();

if(decimal.TryParse(entrada, out decimal resuult))
{
    decimal cotacao = 5.25m;
    decimal valorEmDolares = resuult / cotacao;
    //Console.WriteLine(resuult);
    Console.WriteLine($"Com tantos {entrada}R$ você pode comprar {valorEmDolares:F2} Dolares");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();

// {valorEmDolares.ToString("C", new System.Globalization.CultureInfo("pt-BR"))} Dolares")
// essa linha vai formatar o valor em dolares para o formato brasileiro

// Segunda Opção 
// {valorEmDolares:F2}