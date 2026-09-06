using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ConceitosBasicos
{
    class Program
    {

        //var sexo = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            var sexo = new Dictionary<string, string>();
            sexo.Add("M", "Masculino");
            Console.WriteLine(sexo["M"]);

        }
    }
}