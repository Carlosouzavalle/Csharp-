using System;
using System.Collections.Generic;


class CidadesDictionary
{
    static void Main(string[] args)
    {
        var cidades = new Dictionary<string, string>
        {
            ["MG"] = "Minas Gerais",
            ["SP"] = "São Paulo",
            ["SC"] = "Santa Catarina",
            ["RS"] = "Rio Grande do Sul",
        };


        Console.WriteLine($"--------- Dictionary com {cidades.Count()} Cidades");
        Console.WriteLine(cidades["MG"]);
        // Console.WriteLine(["mg"]); // gera erro
        // Console.WriteLine(cidades[0]); // erro de compilação
        foreach (var cidade in cidades)
        {
            Console.WriteLine($"Sigla: {cidade.Key} - {cidade.Value}");
        } 
    }
}




// Note que para saber a quantidade de elementos no dicionário
// usamos o Count(), ou seja, basta contar o número de elementos.
// Para exibir o conteúdo (nome do estado) é preciso buscar pela
// chave, que neste caso é o “MG”. No entanto, se você buscar por
// “mg” dará um erro em tempo de execução, pois não existe. Todas
// as chaves são sensíveis a escrita, maiúsculas são diferentes de mi-
// núsculas. Outro tipo de erro que ocorre, neste caso, erro de compi-
// lação é o uso pelo índice [0]. Isto não é permitido neste caso, pois a
// chave é alfanumérica.
// Em seguida, para listar todo o dicionário, usamos um looping do
// tipo foreach varrendo toda a lista. Note que a sintaxe do foreach
// temos a declaração do tipo var cidade (nome qualquer de uma vari-
// ável criada em tempo de compilação), seguido da variável que con-
// tém todo o dicionário, neste caso, in cidades.
// Para listar a chave e o conteúdo de cada item do dicionário den-
// tro do looping foreach, usamos o WriteLine para ler a chave (cidade.
// Key) e o valor (cidade.Value). Sendo assim, qualquer acesso à chave
// ocorre pela palavra chave Key e para o valor, o Value.
// O uso do looping foreach varre todos os itens da coleção cidades,
// ou seja, você não precisa se preocupar quando terminará a leitura