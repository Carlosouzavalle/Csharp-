var qtdKM = 50;
var qtdDiasAlugados = 10;
var valorPorDia = 60;
var valorPorKM = 0.15;

var valorTotal = (qtdDiasAlugados * valorPorDia) + (qtdKM * valorPorKM);
Console.WriteLine($"O valor total do aluguel é: R$ {valorTotal}");
