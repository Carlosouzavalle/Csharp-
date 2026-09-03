namespace ConceitosBasicos
{
    class Program7
    {
        public class ListaGenerica<T>
        {
            public void Adicionar(T input) { }
        }

        class TestGenerica
        {
            private class ExampleClass { }
            static void Main(string[]args)
            {   // uma lista tipo int
                ListaGenerica<int> lista1 = new ListaGenerica<int>();

                lista1.Adicionar(1);

                // declarando uma lista do tipo string
                ListaGenerica<string> lista2 = new ListaGenerica<string>();
                lista2.Adicionar("");


                ListaGenerica<ExampleClass> lista3 = new ListaGenerica<ExampleClass>();
                lista3.Adicionar(new ExampleClass());

            }
        }
        
    }
}


// Os tipos genéricos facilitam esse cenário e tudo que precisamos
// fazer é utilizar parâmetros do tipo genérico T. Podemos então escrever uma única classe que qualquer outra parte do sistema pode
// utilizar sem precisar criar uma nova estrutura e passando o tipo específico que ela deseja


// Os tipos genéricos facilitam criar as estruturas de dados de uma
// forma dinâmica, facilitando a centralização e reaproveitamento de
// código. No exemplo anterior, a classe ListaGenerica<T> assume essa
// responsabilidade de flexibilizar a tipagem de dados utilizando o pa-
// râmetro <T>. Dessa forma, podemos passar qualquer tipagem de
// dados e utilizar essa classe em qualquer local do sistema de forma
// centralizada