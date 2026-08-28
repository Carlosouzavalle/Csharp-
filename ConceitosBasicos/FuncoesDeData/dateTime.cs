

class Program
{
    static void Main(string[] args)
    {
        int d = 12;
        int m = 05;
        int a = 2021;
        DateTime dtAniversario = new DateTime(a, m, d);
        DateTime dtFesta = new DateTime(2021, 08, 25);
        // Console.WriteLine("Funções de Datas");
        // Console.WriteLine($"Aniversario: {dtAniversario}");
        // Console.WriteLine($"{dtAniversario:dd/MM/yyyy}");
        // Console.WriteLine($"Aniversario: {dtAniversario:ddd/MMM/yyyy}");
        // Console.WriteLine($"Aniversario: {dtAniversario:dddd dd/MMM/yyyy}");

        DateTime hoje = DateTime.Today;
        Console.WriteLine($"Today: {hoje:dd/MM/yyyy}");
 
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