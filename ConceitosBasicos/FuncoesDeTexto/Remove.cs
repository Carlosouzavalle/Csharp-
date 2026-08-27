// // O método Remove serve para capturar uma quantidade de ca-
// // racteres à esquerda de uma expressão, por exemplo, ler apenas os
// // primeiros 10 caracteres. No nosso código, adicione as linhas a se-
// // guir para testarmos o Remove. Note que o Remove está sendo usado
// // na variável empresa, o qual está declarado que apenas os 9 primei-
// // ros caracteres devem ser mostrados.

// class Remove
// {
//     static void Main(string[] args)
//     {
//         string frase = "Remove os caracteres -  extrai x caracteres a partir da esquerda da expressão";
//         Console.WriteLine($"texto esquerdo: {frase.Remove(20)}");

//         string[] nomes = {"Fabricio dos Santtos", "Jose da silva", "Roberta Brasil"};
//         foreach(var n in nomes)
//         {
//             Console.WriteLine(n.Remove(n.IndexOf(" ")));
//         }
//     }
// }


// // Isto é bem comum, pois o Remove precisa saber quantos carac-
// // teres deve extrair à esquerda. E, como cada primeiro nome tem
// // um tamanho diferente, como dizer ao Remove a exata posição. Para
// // isto, usamos o método IndexOf que retorna a posição exata de onde
// // encontrar o espaço em branco, neste caso, IndexOf(“ “).
// // Ou seja, a cada iteração no looping ele pega o nome completo,
// // pesquisa a posição do espaço em branco, por exemplo 8 no primei-
// // ro nome, e usa para extrair os 8 primeiros caracteres.