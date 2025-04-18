//se for medidadas exata funciona, porem medidas ex: 1.5 não funciona vai quebrar 

//Console.Write("Digite a altura: ");
//double altura = double.Parse(Console.ReadLine());

//Console.Write("Digite a largura: ");
//double largura = double.Parse(Console.ReadLine());

//double area = altura * largura;
//Console.Write($"a area da parede é de {area}m ");
//Console.ReadKey();



// vai receber o valor de altura
Console.WriteLine("Digite a altura da parede: ");
string entradaAltura = Console.ReadLine();
Console.WriteLine("Digite a largura da parede: ");
string entradaLargura = Console.ReadLine();

if (double.TryParse(entradaLargura, out double altura) && double.TryParse(entradaAltura, out double largura))
{
    double area = altura * largura;
    Console.WriteLine($" o tamanho da parede é {area:F1}"); // F1 é para formatar com uma casa decimal
    Console.ReadKey();
}
else
{
    Console.WriteLine("Valores inválidos");
}