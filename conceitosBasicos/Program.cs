// DATA YPES

// bool b1;
// char c1;
// byte b2;
// int i;
// long l;
// float f;
// double d;
// decimal d2;
// string text;  

//===================================================================================================






//=====================  Trabalhando com variaveis  ========================================================

// int idade = 26;
// idade++; // incremento
// Console.WriteLine(idade);
// idade--; // decremento
// Console.WriteLine(idade);
// int i2 = 2;

// int num1 = 10;
// int num2 = 20;
// double resultado;

// // As 4 operações numericas basicas
// Console.WriteLine(num1 + num2);
// Console.WriteLine(num1 / num2); // o resultado sera 0 pq o resultado sera um int e não um double/ponto flutuante = 0,5
// Console.WriteLine(num1 * num2);
// Console.WriteLine(num1 - num2);

// if(num1 / num2 == 0) {
//     resultado = (double)num1 / num2; // Agora converte para double
//     Console.WriteLine(resultado); // Agora imprime 0.5
// }

//=========================================================================================================





//===================================== Calculadora--Pequeno-Desafio =========================================================



// var n1 = Console.ReadLine();
// var n2 = Console.ReadLine();
// var op = Console.ReadLine();

//Console.WriteLine(int.Parse(n1) + int.Parse(n2));

//Console.Read();

//=========================================================================================================





//========================== METODOS ==============================================

//public class Calculator
//{
//    // Construtor correto (vazio)
//    public Calculator() { }

//    // Método Calculate fora do construtor
//    public int Calculate(string op, int value1, int value2)
//    {
//        if (op == "+")
//        {
//            return value1 + value2;
//        }
//        else if (op == "-")
//        {
//            return value1 - value2;
//        }
//        else if (op == "*")
//        {
//            return value1 * value2;
//        }
//        else if (op == "/")
//        {
//            return value1 / value2;
//        }
//        else
//        {
//            return 0;
//        }
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        Calculator calculator = new Calculator();
//        int resultado = calculator.Calculate("+", 10, 20);
//        Console.WriteLine(resultado);
//    }
//}


//Calculator calculator = new Calculator();
//int resultado = calculator.Calculate("+", 10, 20);
//Console.WriteLine(resultado);
//Console.Read();


//=====================================  SWITCH  ====================================================================

// Console.Write("Digite o primeiro valor: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.Write("Digite o segundo valor: ");
// int num2 = int.Parse(Console.ReadLine());

// Console.Write("Digite a operação: (+, -, *, /) ");
// string op = Console.ReadLine();

// int resultado = 0;

// switch (op)
// {
//     case "+":
//         resultado = num1 + num2;
//         break;
//     case "-":
//         resultado = num1 - num2;
//         break;
//     case "*":
//         resultado = num1 * num2;
//         break;
//     default:
//         Console.WriteLine("Operação inválida");
//         return;

// }

// Console.WriteLine(resultado);


//=========================================================================================================






//=====================================  LIST  ====================================================================

// serve para você armazenar uma coleção de objetos, que podem ser de diferentes tipos, em uma lista.

//List<string> nomes = new List<string>();

//nomes.Add("1");
//nomes.Add("2");
//nomes.Add("José");


// Tratanento de erro com try catch 

//try
//{
//    // o foreach é um laço de repetição que percorre todos os elementos de uma coleção, como uma lista, por exemplo.
//    foreach (string nome in nomes)
//    {
//        var myNumber = Convert.ToInt32(nome);
//        if (myNumber > 1)
//        {
//            Console.WriteLine("Convite enviado ao remetente " + nome);

//        }

//    }
//}
//catch (Exception ex)
//{
//    // log de error
//	throw new Exception("Sistema indisponivel nomomento");
//    Console.ReadKey();
//}


//=========================================================================================================


//=====================================  WHILE  ====================================================================

//o while é um laço de repetição que executa um bloco de código enquanto uma condição for verdadeira.
// var count = 0;
// while ( count < nomes.Count)
// {
//     Console.WriteLine("Convite enviado ao remetente " + nomes[count]);
//     count++;
// }

//=========================================================================================================


//=====================================  CLASS  ====================================================================

//using System.Reflection.Emit;



// class Program
// {

//     internal class Customer
//     {
//         public string Name { get; set; }
//         public int Age { get; set; }
//         public int Phone { get; set; }


//         // construtor serve para inicializar a classe com valores padrões ou valores que são passados como parâmetros
//         public Customer(string name, int age, int phone)
//         {
//             Name = name;
//             Age = age;
//             Phone = phone;
//         }
//     }


//     static void Main()
//     {
//         Customer customer = new Customer("Carlos", 26, 123123123);
//         Console.WriteLine(customer.Name);
//         Console.Read();



//     }


// }


//Customer customer = new Customer();
//customer.Name = "Carlos";
//customer.Age = 26;
//customer.Phone = 123456789;

//Console.WriteLine(customer.Name);

//Console.Read();



//=========================================================================================================


//=====================================  HERANÇA  ====================================================================

// class Animal 
// {
//     public string? Name { get; set;}
//     // ? operador de tipo nulavel para indicar que Name pode ser
//     // nulo, ou seja, pode não ter valor.
//     public void Eat() 
//     {

//         Console.WriteLine($"{Name}  is eating");
//     }

//     public virtual void EmitirSom() 
//     {
//         Console.WriteLine("Animal is Emitindo Som");
//     }
// }

// class Dog : Animal
// {
//     public void Bark() 
//     {

//         Console.WriteLine("Dog is Barking");
//     } 

//     public override void EmitirSom() 
//     {
//         Console.WriteLine("au au au");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Dog dog = new Dog();
//         dog.Name = "Rex";
//         dog.Eat();
//         dog.Bark();
//         dog.EmitirSom();
//         Console.Read();
//     }

// }




// ============================= ENCAPSULAMENTO ==============================================// Arquivo inteiro só com instruções diretas
// namespace ENCAPSULAMENTO
// {
//     class Program
//     {
//         class Pessoa {

//             private string nome;    
//             public string Nome { get{ return nome; } 
//             set {
//                 if (!string.IsNullOrWhiteSpace(value))
//                 {
//                     nome = value;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Nome inválido.");
//                 }
//             }}



//         }



//         static void Main(string[] args) {

//             Pessoa p = new Pessoa();
//             p.Nome = "Lucas";
//             Console.WriteLine(p.Nome);

//             Pessoa p2 = new Pessoa();
//             p2.Nome = "";
//             Console.WriteLine(p2.nome);

//         }
//     }
// }






// using System;

// namespace MeusCodigos
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Pessoa p = new Pessoa();
//             p.Nome = "Lucas";
//             Console.WriteLine(p.Nome);
//         }
//     }

//     class Pessoa
//     {
//         public string Nome { get; set; }
//     }
// }


namespace Alunos
{
    class Aluno
    {
        // 1 maneira
        private string? _nome;
        public string? Nome {
            get { return _nome; }
            set { _nome = value; }
        }

        // 2 maneira 
        public double Media { get; set; }
    }

     class Program  {
        static void Main(string[] args) 
        {
            Aluno obj = new();
            obj.Nome = "Carlos";
            obj.Media = 10;

            Console.WriteLine($"{obj.Nome} obteve média {obj.Media}");
        }
    }
}
