// // O método Split é muito usado em situações de tratamento de
// // dados oriundos de arquivos textos, CSV, Excel, onde é preciso sepa-
// // rar as cadeias de caracteres através de um caractere chave. O mais
// // usado é o espaço em branco, mas pode ser qualquer caractere.


// class Split
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Divide e extrai cada palavra em um array");

//         string NivelLivro = "Este Livro é básico de C#";
//         string[] blocos = NivelLivro.Split(" ");
//         var contador = 1;
//         foreach (var exp in blocos)
//         {
//             Console.WriteLine($"Texto {contador++}: {exp}");
//         }
//         Console.WriteLine($"Qtd de palavras: {blocos.Count()}");
//     }
// }