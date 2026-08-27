class Program3
{
    class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public double Somar(double a, double b)
        {
            return a + b;
        }

        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Somar(double a, double b, double c)
        {
            return a + b + c;
        }
    }

    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine(calc.Somar(10, 20));

        Console.WriteLine(calc.Somar(10.5, 20.5));

        Console.WriteLine(calc.Somar(10, 20, 30));

        Console.WriteLine(calc.Somar(10.5, 20.5, 30.5));
    }
}