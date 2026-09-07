using System;
using System.Collections.Generic;

class CidadesComNumeros
{
    static void Main(string[] args)
    {
        var paises = new Dictionary<int, string>
        {
          [100] = "Brasil",
          [2] = "Australia",
          [60] = "Nova Zelandia"  
        };

        foreach (var pais in paises)
        {
            Console.WriteLine($"{pais.Key} - {pais.Value}");
        }
    }
}