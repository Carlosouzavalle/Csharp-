List<string> frutas = new List<string>()
{
    "Maçã",
    "Banana",
    "Uva",
    "Laranja",
    "Abacaxi"
};

Random random = new Random();

int i = random.Next(frutas.Count);

string frutaSorteada = frutas[i];
Console.WriteLine(frutaSorteada);