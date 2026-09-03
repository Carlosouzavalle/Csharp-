// Há mais uma forma de conversão de tipos que usamos no C#,
// chama-se Convert.To(tipo). A sintaxe é simples, basta escrever o Con-
// vert.To+tipo de dado, que pode ser Int16, Int32, Int64, Decimal, String,
// Boolean ou DateTime

using System;
using System.Globalization;

class Program6
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("--------Convert Números");
            int n1 = Convert.ToInt16("100");
            Console.WriteLine($"{n1.GetType()} - {n1}");
            Int32 n2 = Convert.ToInt32("200500");
            Console.WriteLine($"{n2.GetType()} - {n2}");
            Int64 n3 = Convert.ToInt64("1003232131321321");
            Console.WriteLine($"{n3.GetType()} - {n3}");

            decimal preco = Convert.ToDecimal(
                "1420,50",        
                CultureInfo.GetCultureInfo("pt-BR")
            );
            Console.WriteLine($"{preco.GetType()} - {preco:n2}");
            
            
            Console.WriteLine("--------Convert String");
            string texto1 = Convert.ToString(250.59M);
            Console.WriteLine($"{texto1.GetType()} - {texto1} - resultado: {texto1 ?? "texto é nulo"}");


            Console.WriteLine("----- Convert Bool");
            bool valido = Convert.ToBoolean("false");
            Console.WriteLine($"{valido.GetType()} - {valido}");
            Console.WriteLine($"0 - {Convert.ToBoolean(0)}");
            Console.WriteLine($"1 - {Convert.ToBoolean(1)}");
            Console.WriteLine($"100 - {Convert.ToBoolean(100)}");



            Console.WriteLine("----- Convert Data");
            DateTime natal = Convert.ToDateTime("12/25/2026");
            Console.WriteLine($"Natal: {natal.GetType()} - {natal:dd/MMMM/yyyy}");
            Console.WriteLine($"Natal: {natal.Day} - {natal.Month} - {natal.Year}");

        } catch(Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Deu erro chefe!");
        }
    }
}