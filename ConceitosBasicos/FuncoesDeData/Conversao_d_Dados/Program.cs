namespace ConceitosBasicos
{
    class conversaoDados
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("---------Boxing");
            // int percentual = 10;
            // object objPercentual = percentual;
            // Console.WriteLine($"percentual: {percentual} - {percentual.GetType()}");
            // Console.WriteLine($"objPercentual: {objPercentual} - {objPercentual.GetType()}");

            // decimal salario = 12500.50M;
            // object objSalario = salario;
            // Console.WriteLine($"salario: {salario} - {salario.GetType()}");
            // Console.WriteLine($"objsalario: {objSalario} - {objSalario.GetType()}");
            // unboxing (converte um objeto para um tipo)
            object objDesconto = 10;
            int desconto = (int)objDesconto;
            Console.WriteLine("----- Unboxing");
            Console.WriteLine($"desconto: {desconto} - {desconto.GetType()}");
            Console.WriteLine($"objDesconto: {objDesconto} - {objDesconto.GetType()}");
        }
    }
}



            // BOXING
            // Agora vamos adicionar o seguinte bloco de código para fazer-
            // mos o Boxing de tipos texto (string) e data (DateTime). A ideia é a
            // mesma que a anterior, criamos as variáveis que serão atribuídas a
            // um object e, ao final, mostramos os dados.
            
            // string nome = "Visual C#";
            // object objNome = nome;

            // Console.WriteLine($"nome: {nome} - {nome.GetType()}");
            // Console.WriteLine($"objNome: {objNome} - {objNome.GetType()}");

            // DateTime hoje = DateTime.Today;
            // object objHoje = hoje;

            // Console.WriteLine($"hoje: {hoje} - {hoje.GetType()}");
            // Console.WriteLine($"objHoje: {objHoje} - {objHoje.GetType()}");





            //UNBOXING
            // Agora vamos criar um código para mostrar o unboxing, que é o
            // oposto do boxing. Neste caso, vamos definir a variável objDesconto
            // do tipo object que é atribuída à variável desconto do tipo int. Note
            // na sintaxe que é obrigatório colocar entre parênteses do tipo da
            // variável que receberá o object. Neste caso, usamos (int)objDesconto.
            // Ao final, mostraremos o conteúdo e o tipo de dado
            // Tenha em mente que no unboxing o object a ser
            // atribuído precisa permitir tal conteúdo, não adianta jogar um dado
            // texto em um int ou double que dará erro.