int valor1 = 2; // CS0219: Mantido para possível uso futuro  
int valor2 = 3; // CS0219: Mantido para possível uso futuro  
var valor3 = 9;
int raiz = (int)Math.Sqrt(valor3); // CS0266: Conversão explícita adicionada  

Console.WriteLine($"Raiz quadrada de {valor3} é {raiz}");
Console.WriteLine(valor1 * 2);
Console.WriteLine(valor2 * 3);
Console.ReadKey();