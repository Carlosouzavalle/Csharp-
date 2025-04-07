//faça um programa que mostre os seguintes resultados de um determinado valor 
/// (tipo, se tem espaços, se é um numero, se é alfabético, se é alfanumerico, se esta em maiusculo, 
// se esta em minusculo, e se esta capitalizado ) 


var valor = " 1234";
Console.WriteLine("O Tipo é: " + valor.GetType());


// typeof(Tipo)	Usado para obter o Type de um tipo conhecido em tempo de compilação
// variavel.GetType()	Usado para obter o tipo de uma instância em tempo de execução
if(valor.GetType() === typeof(string))
{
    Console.WriteLine("Hell Yeah!!!");
}