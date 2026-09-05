using System;

namespace ConceitosBasicos
{
    class TratamentoDeErro
    {
        public void Exemplo()
        {
            Console.WriteLine("Divisão de dois numeros");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro numero");

            var strnum1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero");
            var strnum2 = Console.ReadLine();

            try
            {
                int num1 = int.Parse(strnum1);
                int num2 = int.Parse(strnum2);
                var divisao = num1 / num2;
                Console.WriteLine($"O valor de {strnum1} divido por {strnum2} é {divisao}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Puts ouve um erro de procesamento!");
            }
        }

        static void Main(string[] args)
        {
            var tratamento = new TratamentoDeErro();
            tratamento.Exemplo();
        }
    }
}




// Então o código que queremos proteger fica dentro do bloco try,
// que no nosso exemplo é a conversão do dado e a divisão. Se acon-
// tecer algum erro dentro do try, então o bloco catch é chamado, e no
// nosso caso, mostramos uma mensagem que recebemos de erro. O
// nosso exemplo não tem um finally, mas iremos explorar este bloco
// logo mais.


// O bloco try..catch..finally é muito útil mas não deve ser utilizado
// em toda a sua aplicação, ou seja, não comece o código com um try,
// coloque o bloco onde você realmente precisa. E isto você vai apren-
// dendo com o uso da linguagem e a construção de aplicações. Mas
// te pedimos para nunca escrever um bloco try como do exemplo a
// seguir


// public static void NaoFacaTryCatchAssim()
// {
//     try
//     {
//         int a = 1;
//         int b = 0;
//         int c = a / b;
//     }
//     catch
//     {
//     }
// }


// Este código provoca um erro que pode nunca ser encontrado,
// pois o catch não mostra nada, absolutamente nada. Se você não
// tem certeza do que escrever no catch, use o comando throw


// {
//     try
//     {
//         int a = 1;
//         int b = 0;
//         int c = a / b;
//     }
//     catch
//     {
//         throw;
//     }
// }

// O throw joga a exceção para quem chamou o código