List<string> alunos = new List<string> { "Carlos", "Bia", "Camila" };
Random random = new Random();

for(int i = 0; i < alunos.Count; i++)
{
    int j = random.Next(i, alunos.Count);
    string temp = alunos[i];
    alunos[i] = alunos[j];
    alunos[j] = temp;
}


Console.WriteLine("A ordem de apresentação dos alunos é:");
foreach (string aluno in alunos)
{
    Console.WriteLine(aluno);
}


Console.ReadKey();