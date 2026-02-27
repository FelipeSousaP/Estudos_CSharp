using Recursividade;
/*Console.Write("numero: ");
int K = int.Parse(Console.ReadLine());

Console.WriteLine(Fatorial.Calcularfatorial(K));
Console.WriteLine(Fatorial.CalcularComRecursividade(K));*/
//receber string
string? Palavra = Console.ReadLine().ToLower();
List<char> list = new List<char>();
//Dividir a string para reconhecer todas as letras dentro de uma array
foreach(char c in Palavra)
{
    list.Add(c);
}

//saber o tamanho da array que pode ser a ultima letra
int carlos = list.Count;
Console.WriteLine(carlos);

//Falar se a primeira letra da array é igual na ultima letra
char primeiroCaractere = list[0];
char Caractere = list[carlos - 1];

char d = Palavra[carlos - 2];

if (primeiroCaractere == Caractere)
{
    Console.WriteLine($"palavra é igual {d}");
}
else
{
    Console.WriteLine("Senta e chora");
}

// a logica deve ser feita com recursividade
// strings são Arrays
