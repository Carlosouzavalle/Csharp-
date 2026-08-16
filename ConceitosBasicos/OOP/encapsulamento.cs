namespace ConceitosBasicos
{
    class Encapsulamento
    {
        class ContaBancaria
        {
            private double saldo = 100;

            public double Saldo
            {
                get { return saldo; }
            }

            public double Depositar(double valor)
            {
                if (valor > 0)
                {
                    saldo += valor;
                }

                return saldo;
            }

            public double Saque(double valor)
            {
                if (valor > 0 && valor <= saldo)
                {
                    saldo -= valor;
                }

                return saldo;
            }
            
        }


        static void Main(string[] args)
        {
            ContaBancaria novaConta = new ContaBancaria();
            novaConta.Depositar(50);
            Console.WriteLine(novaConta.Depositar(50));
            Console.WriteLine(novaConta.Saque(40));
            Console.WriteLine(novaConta.Depositar(-50));
            Console.WriteLine(novaConta.Saque(-50));
            // novaConta.saldo = 20000; // vai conseguir acessar fora da classe
            // Console.WriteLine(novaConta.saldo);
            // Console.WriteLine(novaConta.Depositar(50));
            // Console.WriteLine(novaConta.Saque(40));
            // Console.WriteLine(novaConta.saldo);
            
        }
    }
}