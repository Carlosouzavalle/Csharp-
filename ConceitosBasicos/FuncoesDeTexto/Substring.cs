// O método Substring é usado para extrair parte do texto a partir
// de uma posição inicial. O tamanho do texto a ser capturado pode
// ou não ser informada, caso não seja, todo o texto a partir da posi-
// ção é capturado. Caso declarado o tamanho, é capturado o texto
// conforme o número de caracteres.

// namespace ConceitosBasicos
// {
//     class Program8
//     {

//         static void Main(string[] args)
//         {
//             string NivelLivro = "Este livro é básico de C#";
//             // Console.WriteLine("Substring é usado para extrair uma parte do texto");
//             Console.WriteLine(NivelLivro.Substring(5, 14));

//             string[] cesta = { "5 laranjas", "10 goiabas", "5 Pêssegos doces", "5 Bananas" };

//             foreach (var p in cesta)
//             {
//                 Console.WriteLine($"{p.Substring(p.IndexOf(" ") + 1)}");
//             }
//         }
//     }
// }