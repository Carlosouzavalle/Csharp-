

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // int d = 12;
        // int m = 05;
        // int a = 2021;
        // DateTime dtAniversario = new DateTime(a, m, d);
        // DateTime dtFesta = new DateTime(2021, 08, 25);
        // Console.WriteLine("Funções de Datas");
        // Console.WriteLine($"Aniversario: {dtAniversario}");
        // Console.WriteLine($"{dtAniversario:dd/MM/yyyy}");
        // Console.WriteLine($"Aniversario: {dtAniversario:ddd/MMM/yyyy}");
        // Console.WriteLine($"Aniversario: {dtAniversario:dddd dd/MMM/yyyy}");

//=====================================================================

        // we are working with time today and now 
        // DateTime hoje = DateTime.Today;
        // Console.WriteLine($"Today: {hoje:dd/MM/yyyy}");

        // DateTime agora = DateTime.Now;
        // Console.WriteLine($"Agora: {agora}");
        // Console.WriteLine($"Agora: {agora:dd/MM/yyyy hh:mm:ss}");


//=====================================================================
        // Day, Month, Yeah, Hour, Minute, Miliseconds, Microseconds we can get separatly
        DateTime DataHora = DateTime.Now; // it give us the exactly hour and date
        // Console.WriteLine($"DAY: {DataHora.Day}");
        // Console.WriteLine($"MONTH: {DataHora.Month}");
        // Console.WriteLine($"YEAR: {DataHora.Year}");
        // Console.WriteLine($"Hour: {DataHora.Hour}");
        // Console.WriteLine($"Minutes: {DataHora.Minute}");
        // Console.WriteLine($"Miliseconds: {DataHora.Millisecond}");
        // Console.WriteLine($"Microseconds: {DataHora.Microsecond}");
   
//=================================================================

        // now we are manipulate dates

        DateTime dtPedido = DateTime.Today;
        //add 35 days
        DateTime dtVencto = dtPedido.AddDays(35);

        //add 2 month
        DateTime dtPagto = dtVencto.AddMonths(2);
        Console.WriteLine($"Pedido feito em: {dtPedido:dd/MMM/yyyy} vence em {dtVencto:dd/MMM/yyyy}");



        // One formataion more long and another is more short 
        Console.WriteLine($"Formatação completa: {dtVencto.ToLongDateString()}");

        Console.WriteLine($"Formatação curta: {dtVencto.
        ToShortDateString()}");


        // day of the week
        Console.WriteLine($"Dia da Semana: {dtVencto.DayOfWeek}");
        Console.WriteLine($"Dia da Semana em Japonês: {dtVencto.ToString("dddd", new CultureInfo("ja-JP"))}");
        Console.WriteLine($"Numero do dia da semana: {(int)dtVencto.DayOfWeek}");

        //day of the year
        Console.WriteLine($"dia do Ano: {dtVencto.DayOfYear}");

        // we are sub 2 days
        var qtdDias = dtPagto.Subtract(dtPedido);
        Console.WriteLine($"Entre o pedido e o pagamento foram {qtdDias:dd} dias");

    }    
}




// TODAY
// A propriedade Today do DateTime retorna a data completa com o
// dia, mês e ano do sistema operacional. Usamos com muita frequen-
// cia em aplicações onde precisamos saber a data no dia de hoje,
// assim o usuário não tem como informar, a data é capturada direta-
// mente da máquina e não existem parâmetros.

// NOW
// A propriedade Now do DateTime retorna a data, hora, minutos e
// segundos automaticamente do sistema operacional. Em aplicações
// de bolsa de valores, transações em bancos e uso de medicamentos
// são apenas alguns exemplos de onde são utilizadas.