double catetoOposto = 5;
double catetoAdjacente = 12;
double hipotenusa = Math.Sqrt(Math.Pow(catetoOposto, 2) + Math.Pow(catetoAdjacente, 2));
Console.WriteLine($"A hipotenusa é: {hipotenusa}");

// Math.Pow é uma função que eleva um número a uma potência. No caso, estamos elevando o cateto oposto e o cateto adjacente ao quadrado (2).
// Math.Sqrt é uma função que calcula a raiz quadrada de um número. No caso, estamos calculando a raiz quadrada da soma dos quadrados dos catetos.