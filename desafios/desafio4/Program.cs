//Console.Write("Digite algo: ");
//string valor = Console.ReadLine();
//Console.Read();

//==========================================================================================================

// white space or not
//bool valor2 = string.IsNullOrWhiteSpace(" ");
//Console.Write(valor2);

//==========================================================================================================

//isnumeric or not 
//Primeira maneira

// Para verificar si un string es numérico
//string valor = "123";
//bool esNumerico = int.TryParse(valor, out _);
//Console.WriteLine($"¿Es un número? {esNumerico}");
//Console.Read();

// segunda maneira

//object obj = 123;
//bool esNumero = obj is int || obj is decimal || obj is double;
//Console.WriteLine($"este valor es numerico: {esNumero}");
//Console.Read();


// terceira maneira

//namespace Desafio
//{
//    public static class StringExtensions
//    {
//        public static bool IsNumeric(this string s)
//        {
//            return double.TryParse(s, out _);
//        }
//    }

//    class Program
//    {
//        static void Main(String[] args)
//        {
//            string valor = "123";
//            bool esNumerico = valor.IsNumeric();
//            Console.WriteLine($"¿Es un número? {esNumerico}");
//            Console.Read();
//        }
//    }
//}

//==========================================================================================================
// is alphabetic or not

//object valor = "carlos";
//bool esAlfabetico = valor is string;
//Console.WriteLine($"es un valor alfabetico: {esAlfabetico}");
//Console.Read();

//==========================================================================================================

// is alphanumeric or not

object valor = "Carlos123";
bool esAlfanumerico = valor is string && System.Text.RegularExpressions.Regex.IsMatch((string)valor, @"^[a-zA-Z0-9]+$");
Console.WriteLine($"es alfanum: {esAlfanumerico}");
Console.Read();

//==========================================================================================================