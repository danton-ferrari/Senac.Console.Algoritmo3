using System.Globalization;

Console.Write("Informe seu nome completo: ");
string nomeCompleto = Console.ReadLine() ?? "";
Console.WriteLine(nomeCompleto);
Console.WriteLine("");

Console.Write("Quantos quartos tem na sua casa? ");
int qtdeQuartos = int.Parse(Console.ReadLine());
Console.WriteLine($"Você tem {qtdeQuartos} quartos ");
Console.WriteLine("");

Console.Write("Informe o preço da sua internet: ");
double precoInternet = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine($"O preço da sua internet é R${precoInternet:F2}");
Console.WriteLine("");

Console.Write("Informe seu ultimo nome, idade e altura na mesma linha: ");
string[] ultimoNomeIdadeAltura = Console.ReadLine().Split(' ');
string ultimoNome = ultimoNomeIdadeAltura[0];
int idade = int.Parse(ultimoNomeIdadeAltura[1]);
double altura = double.Parse(ultimoNomeIdadeAltura[2], CultureInfo.InvariantCulture);
Console.WriteLine($"Seu ultimo nome é {ultimoNome}");
Console.WriteLine($"Sua idade é {idade} anos");
Console.WriteLine($"Sua altura é {altura:F2}m");
Console.WriteLine("");

Console.ReadKey();
