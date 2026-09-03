// Uma outra forma que existe de conversão de tipos de dados é
// através do Parse. A sintaxe deve conter o tipo de campo (Int32, Int64,
// int, DateTime) seguido do .Parse contendo o valor a ser convertido.
// Adicione o código a seguir onde temos diversos exemplos de
// Int16, Int64, int e DateTime. Note que quando há um texto com sím-
// bolos de negativos (parênteses ou - ), separador de milhar, símbolo
// da moeda R$ ou espaço em branco à esquerda ou direita do núme-
// ro, é preciso informar ao Parse do que se trata. Isto ocorre através
// do Enum NumberStyles (AllowParentheses, AllowThousands, AllowCur-
// rencySymbol, AllowLeadingSign, AllowLeadingWhite, AllowTrailingWhi-
// te).
// No exemplo a seguir, no uso do símbolo da moeda, colocamos o
// comando para exibir o nome da cultura atual CultureInfo.CurrentCul-
// ture.Name e o símbolo de moeda usado NumberFormatInfo.Curren-
// tInfo.CurrencySymbol. Todo o código está dentro do bloco try .. catch,
// pois se ocorrer algum erro na conversão, o código cairá no catch e
// será mostrada uma mensagem de erro.


using System.Globalization;

class Program5
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("-----.Parse");
            Console.WriteLine($"{Int16.Parse("150")}");
            Console.WriteLine($"{Int64.Parse("1500000000000")}");
            Console.WriteLine($"{int.Parse("150")}");
            Console.WriteLine($"{DateTime.Parse("12/07/2024")}");

            Console.WriteLine($"Cultura atual: {CultureInfo.CurrentCulture.Name}");
            Console.WriteLine($"Símbolo da moeda atual: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");

            string valorMoeda = "R$ 1.234,56";
            Console.WriteLine($"{decimal.Parse(valorMoeda,
                NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands |
                NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite,
                CultureInfo.CurrentCulture)}");

            string valorNegativo = "(150)";
            Console.WriteLine($"{int.Parse(valorNegativo,
                NumberStyles.AllowParentheses | NumberStyles.AllowLeadingWhite |
                NumberStyles.AllowTrailingWhite)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na conversão: {ex.Message}");
        }
    }
}


// Cada NumberStyles controla quais formatos são permitidos.
// O NumberStyles funciona como uma espécie de lista de permissões para o formato do número.
// Isso é bastante útil quando você começa a trabalhar com dados vindos de usuários, arquivos CSV, APIs e valores monetários, onde o formato do texto pode variar.

// Um detalhe importante: NumberStyles trabalha muito junto com CultureInfo. O mesmo "1.000,50" pode significar coisas diferentes dependendo se você está usando cultura pt-BR ou en-US.


// NumberStyles	Permite
// AllowParentheses	(100)
// AllowThousands	1.000 / 1,000
// AllowCurrencySymbol	R$ 100
// AllowLeadingSign	+100 / -100
// AllowLeadingWhite	" 100"
// AllowTrailingWhite	"100 "