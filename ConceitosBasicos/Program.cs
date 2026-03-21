// Variaveis

// var variavel = 15;
// var variavel = true;

// string variavel =  "Carlos";
// int idade = 27;
// Console.WriteLine($"{variavel} {idade}");


// O var ele consegue ser dinamico a ponto de você não precisar especificar o tipo da variavel
// lembrando que em c# você precisa definir o tipo de dado antes de declarar a variavel a não ser no caso a acima

//======================================================================================
// Concatenação

// string nome = "Carlos";
// int idade = 27;

// Console.WriteLine("Meu nome é " + nome + " e tenho " + idade);
// porem quando temos muita concatenação começa a ficar estranho para evitar isso utilizamos interpolação de string.
// Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos de idade.");


//======================================================================================

// Operadores 

// int a = 10;
// int b = 9;

// Console.WriteLine(a + b); // soma
// Console.WriteLine(a - b); // subtração
// Console.WriteLine(a / b); // divisão
// Console.WriteLine(a * b); // multiplicação
// Console.WriteLine(a % b); // resto da divisão
// Console.WriteLine($"È igual {a == b}"); // true e false apenas dois valores
// Console.WriteLine($"È maior {a > b}");
// Console.WriteLine($"È menor {b < a}");
// Console.WriteLine($"È menor ou igual {a <= b}");
// Console.WriteLine($"È maior ou igual {a >= b}");

// Operadores logicos

// bool a = true;
// bool b = false;

// if(a || b)
// {
//     Console.WriteLine("Operador OR (||)");
// }

// Operador OR se alguma condição for verdadeiro ele cai no if


// bool a = true;
// bool b = true;

// if(a && b)
// {
//     Console.WriteLine("Operador E (&&)");
// }

// na condição E ambos tem que ser verdadeiro do contrario não vai funcionar


//===================================================================================
// condicional

// bool a = true;

// if(!a)
// {
//     Console.WriteLine("Operador de negação (!)");
// } 
// else
// {
//     Console.WriteLine("False");
// }

// operador de negação pega algo que é false e transforma em true e vice e versa

//===================================================================================

// FUNÇÕES / METODOS
// as funções ou metodos é a mesma coisa e em c# são diferentes de linguagens como javascript, python


// void saudacao(string nome)
// {
//     Console.WriteLine($"Bem-vindo {nome} ao nosso site!!!");
// }

// saudacao("Carlos");


// é void pois não retorna nada, apenas apresenta a mensagem que pedimos

//===================================================================================

// ESTRUTURAS DE CONTROLE

// int idade = 17;

// if (idade >= 18)
// {
//     Console.WriteLine("Maior de Idade");
// } else
// {
//     Console.WriteLine("Menor de idade");
// }

//===================================================================================

// SWITCH CASE


// string cor = "preto";

// switch (cor)
// {
//     case "azul":
//         Console.WriteLine("a cor é azul");
//         break;
//     case "vermelho":
//         Console.WriteLine("a cor é vermelho");
//         break;
//     case "preto":
//         Console.WriteLine("a cor é preto");
//         break;

//     default:
//         Console.WriteLine("Nenhuma cor encontrada");
//         break;
// }

// ele vai percorer todo switch e se encontrar o valor pedido ele retorna e sai do bloco com o break mais pode continuar també, se usarmos o continue, caso ele não encontre  nada ele cai no default e retorna o que tem lá

//===================================================================================

// LAÇO FOR

// for(int i = 0; i < 4; i++)
// {
//     Console.WriteLine($"O valor é {i}");
// }

// Um laço de repetição basicamente ele vai percorer até completar alguma exigencia
// por exemplo a que temos acima 


//=================================================================

// WHILE LOOP

// int a = 0;

// while (a < 10)
// {
//     Console.WriteLine(a);
//     a++;
// }

// enquanto a < 0 a++ o quer dizer quue a vai até 9 porque começa em 0
// temos também o do while

//=======================================================================================

// DO WHILE

// int a = 0;
// do
// {
//     Console.WriteLine(a);
//     a++;
// } while (a < 5);

// a diferença aqui é que ele ler o codigo pelo menos uma vez.

//========================================================================================

// ARRAYS AND FOREACH

// string[] frutas = {"maça", "laranja","uva"};


// foreach(string fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }

// também funciona para inteiros

// int[] numeros = {1,2,3,4,5};

// foreach(int numero in numeros)
// {
//     Console.WriteLine(numero);
// }

// ORIENTAÇÃO A OBJETOS




using System;

class Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome} Idade: {Idade}");
    }
}

// class Teste
// {
//     public void Executar()
//     {
//         Pessoa p2 = new Pessoa();
//         p2.Nome = "Lua";
//         p2.Idade = 25;

//         p2.Apresentar();
//     }
// }

class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa("Carlos", 27); // instancia da classe Pessoa
        p.Apresentar();

        // p.Nome = "Carlos";
        // p.Idade = 27;


        // Teste t = new Teste();
        // t.Executar();
    }
}



// dentro de classes temos modificadores de acesso public pode ser acessado de qualquer lugar, protected é apenas na propria classe ou nas classes que extedem essa classe (herança).
// private acesso somente a esta classe.