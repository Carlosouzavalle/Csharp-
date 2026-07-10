// double valor = 2;


// for(int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{valor} x {i} = {valor * i}");
// }


// Em C# quando queremos usar template string utilizamos o simbolo $, porem diferente do JavaScript que usa ` essa forma ` em C# usamos aspas duplas " " para definir a string.

Console.WriteLine("Digite um valor para ver a tabuada: ");
double valor = double.Parse(Console.ReadLine());


while (valor <= 0 || valor >= 1)
{
    double tabuada = 2;
    while(tabuada <= 10)
    {
        Console.WriteLine($"{valor} x {tabuada} = {valor * tabuada}");
        tabuada++;
    }

    
    Console.WriteLine("Digite um valor: ");
    valor = double.Parse(Console.ReadLine());
    
}