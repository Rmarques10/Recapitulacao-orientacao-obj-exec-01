using Recapitulacao_orientacao_obj_exec_01;
using System.Globalization;

Console.WriteLine("Entre com os dados do produto:");
Console.WriteLine("Nome:");
string nome = Console.ReadLine();
Console.WriteLine("Preço:");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Quantidade:");
int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto(nome, preco, quantidade);
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();

Console.WriteLine("Digite o número de produtos a serem adicionados:");
int qte = int.Parse(Console.ReadLine());

p.AdicionarProtudo(qte);
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();

Console.WriteLine("Digite o número de produtos a serem removidos:");
qte = int.Parse(Console.ReadLine());

p.RemoverProtudo(qte);
Console.WriteLine("Dados do produto: " + p);