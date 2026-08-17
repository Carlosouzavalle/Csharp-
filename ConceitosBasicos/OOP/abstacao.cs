namespace ConceitosBasicos
{
    class Program2
    {
        abstract class Funcionario
        {
            public string Nome { get; set; } = string.Empty;

            public abstract void  Trabalhar();
        };

        class Desenvolvedor : Funcionario
        {
            public override void Trabalhar()
            {
                Console.WriteLine("Desenvolvendo software...");
            }
        }

        class Designer : Funcionario
        {
            public override void Trabalhar()
            {
                // throw new NotImplementedException();
                Console.WriteLine("Criando Interface...");
            }
        }


        static void Main(string[] args)
        {
            Desenvolvedor dev = new Desenvolvedor();
            Designer desg = new Designer();
            dev.Trabalhar();
            desg.Trabalhar();
            // Console.WriteLine(dev.Trabalhar());
            // Console.WriteLine(desg.Trabalhar());
        }
    }

}