object valor = "   ";


Console.WriteLine($"O tipo de 'valor' é: {valor.GetType()}");
Console.WriteLine($"O valor é alfanumerico: {valor is string}");
Console.WriteLine($"O Valor tem apenas espaços em branco {valor is string str && string.IsNullOrWhiteSpace(str)}");
Console.WriteLine($"Esta em Maiusculo {valor is string str2 && str2 == str2.ToUpper()}");
Console.WriteLine($"Esta em Minusculo {valor is string str3 && str3 == str3.ToLower()}");


Console.WriteLine($"Esta Captalizada {valor is string srt4 && !string.IsNullOrWhiteSpace(srt4) && srt4 == char.ToUpper(srt4[0]) + srt4.Substring(1)}");



// Se seu objetivo é validar se um valor é uma string vazia ou com espaços, a variável precisa ser do tipo string ou object:

// Pattern Matching (C#)
// O operador 'is' permite verificar se um valor é de um determinado tipo.
// Caso a verificação seja verdadeira, uma variável do tipo correspondente
// pode ser criada e utilizada na mesma expressão.
//
// Exemplo:
// if (objeto is string texto)
// {
//     Console.WriteLine(texto.Length);
// }


// Problema na antiga linha
// Console.WriteLine($"Esta Captalizada {valor is string srt4 && srt4 == char.ToUpper(srt4[0]) + srt4.Substring(1)}");

// Como valor contém apenas espaços (" "), a expressão funciona, mas se a string fosse vazia (""), você receberia uma exceção:  IndexOutOfRangeException
// porque srt4[0] não existe.


// Por que Maiúsculo e Minúsculo retornam True?
// Porque uma string composta apenas por espaços não possui letras para converter:
// Por isso, se você quiser verificar se há texto realmente em maiúsculas ou minúsculas, é melhor combinar com:
// !string.IsNullOrWhiteSpace(str)


// Você pode extrair partes de uma string usando o método Substring ou encontrar substrings usando métodos como IndexOf e Contains.