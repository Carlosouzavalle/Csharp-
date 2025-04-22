Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Analizando seu texto...");
Console.WriteLine($"Seu nome tem {nome.Length} letras.");
string primeiroNome = nome.Split(' ')[0]; // pega o primeiro nome antes do espaço
Console.WriteLine($"Seu primeiro nome é {primeiroNome} e tem {primeiroNome.Length} letras.");
Console.WriteLine($" Seu nome em maisusculo è {nome.ToUpper()}");
Console.WriteLine($"Seu nome em minusculo é {nome.ToLower()}");