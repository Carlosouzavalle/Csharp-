class Program1
{
    static void Main(string[] args)
    {
        List<string> funcionarios = new List<string>();
        funcionarios.Add("Maria");
        funcionarios.Add("João");;
        funcionarios.Add("André");
        funcionarios.Add("Flávia");

        foreach(string funcionario in funcionarios)
        {
            Console.WriteLine(funcionario);
            
        }
        Console.WriteLine("teste: " + funcionarios[0]);

        funcionarios.RemoveAt(3); // removendo um item da lista
        foreach(string funcionario in funcionarios)
        {
            Console.WriteLine(funcionario);
            
        }
    }
}

// As listas no C# têm a finalidade de armazenar um tipo de dados
// no sistema. Esses tipos de dados comumente são denominados
// como listas tipadas. Ao se referir a “tipadas”, estamos meramente
// informando ou entendendo que ao criar uma lista com um tipo de
// dados, como por exemplo string, todos os valores daquela lista de-
// vem ser de fato uma string. A tipagem garante que estamos traba-
// lhando de forma efetiva e não estamos misturando tipos de dados
// diferentes na mesma coleção.