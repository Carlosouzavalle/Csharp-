// Console.WriteLine("Qual a qtd de KM percorida?");
// double qtdKM = double.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Qual a qtd de dias você alugou");
// double qtdDias = double.Parse(Console.ReadLine() ?? "0");
// int valorPorDias = 60;
// double valorPorKm = 0.15;
// Console.WriteLine($"O valor a paga é {(valorPorDias * qtdDias) + valorPorKm + qtdKM}");



Console.WriteLine("Qual a qtd de KM percorida?");
double.TryParse(Console.ReadLine(), out double qtdKM);
Console.WriteLine("Qual a qtd de dias você alugou");
double.TryParse(Console.ReadLine(), out double qtdDias);
int valorPorDias = 60;
double valorPorKm = 0.15;
Console.WriteLine($"O valor a paga é {(valorPorDias * qtdDias) + valorPorKm + qtdKM}");