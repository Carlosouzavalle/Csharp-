class Program2
{
    // CONVERSÕES DE DATAS 
    static void Main(string[] args)
    {
        string dataTexto = "01/09/2026";

        if (DateTime.TryParse(dataTexto, out DateTime dataTextoConvertida))
        {
            Console.WriteLine("Data com conversão aceita");
            Console.WriteLine(dataTextoConvertida);
        }
        else
        {
            Console.WriteLine("Erro na conversão da data");
        }

        // string dataTextoErrada = "15/metade do ano/2021";
        // DateTime datatTextoErradaConvertida;
        // if(DateTime.TryParse(dataTextoErrada, out datatTextoErradaConvertida))
        // {
        //     Console.WriteLine("Data com conversão aceita");
        // } else
        // {
        //     Console.WriteLine("Erro da conversão da data");
        // }
    }
}