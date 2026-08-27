// class Program2
// {
//     interface IPagamento
//     {
//         void Pagar(double valor);
//     }

//     class Pix : IPagamento
//     {
//         public void Pagar(double valor)
//         {
//             Console.WriteLine($"O valor do pix é: {valor}");
//         }
//     }

//     class Cartao : IPagamento
//     {
//         public void Pagar(double valor)
//         {
//             Console.WriteLine($"O valor a pagar é: {valor}");
//             Console.WriteLine("Gostaria de parcelar? ");
//         }
//     }


//     class Boleto : IPagamento
//     {
//         public void Pagar(double valor)
//         {
//             Console.WriteLine($"Aqui esta seu boleto no valor de: {valor}");
//         }
//     }


//     static void Main(string[] args)
//     {
//         IPagamento[] pagamentos =
//         {
//             new Pix(),
//             new Cartao(),
//             new Boleto()    
//         };


//         foreach(IPagamento pagamento in pagamentos)
//         {
//             pagamento.Pagar(100);   
//         }
//     }
// }