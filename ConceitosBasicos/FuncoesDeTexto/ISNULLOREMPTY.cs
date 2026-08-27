// O método IsNullOrEmpty verifica se uma String está nula ou va-
// zia. Isto é muito usado onde há interação com o usuário, afim de
// consistência de dados. Em casos de manipular um objeto entre as
// camadas de acesso a dados e interface, também usamos com fre-
// quência.
// Vamos a um exemplo prático o qual temos duas variáveis, nome
// e sobrenome. Em seguida há um IF questionando se a variável
// Nome é diferente de nula ou vazia. Na sintaxe, note que o uso do !
// (exclamação) antes do String.IsNullOrEmpty indica a negativa.
// Já o uso do && significa E (AND) na condição, ou seja, se as variá-
// veis Nome e Sobrenome forem diferentes de nulo ou vazia, mostre
// o nome completo. Caso contrário, mostre apenas o nome.
// Neste caso, poderíamos ter usado apenas um &, o que também
// indica o E (AND). Mas, no C# quando temos mais de uma condição a
// ser avaliada é melhor usar dois &&. Isto porque quando a primeira
// condição não atende ao critério, as demais não são nem validadas.
// Já o uso de um &, todas as condições são avaliadas, mesmo que as
// anteriores sejam falsas.


// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("IsNullOrEmpty verifica se a string esta vazia ou nula");

//         string nome = "Renato";
//         string? sobrenome = null;
//         if(!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(sobrenome))
//         {
//             Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
//         } else {
//             Console.WriteLine($"Nome: {nome}");
//         }
//     }
// }