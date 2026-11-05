/////////////////////////////////////////////////////////////////

// 1)

// Console.WriteLine($" Digite o nome do Produto:");
// string produto = Console.ReadLine();


// Console.WriteLine($" Digite a Quantidade:");
// int quantidade = int.Parse(Console.ReadLine()!);

// Console.WriteLine($" Informe o Preço:");
// int preco = int.Parse(Console.ReadLine()!);

// Console.WriteLine($" Valor:");
// decimal valor = preco * quantidade; 
// Console.WriteLine($" Você comprou {quantidade} {produto} pelo preço de ${valor:F2}");

/////////////////////////////////////////////////////////////////

// 2)

// Console.WriteLine($" Digite seu nome:");
// string nome = Console.ReadLine();


// Console.WriteLine($" Digite sua nota:");
// int nota = int.Parse(Console.ReadLine()!);

// if ( nota >= 7)
// {
//     Console.WriteLine($"{nome} Está aprovado! :D");
// }

// else if (nota >= 5 && nota <7)
// {
//     Console.WriteLine($"{nome} Está de recuperação :/");
// }

// else if (nota < 5)
// {
//     Console.WriteLine($"{nome} Está de reprovado :(");
// }

/////////////////////////////////////////////////////////////////

// 3)

// int? numeroSecreto = 7;

// Console.WriteLine("Adivinhe o número secreto: ");
// int palpite = int.Parse(Console.ReadLine());
// int tentativas = 0;

// do
// {
//     if (palpite == numeroSecreto)
//     {
//         Console.WriteLine("Parabéns! Você acertou o número secreto!");
//         tentativas++;
//         break;
//     }
//     else if (palpite < numeroSecreto)
//     {
//         Console.WriteLine("O número secreto é maior. Tente novamente: ");
//         tentativas++;
//     }
//     else
//     {
//         Console.WriteLine("O número secreto é menor. Tente novamente: ");
//         tentativas++;
//     }

//     palpite = int.Parse(Console.ReadLine());
// } while (true);

// Console.WriteLine($"Você realizou {tentativas} tentativas.");
// */

/////////////////////////////////////////////////////////////////

// 4)

/*
int Somar(int a, int b)
{
    return a + b;
}

int Multiplicar(int a, int b)
{
    return a * b;
}

Console.WriteLine("Digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

int resultadoSoma = Somar(numero1, numero2);
int resultadoMultiplicacao = Multiplicar(numero1, numero2);

Console.WriteLine($"A soma de {numero1} e {numero2} é: {resultadoSoma}");
Console.WriteLine($"A multiplicação de {numero1} e {numero2} é: {resultadoMultiplicacao}");
*/

/////////////////////////////////////////////////////////////////

// 5)

/*
int[] notasAluno = new int[3];
int notaTotal = 0;

for (int i = 0; i < notasAluno.Length; i++)
{
    Console.WriteLine($"Digite a {i + 1}º nota do aluno: ");
    notasAluno[i] = int.Parse(Console.ReadLine());
}

foreach (int nota in notasAluno)
{
    notaTotal += nota;

}

int notaMedia = notaTotal / notasAluno.Length;
Console.WriteLine($"A nota média do aluno é: {notaMedia}");
*/

/////////////////////////////////////////////////////////////////

// 6)

/*
List<string> listaProdutos = new List<string>();

Console.WriteLine("Digite o nome do produto 1: ");
string? produto1 = Console.ReadLine();
Console.WriteLine("Digite o nome do produto 2: ");
string? produto2 = Console.ReadLine();
Console.WriteLine("Digite o nome do produto 3: ");
string? produto3 = Console.ReadLine();

listaProdutos.Add(produto1);
listaProdutos.Add(produto2);
listaProdutos.Add(produto3);

Console.WriteLine("Lista de produtos cadastrados: ");
foreach (string produto in listaProdutos)
{
    Console.WriteLine(produto);
}

Console.WriteLine("Digite o nome do produto que deseja buscar na lista: ");
string? produtoBuscar = Console.ReadLine();

string? produtoEncontrado = listaProdutos.Find(n => n == produtoBuscar);
do
{
    if (produtoEncontrado != null)
    {
        Console.WriteLine($"O produto {produtoEncontrado} foi encontrado na lista.");
        break;
    }
    else
    {
        Console.WriteLine($"O produto {produtoBuscar} não foi encontrado na lista. Digite outro produto para buscar: ");
        produtoBuscar = Console.ReadLine();
        produtoEncontrado = listaProdutos.Find(n => n == produtoBuscar);
    }
} while (true);


Console.WriteLine("Digite o nome do produto que deseja remover da lista: ");
string? produtoRemover = Console.ReadLine();

listaProdutos.Remove(produtoRemover);

Console.WriteLine("Lista de produtos atualizada: ");
foreach (string produto in listaProdutos)
{
    Console.WriteLine(produto);
}
*/