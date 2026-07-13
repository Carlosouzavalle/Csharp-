// int catetoOposto = 10;
// int catetoAdjacente = 10;

// double hipotenusa = Math.Sqrt(
//     Math.Pow(catetoOposto, 2) +
//     Math.Pow(catetoAdjacente, 2)
// );

// Console.WriteLine($"{hipotenusa:F2}");


int catetoOposto = 10;
int catetoAdjacente = 10;

double hipotenusa = Math.Sqrt(
    Math.Pow(catetoOposto, 2) +
    Math.Pow(catetoAdjacente, 2)
);


int convertt = (int)hipotenusa;

Console.WriteLine($"{Convert.ToInt32(convertt)}");



// Isso aqui é um cast utilizamos para converter 
// int convert = (int)hipotenusa;

// Podemos também arrendodar esse valor de algumas maneiras
// int convert = Convert.ToInt32(hipotenusa);
//ou  
// int convert = (int)Math.Round(hipotenusa); 
// ou
// convertt:F0

// TryParse(...) → converte uma string para número.