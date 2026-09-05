using System;
using static System.Console;

namespace ConceitosBasicos
{
    public static class MetodosExtensao
    {
        // o método de extensão DEVE ser static
        public static string FormatarData(
            this DateTime dta, string formato)
            => dta.ToString(formato);

        public static string Formatar(
            this decimal valor, string formato)
            => valor.ToString(formato);
    
    

        static void Main(string[] args)
        {
            Console.WriteLine($"{DateTime.Today.FormatarData("dd/MMM/yyyy")}");
            Console.WriteLine($"{DateTime.Today.FormatarData("dddd dd/MMM/yyyy")}");
            Console.WriteLine($"{DateTime.Today.FormatarData("MMMM yyyy")}");
            Console.WriteLine($"{DateTime.Today.FormatarData("yyyy")}");

            decimal valor = 5800.78M;


            Console.WriteLine(valor.Formatar("R$ ##,##0.00"));

            Console.WriteLine($"{4578.87M.Formatar("C2")}");
            Console.WriteLine(4578.87M.Formatar("C2"));
            ReadLine();

        }
    
    
    }
}