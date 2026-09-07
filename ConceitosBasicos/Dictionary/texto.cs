using System;
using System.Collections.Generic;

class Texto
{
    static void Main(string[] args) {

        var texto = new string[]
        {
          "Meu", // 0 ^9
          "codigo", // 1 ^8
          "rodou", // 2 ^7
          "sem", // 3 ^6
          "erros", // 4 ^5
          "para", // 5 ^4
          "ler", // 6 ^3
          "cadastro", // 7 ^2
          "clientes" // 8 ^1
        };


        Console.WriteLine("----Indice do dicionario");
        Console.WriteLine($"A ultima palavra é {texto[^1]}");
        Console.WriteLine($"A primeira palavra é {texto[^9]}");

        Console.WriteLine("\n");
        Console.WriteLine("Parte do texto");
        var pedacoTexto = texto[1..4];
        foreach(var pedaco in pedacoTexto)
        {
            Console.WriteLine(pedaco);
        }

        Console.WriteLine("\n");
        Console.WriteLine("Intervalo na coleção");
        Range intervalo = 1..6;
        foreach(var p in texto[intervalo])
        {
            Console.WriteLine(p);
        }

        
        Console.WriteLine("\n");
        var todas = texto[..];
        Console.WriteLine("As 4 primeiras");
        var Primeiras4 = texto[..4]; // primeiras 4 palvras e para as 5 ultimas é o inverso 4.. 
        foreach(var p2 in Primeiras4)
        {
            Console.WriteLine(p2);
        }




    }
}


// Com os índices associados às palavras, como saber qual é a pri-
// meira e a última palavra do array? Basta referenciar o ^9 para a
// primeira e o ^1 para a última. Note que esta sintaxe não usamos o
// ^0, e sim o ^1 para o final da lista.


// E para capturar apenas uma parte dos itens do array? Veja a de-
// claração da variável pedacoTexto que captura as palavras contidas
// entre os índices 1 e 4, inclusive. No looping foreach é usada a cole-
// ção pedacoTexto, contendo só as palavras de 1 a 4.


// Uma opção é usar o Range de um intervalo, neste caso, a variável
// intervalo contém os índices de 1 a 6. E no looping foreach é usado a
// variável texto seguido do número do índice do intervalo, por exem-
// plo, texto[1], texto[2], etc


// Caso queira capturar todas as palavras use apenas o .. na lista
// de índice, texto[..]. Para ler apenas as 4 primeiras palavras, use tex-
// to[..4]