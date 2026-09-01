class Program4
{
    class Pedido
    {
        public int PedidoID{get; set;}
        public DateTime DtPedido {get; set;}
        public DateTime dtVencimento() => DtPedido.AddDays(30);
        public DateTime DtPagto {get; set;}
        public TimeSpan DiasAtraso() => DtPagto.Subtract(dtVencimento());
        public decimal Valor { get; set; }
        public decimal Multa => Valor * 0.10M;
    }

    static void Main(string[] args)
    {
        //Uso de datas em objs
        var pedido = new Pedido
        {
            PedidoID = 1,
            DtPedido = DateTime.Today,
            DtPagto = DateTime.Today.AddDays(45),
            Valor = 1500
        };

        Console.WriteLine($"Pedido: {pedido.PedidoID} - " + $"{pedido.DtPedido:dd/MMM/yyyy} - " + $"vencto: {pedido.dtVencimento():dd/MMM/yyyy} - " + $"dias atraso: {pedido.DiasAtraso().TotalDays} - " + $"Valor: {pedido.Valor:n2} - " + $"multa: {pedido.Multa:n2}");
    }
}


// DATAS EM OBJETOS
// A Programação Orientada a Objetos (OOP) nos ajuda na estru-
// tura dos objetos, entre muitos outros benefícios que não é o foco
// agora, temos um capítulo somente deste tópico. O importante aqui
// é criarmos um objeto chamado Pedido contendo as respectivas
// propriedades, conforme código a seguir. Todo objeto é uma classe,
// então na parte inferior do código, após a class funcoesDatas, declare
// uma classe pública (public class Pedido).
// Em seguida, digite todas as propriedades do Pedido, sendo o
// PedidoID (chave do pedido), as datas DateTime DtPedido, DtVencto
// (que automaticamente adiciona 30 dias baseado na DtPedido), DtPa-
// gto, DiasAtraso (tipo TimeSpan) que faz a subtração entre DtPagto e
// DtVencto, o Valor e a Multa de 10% a ser aplicada.