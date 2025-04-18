//Console.WriteLine("Digite um numero para ver  a tabuada");
//int num = int.Parse(Console.ReadLine()); // aqui vai converter o valor que vier do console para inteiro
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{num} x {i} = {num * i}");
//}
//Console.ReadKey();


// Outra forma de fazer

//Console.WriteLine("Digite um numero para ver a tabuada");
//string? input = Console.ReadLine();
//if (!string.IsNullOrEmpty(input))
//{
//    int num = int.Parse(input);
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{num} x {i} = {num * i}");
//    }
//}
//else
//{
//    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
//}

//Console.ReadKey();

//Outra maneira

Console.WriteLine("Digite um numero para ver a tabuada");
string entrada = Console.ReadLine();
if(int.TryParse(entrada, out int num_))
{
    Console.WriteLine($"Tabuada do {num_}:");
    for(int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{num_} x {i} = {num_ * i}");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
}

Console.ReadKey();


//int.Parse() → direto, mas pode quebrar com entrada inválida.

//int.TryParse() → mais seguro, ideal para programas que vão para outras pessoas usarem.