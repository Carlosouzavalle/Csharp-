// Data types
// Console.WriteLine("Hello, World!");

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


// int idade = 26;
// idade++; // incremento
// Console.WriteLine(idade);
// idade--; // decremento
// Console.WriteLine(idade);
// int i2 = 2;

// idade = i2 == 42 ? 10 : 20;

// Console.Write(i2);


// Console.Write("Digite seu nome: ");
// string name = Console.ReadLine();
// Console.WriteLine("Bem vindo " + name);
// Console.Write("Digite o ano do seu nascimento: ");
// int year = int.Parse(Console.ReadLine());
// // int.Parse(); ele vai passarint pra uma string
// int age = 2025 - year;
// Console.WriteLine($"Você tem {age} anos e nasceu no ano de {year}");



//estrutura condicional
// if(age  > 18 && name == "Carlos") {
//     Console.WriteLine("Você é maior de idade!!!");
// } else if (age > 10) {
//     Console.WriteLine("Você é uma criança");
// }
// else {
//     Console.WriteLine($"Você é menor de idade, você tem {2025 - year} anos de idade");
// }


//ARRAYS
//top level statements aparte do c# 9 agora podemos escrever nosso  codigo sem namespace,class e metodo main
//string[] names = {"Carlos", "Eduardo"};


//metodo antigo
// class Program 
// {
//     static void Main() {
//         string[] names = {"Carlos", "Eduardo"};        
//         Console.WriteLine("Teste");
        
//         // foreach(string name in names) {
//         //     Console.WriteLine(name);
//         // }


//         for (int i = 0; i < 2 ; i++)
//         {
//             Console.WriteLine(names[i]);
//         }


//     }
// }



//=============================================
// OUTRA COISAS COM STRING


// string name = "Carlos";
// Console.WriteLine(name.Length);
// Console.WriteLine(name.EndsWith("a")); // false 
// Console.WriteLine(name.EndsWith("s")); // true 
// Console.WriteLine(name.EndsWith("S")); // false
// Console.WriteLine(name.StartsWith("a")); // false
// Console.WriteLine(name.StartsWith("C")); // true
// Console.WriteLine(name.StartsWith("c")); // 



// string s = null;


// try
// {
//     Console.WriteLine(s.Length);
// }
// catch (System.NullReferenceException)
// {
//     Console.WriteLine("Erro!!! Referencia nula");
//     throw;
// }


//CLASS

BankAccount account1 = new  BankAccount("Carlos", 100);
BankAccount account2 = new  BankAccount("Bia", 100);


account1.Deposit(-100);
account2.Deposit(150);

//account2.Balance = 1000;
Console.WriteLine(account2.Balance);


class BankAccount {
    private string name;
    // private decimal balance;

    //OUTRA MANEIRA DE ACESSAR O BALANCE

    public decimal Balance {
        get; private set;
        //private set { balance = value; }
    }


    public BankAccount(string name, decimal balance) {
    

    
        if(string.IsNullOrWhiteSpace(name)) {
            throw new Exception("Nome invalido");
        }
    
        if(balance < 0) 
        {
            throw new Exception("Saldo não pode sernegativo");  
        }

        this.name = name;
        Balance = balance;
    }


    public void Deposit(decimal amount) {
        if(amount <- 0) {
            return;
        } 
       
        Balance+=amount;    

    }

    // public decimal Getbalance() {
    //     return balance;
    // }    

}