
int catetoOposto = 10;
int catetoAdjacente = 10;

double hipotenusa = Math.Sqrt(
    Math.Pow(catetoOposto, 2) +
    Math.Pow(catetoAdjacente, 2)
);

Console.WriteLine($"{hipotenusa:F2}");