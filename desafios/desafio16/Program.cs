// var num = 20.8;
// var num2 = 10.5;
// var total = num + num2;
// Console.WriteLine($"{total:F0}");


Console.WriteLine("Digite um número: ");
double num = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine($"A porção inteira é: {Math.Truncate(num)}");

//Math.Truncate(numero) remove a parte decimal sem arredondar.