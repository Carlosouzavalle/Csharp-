// int valor1 = 5;

// Console.WriteLine($"O valor {valor1} tem como antecessor o valor {valor1 - 1} e sucessor o valor {valor1 + 1}.");


Console.Write("Digite um valor: ");
if (int.TryParse(Console.ReadLine(), out int valor))
{
    Console.WriteLine($"O valor {valor} tem como antecessor o valor {valor - 1} e sucessor o valor {valor + 1}.");
}
else
{
    Console.WriteLine("Valor inválido.");
}

// O que é out?
// O out permite que um método retorne um valor através de um parâmetro, além do valor de retorno normal.
// Pense assim:
// return → devolve 1 valor.
// out → permite devolver outros valores.


// Regra fácil de lembrar
// return → devolve um resultado.
// out → o método escreve um valor em uma variável fornecida pelo chamador.
// ref → o método lê e pode modificar uma variável existente.


// Diferença entre ref e out
// Essas duas palavras-chave são parecidas, mas têm uma diferença importante:
// ref	out
// A variável deve estar inicializada antes da chamada.	A variável não precisa estar inicializada.
// O método pode ler o valor recebido.	O método é obrigado a atribuir um valor antes de terminar